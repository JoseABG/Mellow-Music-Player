using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mellow_Music_Player
{
    public partial class LyricWindow : Form
    {

        private Point mouseLocation;

        public LyricWindow()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lyricToolbarPanel_MouseDown(object sender, MouseEventArgs e)
        {

            mouseLocation = new Point(e.X, e.Y);

        }

        private void lyricToolbarPanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;
            }

        }
    }
}
