using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MyVMP_Launcher
{
	public partial class MainWindow : Form
    {
		static bool isToggleActive = false;
		static bool isOpening = false;

		Thread tToggle;
		Thread tGetData;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		static extern bool ReleaseCapture();

		void GatherData()
		{
			Data.GTA5.Init();
			Data.RAGE.Init();
			Data.GVMP.GetPlayerName();
			Invoke((MethodInvoker)delegate
			{
				tbRAGE.Text = Data.RAGE.Base;
				tbGTA.Text = Data.GTA5.Base;
				tbName.Text = Data.GVMP.UserName;
			});
			Data.GVMP.Init();
			Invoke((MethodInvoker)delegate
			{
				btnStartGame.Visible = true;
				btnPleaseWait.Visible = false;
			});
		}

		void ToggleWidth()
		{
			if (isToggleActive)
				isOpening = !isOpening;
			while(isToggleActive)
			{
				if(isOpening)
				{
					Invoke((MethodInvoker)delegate
					{
						Width = Width + 2;
					});
					if (Width >= 1262)
						isToggleActive = false;
				}
				else
				{
					Invoke((MethodInvoker)delegate
					{
						Width = Width - 2;
					});
					if (Width <= 1062)
						isToggleActive = false;
				}
			}
		}
        public MainWindow()
        {
			InitializeComponent();
			var pos = PointToScreen(lServer.Location);
			pos = pbHeader.PointToClient(pos);
			lServer.Parent = pbHeader;
			lServer.Location = pos;
			lServer.BackColor = Color.Transparent;

			tGetData = new Thread(new ThreadStart(GatherData));
			tGetData.Start();
		}

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void ItemHoverStart(object sender, EventArgs e)
		{
			((Label)sender).BackColor = Color.FromArgb(51, 51, 51);
		}

		private void ItemHoverEnd(object sender, EventArgs e)
		{
			((Label)sender).BackColor = Color.FromArgb(31, 31, 31);
		}

		private void LDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Discord);
		}

		private void LBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Board);
		}

		private void LSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Support);
		}

		private void LTSSync_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.TSIdent);
		}

		private void LTSConnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(string.Format("{0}?nickname={1}", Data.Links.TSAddress, Data.GVMP.UserName));
		}

		private void LUCP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.UCP);
		}

		private void LWhitelist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.WhiteList);
		}

		private void LWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Wiki);
		}

		private void LblSettings_MouseUp(object sender, MouseEventArgs e)
		{
			ItemHoverEnd(sender, null);
		}

		private void ToggleSettings(object sender, EventArgs e)
		{
			isToggleActive = true;
			tToggle = new Thread(new ThreadStart(ToggleWidth));
			tToggle.Start();
		}

		private void SaveSettings(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbName.Text))
			{
				MessageBox.Show("Es wurde kein gültiger Spielername angegeben!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbName.Focus();
			}
			else
			{
				Data.GVMP.SetPlayerName(tbName.Text);
				MessageBox.Show("Der Spielername wurde erfolgreich gespeichert", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				isToggleActive = true;
				tToggle = new Thread(new ThreadStart(ToggleWidth));
				tToggle.Start();
			}
		}

		private void SearchGTAV(object sender, EventArgs e)
		{
			FolderBrowserDialog fbdGTA = new FolderBrowserDialog
			{
				SelectedPath = Data.GTA5.Base,
				Description = "Bitte gib den Pfad deiner GTA5 Installation an"
			};
			if (fbdGTA.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists(string.Format("{0}\\GTA5.exe", fbdGTA.SelectedPath)))
					MessageBox.Show("Es konnte keine GTA Installation im angegebenen Ordner gefunden werden!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					Data.GTA5.SetNewBasePath(string.Format(@"{0}\", fbdGTA.SelectedPath));
					tbRAGE.Text = string.Format(@"{0}\", fbdGTA.SelectedPath);
				}
			}
		}

		private void SearchRAGE(object sender, EventArgs e)
		{
			FolderBrowserDialog fbdRAGE = new FolderBrowserDialog
			{
				SelectedPath = Data.RAGE.Base,
				Description = "Bitte gib den Pfad deiner RAGE Installation an"
			};
			if (fbdRAGE.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists(string.Format("{0}\\ragemp_v.exe", fbdRAGE.SelectedPath)))
					MessageBox.Show("Es konnte keine RAGE Installation im angegebenen Ordner gefunden werden!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					Data.RAGE.SetNewBasePath(fbdRAGE.SelectedPath);
					tbRAGE.Text = string.Format(@"{0}\", fbdRAGE.SelectedPath);
				}
			}
		}

		private void CheckThrads(object sender, FormClosingEventArgs e)
		{
			if(tToggle != null)
				if (tToggle.IsAlive)
					tToggle.Abort();
			if (tGetData.IsAlive)
				tGetData.Abort();

		}

		private void MoveWindow(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
