namespace MyVMP_Launcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.pTitleBar = new System.Windows.Forms.Panel();
			this.lblSettingsPannel = new System.Windows.Forms.Label();
			this.lblSettings = new System.Windows.Forms.Label();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblMinimize = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.pbHeader = new System.Windows.Forms.PictureBox();
			this.lServer = new System.Windows.Forms.Label();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.pSidebar = new System.Windows.Forms.Panel();
			this.lTSConnect = new System.Windows.Forms.LinkLabel();
			this.lSupport = new System.Windows.Forms.LinkLabel();
			this.lDiscord = new System.Windows.Forms.LinkLabel();
			this.lUCP = new System.Windows.Forms.LinkLabel();
			this.lWiki = new System.Windows.Forms.LinkLabel();
			this.lWhitelist = new System.Windows.Forms.LinkLabel();
			this.lTSSync = new System.Windows.Forms.LinkLabel();
			this.lBoard = new System.Windows.Forms.LinkLabel();
			this.lblQuickAccess = new System.Windows.Forms.Label();
			this.lblNewsHead = new System.Windows.Forms.Label();
			this.lblNewsText = new System.Windows.Forms.Label();
			this.pSettingsSpacer = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbGTA = new System.Windows.Forms.TextBox();
			this.lblGTAPath = new System.Windows.Forms.Label();
			this.tbRAGE = new System.Windows.Forms.TextBox();
			this.lblRageMPPath = new System.Windows.Forms.Label();
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.btnPleaseWait = new System.Windows.Forms.Button();
			this.btnSearchGTA = new System.Windows.Forms.Button();
			this.btnSearchRage = new System.Windows.Forms.Button();
			this.pTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
			this.pSidebar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pTitleBar
			// 
			this.pTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.pTitleBar.Controls.Add(this.lblSettingsPannel);
			this.pTitleBar.Controls.Add(this.lblSettings);
			this.pTitleBar.Controls.Add(this.lblClose);
			this.pTitleBar.Controls.Add(this.lblMinimize);
			this.pTitleBar.Controls.Add(this.lblName);
			this.pTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pTitleBar.Name = "pTitleBar";
			this.pTitleBar.Size = new System.Drawing.Size(1062, 21);
			this.pTitleBar.TabIndex = 0;
			this.pTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
			// 
			// lblSettingsPannel
			// 
			this.lblSettingsPannel.AutoSize = true;
			this.lblSettingsPannel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSettingsPannel.ForeColor = System.Drawing.Color.White;
			this.lblSettingsPannel.Location = new System.Drawing.Point(1069, 4);
			this.lblSettingsPannel.Name = "lblSettingsPannel";
			this.lblSettingsPannel.Size = new System.Drawing.Size(75, 13);
			this.lblSettingsPannel.TabIndex = 4;
			this.lblSettingsPannel.Text = "Einstellungen";
			// 
			// lblSettings
			// 
			this.lblSettings.AutoSize = true;
			this.lblSettings.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSettings.ForeColor = System.Drawing.Color.White;
			this.lblSettings.Location = new System.Drawing.Point(1002, 4);
			this.lblSettings.Name = "lblSettings";
			this.lblSettings.Size = new System.Drawing.Size(19, 13);
			this.lblSettings.TabIndex = 3;
			this.lblSettings.Text = "✎";
			this.lblSettings.Click += new System.EventHandler(this.ToggleSettings);
			this.lblSettings.MouseEnter += new System.EventHandler(this.ItemHoverStart);
			this.lblSettings.MouseLeave += new System.EventHandler(this.ItemHoverEnd);
			this.lblSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblSettings_MouseUp);
			// 
			// lblClose
			// 
			this.lblClose.AutoSize = true;
			this.lblClose.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClose.ForeColor = System.Drawing.Color.White;
			this.lblClose.Location = new System.Drawing.Point(1038, 4);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(13, 13);
			this.lblClose.TabIndex = 2;
			this.lblClose.Text = "X";
			this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
			this.lblClose.MouseEnter += new System.EventHandler(this.ItemHoverStart);
			this.lblClose.MouseLeave += new System.EventHandler(this.ItemHoverEnd);
			// 
			// lblMinimize
			// 
			this.lblMinimize.AutoSize = true;
			this.lblMinimize.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMinimize.ForeColor = System.Drawing.Color.White;
			this.lblMinimize.Location = new System.Drawing.Point(1020, 4);
			this.lblMinimize.Name = "lblMinimize";
			this.lblMinimize.Size = new System.Drawing.Size(12, 13);
			this.lblMinimize.TabIndex = 1;
			this.lblMinimize.Text = "_";
			this.lblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
			this.lblMinimize.MouseEnter += new System.EventHandler(this.ItemHoverStart);
			this.lblMinimize.MouseLeave += new System.EventHandler(this.ItemHoverEnd);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(18, 4);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(250, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "MyVMP Launcher (Der inoffizielle GVMP Launcher)";
			// 
			// pbHeader
			// 
			this.pbHeader.Image = ((System.Drawing.Image)(resources.GetObject("pbHeader.Image")));
			this.pbHeader.Location = new System.Drawing.Point(0, 20);
			this.pbHeader.Name = "pbHeader";
			this.pbHeader.Size = new System.Drawing.Size(1062, 135);
			this.pbHeader.TabIndex = 1;
			this.pbHeader.TabStop = false;
			// 
			// lServer
			// 
			this.lServer.AutoSize = true;
			this.lServer.BackColor = System.Drawing.Color.Transparent;
			this.lServer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lServer.ForeColor = System.Drawing.Color.White;
			this.lServer.Location = new System.Drawing.Point(30, 49);
			this.lServer.Name = "lServer";
			this.lServer.Size = new System.Drawing.Size(633, 45);
			this.lServer.TabIndex = 2;
			this.lServer.Text = "GVMP - Der deutsche Roleplay Server";
			// 
			// btnStartGame
			// 
			this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.btnStartGame.FlatAppearance.BorderSize = 0;
			this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartGame.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartGame.ForeColor = System.Drawing.Color.White;
			this.btnStartGame.Location = new System.Drawing.Point(824, 398);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(227, 83);
			this.btnStartGame.TabIndex = 3;
			this.btnStartGame.Text = "Spielen";
			this.btnStartGame.UseVisualStyleBackColor = false;
			this.btnStartGame.Visible = false;
			// 
			// pSidebar
			// 
			this.pSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.pSidebar.Controls.Add(this.lTSConnect);
			this.pSidebar.Controls.Add(this.lSupport);
			this.pSidebar.Controls.Add(this.lDiscord);
			this.pSidebar.Controls.Add(this.lUCP);
			this.pSidebar.Controls.Add(this.lWiki);
			this.pSidebar.Controls.Add(this.lWhitelist);
			this.pSidebar.Controls.Add(this.lTSSync);
			this.pSidebar.Controls.Add(this.lBoard);
			this.pSidebar.Controls.Add(this.lblQuickAccess);
			this.pSidebar.Location = new System.Drawing.Point(0, 154);
			this.pSidebar.Name = "pSidebar";
			this.pSidebar.Size = new System.Drawing.Size(200, 342);
			this.pSidebar.TabIndex = 4;
			// 
			// lTSConnect
			// 
			this.lTSConnect.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lTSConnect.AutoSize = true;
			this.lTSConnect.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lTSConnect.LinkColor = System.Drawing.Color.White;
			this.lTSConnect.Location = new System.Drawing.Point(99, 137);
			this.lTSConnect.Name = "lTSConnect";
			this.lTSConnect.Size = new System.Drawing.Size(66, 16);
			this.lTSConnect.TabIndex = 8;
			this.lTSConnect.TabStop = true;
			this.lTSConnect.Text = "[ Connect ]";
			this.lTSConnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LTSConnect_LinkClicked);
			// 
			// lSupport
			// 
			this.lSupport.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lSupport.AutoSize = true;
			this.lSupport.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lSupport.LinkColor = System.Drawing.Color.White;
			this.lSupport.Location = new System.Drawing.Point(35, 107);
			this.lSupport.Name = "lSupport";
			this.lSupport.Size = new System.Drawing.Size(61, 16);
			this.lSupport.TabIndex = 7;
			this.lSupport.TabStop = true;
			this.lSupport.Text = "╚ Support";
			this.lSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LSupport_LinkClicked);
			// 
			// lDiscord
			// 
			this.lDiscord.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lDiscord.AutoSize = true;
			this.lDiscord.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lDiscord.LinkColor = System.Drawing.Color.White;
			this.lDiscord.Location = new System.Drawing.Point(35, 47);
			this.lDiscord.Name = "lDiscord";
			this.lDiscord.Size = new System.Drawing.Size(60, 16);
			this.lDiscord.TabIndex = 6;
			this.lDiscord.TabStop = true;
			this.lDiscord.Text = "╚ Discord";
			this.lDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LDiscord_LinkClicked);
			// 
			// lUCP
			// 
			this.lUCP.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lUCP.AutoSize = true;
			this.lUCP.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lUCP.LinkColor = System.Drawing.Color.White;
			this.lUCP.Location = new System.Drawing.Point(35, 167);
			this.lUCP.Name = "lUCP";
			this.lUCP.Size = new System.Drawing.Size(40, 16);
			this.lUCP.TabIndex = 5;
			this.lUCP.TabStop = true;
			this.lUCP.Text = "╚ UCP";
			this.lUCP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LUCP_LinkClicked);
			// 
			// lWiki
			// 
			this.lWiki.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lWiki.AutoSize = true;
			this.lWiki.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lWiki.LinkColor = System.Drawing.Color.White;
			this.lWiki.Location = new System.Drawing.Point(35, 227);
			this.lWiki.Name = "lWiki";
			this.lWiki.Size = new System.Drawing.Size(39, 16);
			this.lWiki.TabIndex = 4;
			this.lWiki.TabStop = true;
			this.lWiki.Text = "╚ Wiki";
			this.lWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LWiki_LinkClicked);
			// 
			// lWhitelist
			// 
			this.lWhitelist.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lWhitelist.AutoSize = true;
			this.lWhitelist.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lWhitelist.LinkColor = System.Drawing.Color.White;
			this.lWhitelist.Location = new System.Drawing.Point(35, 197);
			this.lWhitelist.Name = "lWhitelist";
			this.lWhitelist.Size = new System.Drawing.Size(65, 16);
			this.lWhitelist.TabIndex = 3;
			this.lWhitelist.TabStop = true;
			this.lWhitelist.Text = "╚ Whitelist";
			this.lWhitelist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LWhitelist_LinkClicked);
			// 
			// lTSSync
			// 
			this.lTSSync.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lTSSync.AutoSize = true;
			this.lTSSync.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lTSSync.LinkColor = System.Drawing.Color.White;
			this.lTSSync.Location = new System.Drawing.Point(35, 137);
			this.lTSSync.Name = "lTSSync";
			this.lTSSync.Size = new System.Drawing.Size(58, 16);
			this.lTSSync.TabIndex = 2;
			this.lTSSync.TabStop = true;
			this.lTSSync.Text = "╚ TS Sync";
			this.lTSSync.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LTSSync_LinkClicked);
			// 
			// lBoard
			// 
			this.lBoard.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.lBoard.AutoSize = true;
			this.lBoard.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lBoard.LinkColor = System.Drawing.Color.White;
			this.lBoard.Location = new System.Drawing.Point(35, 77);
			this.lBoard.Name = "lBoard";
			this.lBoard.Size = new System.Drawing.Size(53, 16);
			this.lBoard.TabIndex = 1;
			this.lBoard.TabStop = true;
			this.lBoard.Text = "╚ Forum";
			this.lBoard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBoard_LinkClicked);
			// 
			// lblQuickAccess
			// 
			this.lblQuickAccess.AutoSize = true;
			this.lblQuickAccess.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuickAccess.ForeColor = System.Drawing.Color.White;
			this.lblQuickAccess.Location = new System.Drawing.Point(12, 17);
			this.lblQuickAccess.Name = "lblQuickAccess";
			this.lblQuickAccess.Size = new System.Drawing.Size(111, 19);
			this.lblQuickAccess.TabIndex = 0;
			this.lblQuickAccess.Text = "Schnellzugriff";
			// 
			// lblNewsHead
			// 
			this.lblNewsHead.AutoSize = true;
			this.lblNewsHead.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewsHead.ForeColor = System.Drawing.Color.White;
			this.lblNewsHead.Location = new System.Drawing.Point(229, 179);
			this.lblNewsHead.Name = "lblNewsHead";
			this.lblNewsHead.Size = new System.Drawing.Size(687, 33);
			this.lblNewsHead.TabIndex = 5;
			this.lblNewsHead.Text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.";
			// 
			// lblNewsText
			// 
			this.lblNewsText.AutoSize = true;
			this.lblNewsText.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewsText.ForeColor = System.Drawing.Color.White;
			this.lblNewsText.Location = new System.Drawing.Point(232, 216);
			this.lblNewsText.MaximumSize = new System.Drawing.Size(800, 160);
			this.lblNewsText.Name = "lblNewsText";
			this.lblNewsText.Size = new System.Drawing.Size(792, 160);
			this.lblNewsText.TabIndex = 6;
			this.lblNewsText.Text = resources.GetString("lblNewsText.Text");
			// 
			// pSettingsSpacer
			// 
			this.pSettingsSpacer.BackColor = System.Drawing.Color.Black;
			this.pSettingsSpacer.Location = new System.Drawing.Point(1062, 0);
			this.pSettingsSpacer.Name = "pSettingsSpacer";
			this.pSettingsSpacer.Size = new System.Drawing.Size(1, 493);
			this.pSettingsSpacer.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1075, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 19);
			this.label1.TabIndex = 9;
			this.label1.Text = "Name:";
			// 
			// tbName
			// 
			this.tbName.BackColor = System.Drawing.Color.DimGray;
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbName.ForeColor = System.Drawing.Color.White;
			this.tbName.Location = new System.Drawing.Point(1079, 51);
			this.tbName.MaxLength = 32;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(171, 23);
			this.tbName.TabIndex = 10;
			// 
			// tbGTA
			// 
			this.tbGTA.BackColor = System.Drawing.Color.DimGray;
			this.tbGTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbGTA.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGTA.ForeColor = System.Drawing.Color.White;
			this.tbGTA.Location = new System.Drawing.Point(1079, 128);
			this.tbGTA.MaxLength = 32;
			this.tbGTA.Name = "tbGTA";
			this.tbGTA.ReadOnly = true;
			this.tbGTA.Size = new System.Drawing.Size(142, 23);
			this.tbGTA.TabIndex = 12;
			// 
			// lblGTAPath
			// 
			this.lblGTAPath.AutoSize = true;
			this.lblGTAPath.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGTAPath.ForeColor = System.Drawing.Color.White;
			this.lblGTAPath.Location = new System.Drawing.Point(1075, 106);
			this.lblGTAPath.Name = "lblGTAPath";
			this.lblGTAPath.Size = new System.Drawing.Size(90, 19);
			this.lblGTAPath.TabIndex = 11;
			this.lblGTAPath.Text = "GTAV-Pfad:";
			// 
			// tbRAGE
			// 
			this.tbRAGE.BackColor = System.Drawing.Color.DimGray;
			this.tbRAGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbRAGE.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRAGE.ForeColor = System.Drawing.Color.White;
			this.tbRAGE.Location = new System.Drawing.Point(1079, 182);
			this.tbRAGE.MaxLength = 32;
			this.tbRAGE.Name = "tbRAGE";
			this.tbRAGE.ReadOnly = true;
			this.tbRAGE.Size = new System.Drawing.Size(142, 23);
			this.tbRAGE.TabIndex = 14;
			// 
			// lblRageMPPath
			// 
			this.lblRageMPPath.AutoSize = true;
			this.lblRageMPPath.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRageMPPath.ForeColor = System.Drawing.Color.White;
			this.lblRageMPPath.Location = new System.Drawing.Point(1075, 160);
			this.lblRageMPPath.Name = "lblRageMPPath";
			this.lblRageMPPath.Size = new System.Drawing.Size(116, 19);
			this.lblRageMPPath.TabIndex = 13;
			this.lblRageMPPath.Text = "RAGEMP-Pfad:";
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.btnSaveSettings.FlatAppearance.BorderSize = 0;
			this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSettings.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
			this.btnSaveSettings.Location = new System.Drawing.Point(1165, 80);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(85, 23);
			this.btnSaveSettings.TabIndex = 15;
			this.btnSaveSettings.Text = "Speichern";
			this.btnSaveSettings.UseVisualStyleBackColor = false;
			this.btnSaveSettings.Click += new System.EventHandler(this.SaveSettings);
			// 
			// btnPleaseWait
			// 
			this.btnPleaseWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.btnPleaseWait.Enabled = false;
			this.btnPleaseWait.FlatAppearance.BorderSize = 0;
			this.btnPleaseWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPleaseWait.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPleaseWait.ForeColor = System.Drawing.Color.White;
			this.btnPleaseWait.Location = new System.Drawing.Point(823, 398);
			this.btnPleaseWait.Name = "btnPleaseWait";
			this.btnPleaseWait.Size = new System.Drawing.Size(227, 83);
			this.btnPleaseWait.TabIndex = 16;
			this.btnPleaseWait.Text = "Bitte warten...";
			this.btnPleaseWait.UseVisualStyleBackColor = false;
			// 
			// btnSearchGTA
			// 
			this.btnSearchGTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.btnSearchGTA.FlatAppearance.BorderSize = 0;
			this.btnSearchGTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchGTA.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchGTA.ForeColor = System.Drawing.Color.White;
			this.btnSearchGTA.Location = new System.Drawing.Point(1227, 128);
			this.btnSearchGTA.Name = "btnSearchGTA";
			this.btnSearchGTA.Size = new System.Drawing.Size(23, 23);
			this.btnSearchGTA.TabIndex = 17;
			this.btnSearchGTA.Text = "▶";
			this.btnSearchGTA.UseVisualStyleBackColor = false;
			this.btnSearchGTA.Click += new System.EventHandler(this.SearchGTAV);
			// 
			// btnSearchRage
			// 
			this.btnSearchRage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.btnSearchRage.FlatAppearance.BorderSize = 0;
			this.btnSearchRage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchRage.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchRage.ForeColor = System.Drawing.Color.White;
			this.btnSearchRage.Location = new System.Drawing.Point(1227, 182);
			this.btnSearchRage.Name = "btnSearchRage";
			this.btnSearchRage.Size = new System.Drawing.Size(23, 23);
			this.btnSearchRage.TabIndex = 18;
			this.btnSearchRage.Text = "▶";
			this.btnSearchRage.UseVisualStyleBackColor = false;
			this.btnSearchRage.Click += new System.EventHandler(this.SearchRAGE);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1062, 493);
			this.Controls.Add(this.btnSearchRage);
			this.Controls.Add(this.btnSearchGTA);
			this.Controls.Add(this.btnPleaseWait);
			this.Controls.Add(this.btnSaveSettings);
			this.Controls.Add(this.tbRAGE);
			this.Controls.Add(this.lblRageMPPath);
			this.Controls.Add(this.tbGTA);
			this.Controls.Add(this.lblGTAPath);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pSettingsSpacer);
			this.Controls.Add(this.lblNewsText);
			this.Controls.Add(this.lblNewsHead);
			this.Controls.Add(this.pSidebar);
			this.Controls.Add(this.btnStartGame);
			this.Controls.Add(this.lServer);
			this.Controls.Add(this.pTitleBar);
			this.Controls.Add(this.pbHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyVMP-Launcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckThrads);
			this.pTitleBar.ResumeLayout(false);
			this.pTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
			this.pSidebar.ResumeLayout(false);
			this.pSidebar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox pbHeader;
		private System.Windows.Forms.Label lServer;
		private System.Windows.Forms.Button btnStartGame;
		private System.Windows.Forms.Panel pSidebar;
		private System.Windows.Forms.LinkLabel lTSConnect;
		private System.Windows.Forms.LinkLabel lSupport;
		private System.Windows.Forms.LinkLabel lDiscord;
		private System.Windows.Forms.LinkLabel lUCP;
		private System.Windows.Forms.LinkLabel lWiki;
		private System.Windows.Forms.LinkLabel lWhitelist;
		private System.Windows.Forms.LinkLabel lTSSync;
		private System.Windows.Forms.LinkLabel lBoard;
		private System.Windows.Forms.Label lblQuickAccess;
		private System.Windows.Forms.Label lblSettings;
		private System.Windows.Forms.Label lblNewsHead;
		private System.Windows.Forms.Label lblNewsText;
		private System.Windows.Forms.Panel pSettingsSpacer;
		private System.Windows.Forms.Label lblSettingsPannel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbGTA;
		private System.Windows.Forms.Label lblGTAPath;
		private System.Windows.Forms.TextBox tbRAGE;
		private System.Windows.Forms.Label lblRageMPPath;
		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.Button btnPleaseWait;
		private System.Windows.Forms.Button btnSearchGTA;
		private System.Windows.Forms.Button btnSearchRage;
	}
}

