using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}
