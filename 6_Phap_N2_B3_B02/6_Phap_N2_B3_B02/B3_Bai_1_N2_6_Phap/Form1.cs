using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Bai_1_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        int[] a_6_Phap = { 1, 2, 3, 4, 5 };
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnIn_6_Phap_Click(object sender, EventArgs e)
        {
            this.lblKQ_6_Phap.Text = "Các phần tử trong mảng là: \n\r";
            for (int i = 0; i < a_6_Phap.Length; i++)
                this.lblKQ_6_Phap.Text += a_6_Phap[i] + "  ";
        }

        private void btnXoa_6_Phap_Click(object sender, EventArgs e)
        {
            this.lblKQ_6_Phap.Text="";
        }

        private void btnDung_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }
    }
}
