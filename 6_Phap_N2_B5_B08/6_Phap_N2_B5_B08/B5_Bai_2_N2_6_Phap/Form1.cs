using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5_Bai_2_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_6_Phap_Click(object sender, EventArgs e)
        {
            Open_6_Phap o_6_Phap = new Open_6_Phap();
            o_6_Phap.Show();
        }
    }
}
