using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Bai4_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }
        private void btnThem_6_Phap_Click(object sender, EventArgs e)
        {
            try
            {
                int a_6_Phap = int.Parse(txtDienthoai_6_Phap.Text);
                ListViewItem lv_6_Phap = lstvwNhanvien_6_Phap.Items.Add(txtHoten_6_Phap.Text);
                lv_6_Phap.SubItems.Add(dtpNgaysinh_6_Phap.Value.ToShortDateString());
                lv_6_Phap.SubItems.Add(txtDienthoai_6_Phap.Text);
                lv_6_Phap.SubItems.Add(txtDiachi_6_Phap.Text);
            } catch (Exception)
            {
                MessageBox.Show("Chỉ nhập số!", "Lỗi");
            }
        }

        private void btnXoa_6_Phap_Click(object sender, EventArgs e)
        {
            if(lstvwNhanvien_6_Phap.SelectedItems.Count > 0)
            {
                lstvwNhanvien_6_Phap.Items.Remove(lstvwNhanvien_6_Phap.SelectedItems[0]);
            }
        }

        private void btnSua_6_Phap_Click(object sender, EventArgs e)
        {
            if (lstvwNhanvien_6_Phap.SelectedItems.Count > 0)
            {
                lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[0].Text = txtHoten_6_Phap.Text;
                lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[1].Text = dtpNgaysinh_6_Phap.Value.ToShortDateString();
                lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[2].Text = txtDienthoai_6_Phap.Text;
                lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[3].Text = txtDiachi_6_Phap.Text;
            }
        }

        private void btnThoat_6_Phap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstvwNhanvien_6_Phap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvwNhanvien_6_Phap.SelectedItems.Count > 0)
            {
                txtHoten_6_Phap.Text = lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[0].Text;
                dtpNgaysinh_6_Phap.Text = lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[1].Text; 
                txtDienthoai_6_Phap.Text = lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[2].Text;
                txtDiachi_6_Phap.Text = lstvwNhanvien_6_Phap.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
