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
			this.lblClose = new System.Windows.Forms.Label();
			this.lblMinimize = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.pbHeader = new System.Windows.Forms.PictureBox();
			this.lServer = new System.Windows.Forms.Label();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.pSidebar = new System.Windows.Forms.Panel();
			this.lblQuickAccess = new System.Windows.Forms.Label();
			this.lBoard = new System.Windows.Forms.LinkLabel();
			this.lTSSync = new System.Windows.Forms.LinkLabel();
			this.lWhitelist = new System.Windows.Forms.LinkLabel();
			this.lWiki = new System.Windows.Forms.LinkLabel();
			this.lUCP = new System.Windows.Forms.LinkLabel();
			this.lDiscord = new System.Windows.Forms.LinkLabel();
			this.lSupport = new System.Windows.Forms.LinkLabel();
			this.lTSConnect = new System.Windows.Forms.LinkLabel();
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
			this.pTitleBar.Controls.Add(this.lblClose);
			this.pTitleBar.Controls.Add(this.lblMinimize);
			this.pTitleBar.Controls.Add(this.lblName);
			this.pTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pTitleBar.Name = "pTitleBar";
			this.pTitleBar.Size = new System.Drawing.Size(1062, 21);
			this.pTitleBar.TabIndex = 0;
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
			this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
			this.lblClose.MouseEnter += new System.EventHandler(this.itemHoverStart);
			this.lblClose.MouseLeave += new System.EventHandler(this.itemHoverEnd);
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
			this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
			this.lblMinimize.MouseEnter += new System.EventHandler(this.itemHoverStart);
			this.lblMinimize.MouseLeave += new System.EventHandler(this.itemHoverEnd);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(18, 4);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(91, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "MyVMP Launcher";
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
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1062, 493);
			this.Controls.Add(this.pSidebar);
			this.Controls.Add(this.btnStartGame);
			this.Controls.Add(this.lServer);
			this.Controls.Add(this.pTitleBar);
			this.Controls.Add(this.pbHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyVMP-Launcher";
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
	}
}

