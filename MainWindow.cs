using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MyVMP_Launcher
{
	public partial class MainWindow : Form
    {
        public MainWindow()
        {
			InitializeComponent();
			var pos = PointToScreen(lServer.Location);
			pos = pbHeader.PointToClient(pos);
			lServer.Parent = pbHeader;
			lServer.Location = pos;
			lServer.BackColor = Color.Transparent;
		}

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void itemHoverStart(object sender, EventArgs e)
		{
			((Label)sender).BackColor = Color.FromArgb(51, 51, 51);
		}

		private void itemHoverEnd(object sender, EventArgs e)
		{
			((Label)sender).BackColor = Color.FromArgb(31, 31, 31);
		}

		private void lDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Discord);
		}

		private void lBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Board);
		}

		private void lSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Support);
		}

		private void lTSSync_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.TSIdent);
		}

		private void lTSConnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string tsLink = string.Format("{0}?nickname={1}", Data.Links.TSAddress, Data.GVMP.UserName);
			Process.Start(tsLink);
		}

		private void lUCP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.UCP);
		}

		private void lWhitelist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.WhiteList);
		}

		private void lWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Data.Links.Wiki);
		}
	}
}
