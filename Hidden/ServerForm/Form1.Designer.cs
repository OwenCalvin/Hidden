namespace ServerForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbx_clients = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FunMenu_tab = new System.Windows.Forms.TabPage();
            this.btn_closeCD = new System.Windows.Forms.Button();
            this.btn_openCD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SendScaryMessage = new System.Windows.Forms.Button();
            this.tbx_ScaryMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ShowTaskBar = new System.Windows.Forms.Button();
            this.btn_HideTaskBar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Hibernate = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.Btn_Shutdown = new System.Windows.Forms.Button();
            this.btn_MouseDisable = new System.Windows.Forms.Button();
            this.btn_MouseEnable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.radioButton_text = new System.Windows.Forms.RadioButton();
            this.radioButton_vocal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_message = new System.Windows.Forms.TextBox();
            this.RemoteDesktop_tab = new System.Windows.Forms.TabPage();
            this.btn_ExpandRemoteDesktop = new System.Windows.Forms.Button();
            this.checkBox_Keyboard = new System.Windows.Forms.CheckBox();
            this.checkBox_Mouse = new System.Windows.Forms.CheckBox();
            this.pbx_remoteDesk = new System.Windows.Forms.PictureBox();
            this.btn_StopRD = new System.Windows.Forms.Button();
            this.btn_StartRD = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ExpandRemoteWebcam = new System.Windows.Forms.Button();
            this.btn_findWebcam = new System.Windows.Forms.Button();
            this.cbx_webcam = new System.Windows.Forms.ComboBox();
            this.btn_StopWebcam = new System.Windows.Forms.Button();
            this.btn_StartWebcam = new System.Windows.Forms.Button();
            this.pbx_webcam = new System.Windows.Forms.PictureBox();
            this.dataGridView_Clients = new System.Windows.Forms.DataGridView();
            this.btn_StopServer = new System.Windows.Forms.Button();
            this.btn_startServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.FunMenu_tab.SuspendLayout();
            this.RemoteDesktop_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_remoteDesk)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_webcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_clients
            // 
            this.cbx_clients.FormattingEnabled = true;
            this.cbx_clients.Location = new System.Drawing.Point(318, 107);
            this.cbx_clients.Name = "cbx_clients";
            this.cbx_clients.Size = new System.Drawing.Size(156, 21);
            this.cbx_clients.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FunMenu_tab);
            this.tabControl1.Controls.Add(this.RemoteDesktop_tab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(38, 295);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 374);
            this.tabControl1.TabIndex = 5;
            // 
            // FunMenu_tab
            // 
            this.FunMenu_tab.BackColor = System.Drawing.Color.Silver;
            this.FunMenu_tab.Controls.Add(this.btn_closeCD);
            this.FunMenu_tab.Controls.Add(this.btn_openCD);
            this.FunMenu_tab.Controls.Add(this.label9);
            this.FunMenu_tab.Controls.Add(this.btn_SendScaryMessage);
            this.FunMenu_tab.Controls.Add(this.tbx_ScaryMessage);
            this.FunMenu_tab.Controls.Add(this.label7);
            this.FunMenu_tab.Controls.Add(this.label8);
            this.FunMenu_tab.Controls.Add(this.label6);
            this.FunMenu_tab.Controls.Add(this.btn_ShowTaskBar);
            this.FunMenu_tab.Controls.Add(this.btn_HideTaskBar);
            this.FunMenu_tab.Controls.Add(this.label5);
            this.FunMenu_tab.Controls.Add(this.btn_Hibernate);
            this.FunMenu_tab.Controls.Add(this.btn_Restart);
            this.FunMenu_tab.Controls.Add(this.Btn_Shutdown);
            this.FunMenu_tab.Controls.Add(this.btn_MouseDisable);
            this.FunMenu_tab.Controls.Add(this.btn_MouseEnable);
            this.FunMenu_tab.Controls.Add(this.label4);
            this.FunMenu_tab.Controls.Add(this.btn_sendMessage);
            this.FunMenu_tab.Controls.Add(this.radioButton_text);
            this.FunMenu_tab.Controls.Add(this.radioButton_vocal);
            this.FunMenu_tab.Controls.Add(this.label2);
            this.FunMenu_tab.Controls.Add(this.tbx_message);
            this.FunMenu_tab.Location = new System.Drawing.Point(4, 22);
            this.FunMenu_tab.Name = "FunMenu_tab";
            this.FunMenu_tab.Padding = new System.Windows.Forms.Padding(3);
            this.FunMenu_tab.Size = new System.Drawing.Size(675, 348);
            this.FunMenu_tab.TabIndex = 0;
            this.FunMenu_tab.Text = "Fun Menu";
            // 
            // btn_closeCD
            // 
            this.btn_closeCD.Location = new System.Drawing.Point(150, 266);
            this.btn_closeCD.Name = "btn_closeCD";
            this.btn_closeCD.Size = new System.Drawing.Size(75, 23);
            this.btn_closeCD.TabIndex = 27;
            this.btn_closeCD.Text = "close";
            this.btn_closeCD.UseVisualStyleBackColor = true;
            this.btn_closeCD.Click += new System.EventHandler(this.btn_closeCD_Click);
            // 
            // btn_openCD
            // 
            this.btn_openCD.Location = new System.Drawing.Point(69, 266);
            this.btn_openCD.Name = "btn_openCD";
            this.btn_openCD.Size = new System.Drawing.Size(75, 23);
            this.btn_openCD.TabIndex = 26;
            this.btn_openCD.Text = "open";
            this.btn_openCD.UseVisualStyleBackColor = true;
            this.btn_openCD.Click += new System.EventHandler(this.btn_openCD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "CD :";
            // 
            // btn_SendScaryMessage
            // 
            this.btn_SendScaryMessage.Location = new System.Drawing.Point(515, 224);
            this.btn_SendScaryMessage.Name = "btn_SendScaryMessage";
            this.btn_SendScaryMessage.Size = new System.Drawing.Size(85, 23);
            this.btn_SendScaryMessage.TabIndex = 24;
            this.btn_SendScaryMessage.Text = "send";
            this.btn_SendScaryMessage.UseVisualStyleBackColor = true;
            this.btn_SendScaryMessage.Click += new System.EventHandler(this.btn_SendScaryMessage_Click);
            // 
            // tbx_ScaryMessage
            // 
            this.tbx_ScaryMessage.Location = new System.Drawing.Point(492, 127);
            this.tbx_ScaryMessage.Multiline = true;
            this.tbx_ScaryMessage.Name = "tbx_ScaryMessage";
            this.tbx_ScaryMessage.Size = new System.Drawing.Size(125, 91);
            this.tbx_ScaryMessage.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Scary Message :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fun Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Task Bar :";
            // 
            // btn_ShowTaskBar
            // 
            this.btn_ShowTaskBar.Location = new System.Drawing.Point(542, 70);
            this.btn_ShowTaskBar.Name = "btn_ShowTaskBar";
            this.btn_ShowTaskBar.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowTaskBar.TabIndex = 16;
            this.btn_ShowTaskBar.Text = "Show";
            this.btn_ShowTaskBar.UseVisualStyleBackColor = true;
            this.btn_ShowTaskBar.Click += new System.EventHandler(this.btn_ShowTaskBar_Click);
            // 
            // btn_HideTaskBar
            // 
            this.btn_HideTaskBar.Location = new System.Drawing.Point(461, 70);
            this.btn_HideTaskBar.Name = "btn_HideTaskBar";
            this.btn_HideTaskBar.Size = new System.Drawing.Size(75, 23);
            this.btn_HideTaskBar.TabIndex = 15;
            this.btn_HideTaskBar.Text = "Hide";
            this.btn_HideTaskBar.UseVisualStyleBackColor = true;
            this.btn_HideTaskBar.Click += new System.EventHandler(this.btn_HideTaskBar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Computer :";
            // 
            // btn_Hibernate
            // 
            this.btn_Hibernate.Location = new System.Drawing.Point(213, 224);
            this.btn_Hibernate.Name = "btn_Hibernate";
            this.btn_Hibernate.Size = new System.Drawing.Size(75, 23);
            this.btn_Hibernate.TabIndex = 13;
            this.btn_Hibernate.Text = "hibernate";
            this.btn_Hibernate.UseVisualStyleBackColor = true;
            this.btn_Hibernate.Click += new System.EventHandler(this.btn_Hibernate_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(132, 224);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 23);
            this.btn_Restart.TabIndex = 12;
            this.btn_Restart.Text = "restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // Btn_Shutdown
            // 
            this.Btn_Shutdown.Location = new System.Drawing.Point(51, 224);
            this.Btn_Shutdown.Name = "Btn_Shutdown";
            this.Btn_Shutdown.Size = new System.Drawing.Size(75, 23);
            this.Btn_Shutdown.TabIndex = 11;
            this.Btn_Shutdown.Text = "shutdown";
            this.Btn_Shutdown.UseVisualStyleBackColor = true;
            this.Btn_Shutdown.Click += new System.EventHandler(this.Btn_Shutdown_Click);
            // 
            // btn_MouseDisable
            // 
            this.btn_MouseDisable.Location = new System.Drawing.Point(180, 137);
            this.btn_MouseDisable.Name = "btn_MouseDisable";
            this.btn_MouseDisable.Size = new System.Drawing.Size(75, 23);
            this.btn_MouseDisable.TabIndex = 10;
            this.btn_MouseDisable.Text = "disable";
            this.btn_MouseDisable.UseVisualStyleBackColor = true;
            this.btn_MouseDisable.Click += new System.EventHandler(this.btn_MouseDisable_Click);
            // 
            // btn_MouseEnable
            // 
            this.btn_MouseEnable.Location = new System.Drawing.Point(99, 137);
            this.btn_MouseEnable.Name = "btn_MouseEnable";
            this.btn_MouseEnable.Size = new System.Drawing.Size(75, 23);
            this.btn_MouseEnable.TabIndex = 9;
            this.btn_MouseEnable.Text = "enable";
            this.btn_MouseEnable.UseVisualStyleBackColor = true;
            this.btn_MouseEnable.Click += new System.EventHandler(this.btn_MouseEnable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Block input :";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(235, 68);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_sendMessage.TabIndex = 4;
            this.btn_sendMessage.Text = "send";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // radioButton_text
            // 
            this.radioButton_text.AutoSize = true;
            this.radioButton_text.Location = new System.Drawing.Point(169, 47);
            this.radioButton_text.Name = "radioButton_text";
            this.radioButton_text.Size = new System.Drawing.Size(46, 17);
            this.radioButton_text.TabIndex = 3;
            this.radioButton_text.TabStop = true;
            this.radioButton_text.Text = "Text";
            this.radioButton_text.UseVisualStyleBackColor = true;
            // 
            // radioButton_vocal
            // 
            this.radioButton_vocal.AutoSize = true;
            this.radioButton_vocal.Location = new System.Drawing.Point(111, 47);
            this.radioButton_vocal.Name = "radioButton_vocal";
            this.radioButton_vocal.Size = new System.Drawing.Size(52, 17);
            this.radioButton_vocal.TabIndex = 2;
            this.radioButton_vocal.TabStop = true;
            this.radioButton_vocal.Text = "Vocal";
            this.radioButton_vocal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message :";
            // 
            // tbx_message
            // 
            this.tbx_message.Location = new System.Drawing.Point(99, 70);
            this.tbx_message.Name = "tbx_message";
            this.tbx_message.Size = new System.Drawing.Size(130, 20);
            this.tbx_message.TabIndex = 0;
            // 
            // RemoteDesktop_tab
            // 
            this.RemoteDesktop_tab.BackColor = System.Drawing.Color.Silver;
            this.RemoteDesktop_tab.Controls.Add(this.label10);
            this.RemoteDesktop_tab.Controls.Add(this.btn_ExpandRemoteDesktop);
            this.RemoteDesktop_tab.Controls.Add(this.checkBox_Keyboard);
            this.RemoteDesktop_tab.Controls.Add(this.checkBox_Mouse);
            this.RemoteDesktop_tab.Controls.Add(this.pbx_remoteDesk);
            this.RemoteDesktop_tab.Controls.Add(this.btn_StopRD);
            this.RemoteDesktop_tab.Controls.Add(this.btn_StartRD);
            this.RemoteDesktop_tab.Location = new System.Drawing.Point(4, 22);
            this.RemoteDesktop_tab.Name = "RemoteDesktop_tab";
            this.RemoteDesktop_tab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoteDesktop_tab.Size = new System.Drawing.Size(675, 348);
            this.RemoteDesktop_tab.TabIndex = 1;
            this.RemoteDesktop_tab.Text = "Remote Desktop";
            // 
            // btn_ExpandRemoteDesktop
            // 
            this.btn_ExpandRemoteDesktop.Location = new System.Drawing.Point(615, 6);
            this.btn_ExpandRemoteDesktop.Name = "btn_ExpandRemoteDesktop";
            this.btn_ExpandRemoteDesktop.Size = new System.Drawing.Size(54, 23);
            this.btn_ExpandRemoteDesktop.TabIndex = 6;
            this.btn_ExpandRemoteDesktop.Text = "expand";
            this.btn_ExpandRemoteDesktop.UseVisualStyleBackColor = true;
            this.btn_ExpandRemoteDesktop.Click += new System.EventHandler(this.btn_ExpandRemoteDesktop_Click);
            // 
            // checkBox_Keyboard
            // 
            this.checkBox_Keyboard.AutoSize = true;
            this.checkBox_Keyboard.Location = new System.Drawing.Point(47, 238);
            this.checkBox_Keyboard.Name = "checkBox_Keyboard";
            this.checkBox_Keyboard.Size = new System.Drawing.Size(71, 17);
            this.checkBox_Keyboard.TabIndex = 5;
            this.checkBox_Keyboard.Text = "Keyboard";
            this.checkBox_Keyboard.UseVisualStyleBackColor = true;
            // 
            // checkBox_Mouse
            // 
            this.checkBox_Mouse.AutoSize = true;
            this.checkBox_Mouse.Location = new System.Drawing.Point(47, 215);
            this.checkBox_Mouse.Name = "checkBox_Mouse";
            this.checkBox_Mouse.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Mouse.TabIndex = 4;
            this.checkBox_Mouse.Text = "Mouse";
            this.checkBox_Mouse.UseVisualStyleBackColor = true;
            // 
            // pbx_remoteDesk
            // 
            this.pbx_remoteDesk.BackColor = System.Drawing.Color.Gray;
            this.pbx_remoteDesk.Location = new System.Drawing.Point(160, 6);
            this.pbx_remoteDesk.Name = "pbx_remoteDesk";
            this.pbx_remoteDesk.Size = new System.Drawing.Size(509, 336);
            this.pbx_remoteDesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_remoteDesk.TabIndex = 3;
            this.pbx_remoteDesk.TabStop = false;
            this.pbx_remoteDesk.Click += new System.EventHandler(this.pbx_remoteDesk_Click);
            this.pbx_remoteDesk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_remoteDesk_MouseClick);
            this.pbx_remoteDesk.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbx_remoteDesk_MouseDoubleClick);
            this.pbx_remoteDesk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_remoteDesk_MouseMove);
            // 
            // btn_StopRD
            // 
            this.btn_StopRD.Location = new System.Drawing.Point(22, 166);
            this.btn_StopRD.Name = "btn_StopRD";
            this.btn_StopRD.Size = new System.Drawing.Size(106, 29);
            this.btn_StopRD.TabIndex = 2;
            this.btn_StopRD.Text = "stop";
            this.btn_StopRD.UseVisualStyleBackColor = true;
            this.btn_StopRD.Click += new System.EventHandler(this.btn_StopRD_Click);
            // 
            // btn_StartRD
            // 
            this.btn_StartRD.Location = new System.Drawing.Point(22, 130);
            this.btn_StartRD.Name = "btn_StartRD";
            this.btn_StartRD.Size = new System.Drawing.Size(106, 30);
            this.btn_StartRD.TabIndex = 1;
            this.btn_StartRD.Text = "start";
            this.btn_StartRD.UseVisualStyleBackColor = true;
            this.btn_StartRD.Click += new System.EventHandler(this.btn_StartRD_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.btn_ExpandRemoteWebcam);
            this.tabPage1.Controls.Add(this.btn_findWebcam);
            this.tabPage1.Controls.Add(this.cbx_webcam);
            this.tabPage1.Controls.Add(this.btn_StopWebcam);
            this.tabPage1.Controls.Add(this.btn_StartWebcam);
            this.tabPage1.Controls.Add(this.pbx_webcam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 348);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "webcam";
            // 
            // btn_ExpandRemoteWebcam
            // 
            this.btn_ExpandRemoteWebcam.Location = new System.Drawing.Point(615, 6);
            this.btn_ExpandRemoteWebcam.Name = "btn_ExpandRemoteWebcam";
            this.btn_ExpandRemoteWebcam.Size = new System.Drawing.Size(54, 23);
            this.btn_ExpandRemoteWebcam.TabIndex = 7;
            this.btn_ExpandRemoteWebcam.Text = "expand";
            this.btn_ExpandRemoteWebcam.UseVisualStyleBackColor = true;
            this.btn_ExpandRemoteWebcam.Click += new System.EventHandler(this.btn_ExpandRemoteWebcam_Click);
            // 
            // btn_findWebcam
            // 
            this.btn_findWebcam.Location = new System.Drawing.Point(57, 81);
            this.btn_findWebcam.Name = "btn_findWebcam";
            this.btn_findWebcam.Size = new System.Drawing.Size(104, 23);
            this.btn_findWebcam.TabIndex = 4;
            this.btn_findWebcam.Text = "Find Webcam";
            this.btn_findWebcam.UseVisualStyleBackColor = true;
            this.btn_findWebcam.Click += new System.EventHandler(this.btn_findWebcam_Click);
            // 
            // cbx_webcam
            // 
            this.cbx_webcam.FormattingEnabled = true;
            this.cbx_webcam.Location = new System.Drawing.Point(41, 54);
            this.cbx_webcam.Name = "cbx_webcam";
            this.cbx_webcam.Size = new System.Drawing.Size(145, 21);
            this.cbx_webcam.TabIndex = 3;
            // 
            // btn_StopWebcam
            // 
            this.btn_StopWebcam.Location = new System.Drawing.Point(74, 228);
            this.btn_StopWebcam.Name = "btn_StopWebcam";
            this.btn_StopWebcam.Size = new System.Drawing.Size(75, 23);
            this.btn_StopWebcam.TabIndex = 2;
            this.btn_StopWebcam.Text = "stop";
            this.btn_StopWebcam.UseVisualStyleBackColor = true;
            this.btn_StopWebcam.Click += new System.EventHandler(this.btn_StopWebcam_Click);
            // 
            // btn_StartWebcam
            // 
            this.btn_StartWebcam.Location = new System.Drawing.Point(74, 199);
            this.btn_StartWebcam.Name = "btn_StartWebcam";
            this.btn_StartWebcam.Size = new System.Drawing.Size(75, 23);
            this.btn_StartWebcam.TabIndex = 1;
            this.btn_StartWebcam.Text = "start";
            this.btn_StartWebcam.UseVisualStyleBackColor = true;
            this.btn_StartWebcam.Click += new System.EventHandler(this.btn_StartWebcam_Click);
            // 
            // pbx_webcam
            // 
            this.pbx_webcam.BackColor = System.Drawing.Color.Gray;
            this.pbx_webcam.Location = new System.Drawing.Point(253, 6);
            this.pbx_webcam.Name = "pbx_webcam";
            this.pbx_webcam.Size = new System.Drawing.Size(416, 336);
            this.pbx_webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_webcam.TabIndex = 0;
            this.pbx_webcam.TabStop = false;
            // 
            // dataGridView_Clients
            // 
            this.dataGridView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clients.Location = new System.Drawing.Point(141, 79);
            this.dataGridView_Clients.Name = "dataGridView_Clients";
            this.dataGridView_Clients.Size = new System.Drawing.Size(493, 182);
            this.dataGridView_Clients.TabIndex = 6;
            this.dataGridView_Clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Clients_CellClick);
            // 
            // btn_StopServer
            // 
            this.btn_StopServer.Location = new System.Drawing.Point(399, 50);
            this.btn_StopServer.Name = "btn_StopServer";
            this.btn_StopServer.Size = new System.Drawing.Size(75, 23);
            this.btn_StopServer.TabIndex = 1;
            this.btn_StopServer.Text = "stop";
            this.btn_StopServer.UseVisualStyleBackColor = true;
            this.btn_StopServer.Click += new System.EventHandler(this.btn_StopServer_Click);
            // 
            // btn_startServer
            // 
            this.btn_startServer.Location = new System.Drawing.Point(318, 50);
            this.btn_startServer.Name = "btn_startServer";
            this.btn_startServer.Size = new System.Drawing.Size(75, 23);
            this.btn_startServer.TabIndex = 0;
            this.btn_startServer.Text = "start";
            this.btn_startServer.UseVisualStyleBackColor = true;
            this.btn_startServer.Click += new System.EventHandler(this.btn_startServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "HiddenRat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(751, 691);
            this.Controls.Add(this.btn_StopServer);
            this.Controls.Add(this.btn_startServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Clients);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbx_clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HiddenRat";
            this.tabControl1.ResumeLayout(false);
            this.FunMenu_tab.ResumeLayout(false);
            this.FunMenu_tab.PerformLayout();
            this.RemoteDesktop_tab.ResumeLayout(false);
            this.RemoteDesktop_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_remoteDesk)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_webcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_clients;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FunMenu_tab;
        private System.Windows.Forms.TabPage RemoteDesktop_tab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ShowTaskBar;
        private System.Windows.Forms.Button btn_HideTaskBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Hibernate;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button Btn_Shutdown;
        private System.Windows.Forms.Button btn_MouseDisable;
        private System.Windows.Forms.Button btn_MouseEnable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.RadioButton radioButton_text;
        private System.Windows.Forms.RadioButton radioButton_vocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_message;
        private System.Windows.Forms.Button btn_StopRD;
        private System.Windows.Forms.Button btn_StartRD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_StopWebcam;
        private System.Windows.Forms.Button btn_StartWebcam;
        private System.Windows.Forms.PictureBox pbx_webcam;
        private System.Windows.Forms.Button btn_findWebcam;
        private System.Windows.Forms.ComboBox cbx_webcam;
        private System.Windows.Forms.Button btn_ExpandRemoteDesktop;
        private System.Windows.Forms.CheckBox checkBox_Keyboard;
        private System.Windows.Forms.CheckBox checkBox_Mouse;
        private System.Windows.Forms.PictureBox pbx_remoteDesk;
        private System.Windows.Forms.Button btn_ExpandRemoteWebcam;
        private System.Windows.Forms.DataGridView dataGridView_Clients;
        private System.Windows.Forms.Button btn_SendScaryMessage;
        private System.Windows.Forms.TextBox tbx_ScaryMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_closeCD;
        private System.Windows.Forms.Button btn_openCD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_StopServer;
        private System.Windows.Forms.Button btn_startServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}

