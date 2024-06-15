using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5_Bai_3_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }
        private void drawByMouseToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            DrawByMouse_6_Phap drawByMouse_6_Phap = new DrawByMouse_6_Phap();
            drawByMouse_6_Phap.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
