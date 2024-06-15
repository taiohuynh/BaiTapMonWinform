using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Phap_B2_N2_Bai5
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }
        private void rbtnCong_6_Phap_CheckedChanged(object sender, EventArgs e)
        {
            int so1_6_Phap = int.Parse(txtSo1_6_Phap.Text);
            int so2_6_Phap = int.Parse(txtSo2_6_Phap.Text);
            txtKetQua_6_Phap.Text = String.Format("{0}", so1_6_Phap + so2_6_Phap);
        }
        private void rbtnTru_6_Phap_CheckedChanged(object sender, EventArgs e)
        {
            int so1_6_Phap = int.Parse(txtSo1_6_Phap.Text);
            int so2_6_Phap = int.Parse(txtSo2_6_Phap.Text);
            txtKetQua_6_Phap.Text = String.Format("{0}", so1_6_Phap - so2_6_Phap);
        }
        private void rbtnNhan_6_Phap_CheckedChanged(object sender, EventArgs e)
        {
            int so1_6_Phap = int.Parse(txtSo1_6_Phap.Text);
            int so2_6_Phap = int.Parse(txtSo2_6_Phap.Text);
            txtKetQua_6_Phap.Text = String.Format("{0}", so1_6_Phap * so2_6_Phap);
        }
        private void rbtnChia_6_Phap_CheckedChanged(object sender, EventArgs e)
        {
            int so1_6_Phap = int.Parse(txtSo1_6_Phap.Text);
            int so2_6_Phap = int.Parse(txtSo2_6_Phap.Text);
            if (so2_6_Phap != 0)
                txtKetQua_6_Phap.Text = String.Format("{0:0.00}", (double)so1_6_Phap / so2_6_Phap);
            else
                txtKetQua_6_Phap.Text = "Số chia phải khác 0!";
        }
        private void btnDong_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                Application.Exit();
        }
    }
}
