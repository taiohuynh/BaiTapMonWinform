using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace B5_Bai_3_N2_6_Phap
{
    public partial class DrawByMouse_6_Phap : Form
    {
        public DrawByMouse_6_Phap()
        {
            InitializeComponent();
        }
        int penW_6_Phap;
        Color color_6_Phap;
        Point oldPoint_6_Phap;
        Bitmap bmpmem_6_Phap;

        private void DrawByMouse_6_Phap_Load(object sender, EventArgs e)
        {
            penW_6_Phap = 1;
            color_6_Phap = Color.Red;
            bmpmem_6_Phap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height, CreateGraphics());
        }

        private void DrawByMouse_6_Phap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmpmem_6_Phap, 10, 10);
        }

        private void DrawByMouse_6_Phap_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint_6_Phap = e.Location;
        }

        private void DrawByMouse_6_Phap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g_6_Phap = Graphics.FromImage(bmpmem_6_Phap);
                Pen pen_6_Phap = new Pen(color_6_Phap, penW_6_Phap);
                pen_6_Phap.DashCap = DashCap.Round;
                pen_6_Phap.EndCap = LineCap.Round;
                pen_6_Phap.StartCap = LineCap.Round;
                g_6_Phap.DrawLine(pen_6_Phap, oldPoint_6_Phap, e.Location);
                oldPoint_6_Phap = e.Location;
                Invalidate();
            }
        }

        private void DrawByMouse_6_Phap_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    color_6_Phap = Color.Red;
                    break;
                case Keys.G:
                    color_6_Phap = Color.Green;
                    break;
                case Keys.B:
                    color_6_Phap = Color.Blue;
                    break;
                case Keys.Up:
                    penW_6_Phap++;
                    break;
                case Keys.Down:
                    penW_6_Phap--;
                    break;
            }
        }
    }
}
