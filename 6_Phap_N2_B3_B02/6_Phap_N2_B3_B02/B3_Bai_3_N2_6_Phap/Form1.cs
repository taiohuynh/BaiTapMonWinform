using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Bai_3_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        const int sodong_6_Phap = 4;
        const int socot_6_Phap = 3;
        int[,] Array_6_Phap = new int[sodong_6_Phap, socot_6_Phap];
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnNhap_6_Phap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sodong_6_Phap; i++)
            {
                for (int j = 0; j < socot_6_Phap; j++)
                    Array_6_Phap[i, j] = i - j;
            }
        }
        private void btnSapXep_6_Phap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sodong_6_Phap; i++)
            {
                for (int j = 0; j < socot_6_Phap - 1; j++)
                {
                    for (int k = 0; k < socot_6_Phap - j - 1; k++)
                    {
                        if (Array_6_Phap[i, k] > Array_6_Phap[i, k + 1])
                        {
                            int temp_6_Phap = Array_6_Phap[i, k];
                            Array_6_Phap[i, k] = Array_6_Phap[i, k + 1];
                            Array_6_Phap[i, k + 1] = temp_6_Phap;
                        }
                    }
                }
            }
            this.lblKQ_6_Phap.Text = "Đã sắp xếp mảng tăng dần!";
        }

        private void btnIn_6_Phap_Click(object sender, EventArgs e)
        {
            this.lblKQ_6_Phap.Text = "Các phần tử trong mảng là: \n\r";
            for (int i = 0; i < sodong_6_Phap; i++)
            {
                for (int j = 0; j < socot_6_Phap; j++)
                    this.lblKQ_6_Phap.Text += Array_6_Phap[i, j] + "  ";
                this.lblKQ_6_Phap.Text += "\n\r";
            }
        }

        private void btnXoa_6_Phap_Click(object sender, EventArgs e)
        {
            this.lblKQ_6_Phap.Text = "";
        }

        private void btnDung_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }
    }
}
