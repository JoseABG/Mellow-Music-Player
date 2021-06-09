using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mellow_Music_Player
{
    public partial class SongInfoSearch : Form
    {

        Point mouseLocation;

        public SongInfoSearch()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoToolbarPanel_MouseMove(object sender, MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;
            }

        }

        private void infoToolbarPanel_MouseDown(object sender, MouseEventArgs e)
        {

            mouseLocation = new Point(e.X, e.Y);

        }
    }
}
