using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Mellow_Music_Player
{
    class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, 90F);
            Graphics g = e.Graphics;

            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
