using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Bai1_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnLuu_6_Phap_Click(object sender, EventArgs e)
        {
            SinhVien_6_Phap sinhvien_6_Phap = new SinhVien_6_Phap();
            sinhvien_6_Phap.Ma_6Phap = int.Parse(txtMa_6_Phap.Text);
            sinhvien_6_Phap.Ten_6Phap = txtTen_6_Phap.Text;
            lstBx1_6_Phap.Items.Add($"{sinhvien_6_Phap.Ma_6Phap}\t{sinhvien_6_Phap.Ten_6Phap}");
            
        }

        private void btnXoa_6_Phap_Click(object sender, EventArgs e)
        {
            txtMa_6_Phap.Text = "";
            txtTen_6_Phap.Text = "";
            lstBx1_6_Phap.Items.Clear();
        }
    }
}
