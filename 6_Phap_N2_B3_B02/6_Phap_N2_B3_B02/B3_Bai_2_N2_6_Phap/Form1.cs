using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Bai_2_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        int[] a_6_Phap = new int[5];
        int sopt_6_Phap = 0;
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnNhap_6_Phap_Click(object sender, EventArgs e)
        {
            if (sopt_6_Phap == 5)
                MessageBox.Show("Mảng đã đầy!");
            else
            {
                a_6_Phap[sopt_6_Phap] = Convert.ToInt32(this.txtNhap_6_Phap.Text);
                sopt_6_Phap++;
                this.txtNhap_6_Phap.ResetText();
                this.txtNhap_6_Phap.Focus();
            }    
        }

        private void btnTang_6_Phap_Click(object sender, EventArgs e)
        {
            if (sopt_6_Phap == 0)
                this.lblKQ_6_Phap.Text = "Mảng rỗng!";
            else
                Array.Sort(a_6_Phap, 0, sopt_6_Phap);
            this.lblKQ_6_Phap.Text = "Đã sắp xếp mảng tăng dần!";
        }

        private void btnGiam_6_Phap_Click(object sender, EventArgs e)
        {
            if (sopt_6_Phap == 0)
                this.lblKQ_6_Phap.Text = "Mảng rỗng!";
            else
                Array.Reverse(a_6_Phap, 0, sopt_6_Phap);
            this.lblKQ_6_Phap.Text = "Đã sắp xếp mảng giảm dần!";
        }

        private void btnIn_6_Phap_Click(object sender, EventArgs e)
        {
            this.lblKQ_6_Phap.Text = "Các phần tử trong mảng là: \n\r";
            for (int i = 0; i < a_6_Phap.Length; i++)
                this.lblKQ_6_Phap.Text += a_6_Phap[i] + "  ";
        }

        private void btnXoa_6_Phap_Click(object sender, EventArgs e)
        {
            this.lblKQ_6_Phap.Text = "";
            this.txtNhap_6_Phap.Text = "";
        }

        private void btnDung_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }
    }
}
