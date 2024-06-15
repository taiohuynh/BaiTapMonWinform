using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _6_Phap_B2_N2_Bai4
{
    public partial class frmDangNhap_6_Phap : Form
    {
        public frmDangNhap_6_Phap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_6_Phap_Click(object sender, EventArgs e)
        {
            if ((txtDangNhap_6_Phap.Text == "lhphap") & (txtMatKhau_6_Phap.Text == "6"))
            {
                this.Hide();
                frmMain_6_Phap frmMain_6_Phap = new frmMain_6_Phap();
                frmMain_6_Phap.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu!!!", "Thông báo");
            }    
        }
        private void btnThoat_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                Application.Exit();
        }
    }
}
