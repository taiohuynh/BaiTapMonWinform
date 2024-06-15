using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Phap_B2_N2_Bai3
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_6_Phap_Click(object sender, EventArgs e)
        {
            String thongbao_6_Phap = "Tên đăng nhập là: ";
            thongbao_6_Phap += this.txtDangNhap_6_Phap.Text;
            thongbao_6_Phap += "\n\rMật khẩu là: ";
            thongbao_6_Phap += this.txtMatKhau_6_Phap.Text;
            if (this.chkGhiNho_6_Phap.Checked)
                thongbao_6_Phap += "\n\rBạn có ghi nhớ.\n";
            MessageBox.Show(thongbao_6_Phap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnXoa_6_Phap_Click(object sender, EventArgs e)
        {
            this.txtDangNhap_6_Phap.Clear();
            this.txtMatKhau_6_Phap.Clear();
        }
        private void btnDung_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
                Application.Exit();
        }
    }
}
