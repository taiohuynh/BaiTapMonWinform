using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B5_Bai_2_N2_6_Phap
{
    public partial class Open_6_Phap : Form
    {
        public Open_6_Phap()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            btnMau_6_Phap.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            btnMau_6_Phap.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            btnMau_6_Phap.BackColor = Color.Blue;
        }
    }
}
