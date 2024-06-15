using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Bai2_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void txtNhapSo_6_Phap_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen_6_Phap = (Control)sender;
            if (ctrSonguyen_6_Phap.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen_6_Phap.Text[ctrSonguyen_6_Phap.Text.Length - 1])) 
                    this.errorProvider1_6_Phap.SetError(ctrSonguyen_6_Phap, "Vui lòng nhập số nguyên");
                else
                    this.errorProvider1_6_Phap.Clear();
        }

        private void btnCapNhat_6_Phap_Click(object sender, EventArgs e)
        {
            try
            {
                int x_6_Phap = int.Parse(txtNhapSo_6_Phap.Text);
                lstKQ_6_Phap.Items.Add(x_6_Phap);
                txtNhapSo_6_Phap.Text = "";
                txtNhapSo_6_Phap.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("Chỉ nhập số!", "Lỗi");
            }
        }

        private void btnTong_6_Phap_Click(object sender, EventArgs e)
        {
            int tong_6_Phap = 0;
            int n_6_Phap = lstKQ_6_Phap.Items.Count;
            for (int i = 0; i < n_6_Phap; i++)
                tong_6_Phap += int.Parse(lstKQ_6_Phap.Items[i].ToString());
            MessageBox.Show("Tổng các phần tử = " + tong_6_Phap, 
                            "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaphantudaucuoi_6_Phap_Click(object sender, EventArgs e)
        {
            lstKQ_6_Phap.Items.RemoveAt(lstKQ_6_Phap.Items.Count - 1);
            lstKQ_6_Phap.Items.RemoveAt(0);
        }

        private void btnXoaphantudangchon_6_Phap_Click(object sender, EventArgs e)
        {
            lstKQ_6_Phap.Items.RemoveAt(lstKQ_6_Phap.SelectedIndex);
        }

        private void btnTangphantu2_6_Phap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKQ_6_Phap.Items.Count; i++)
            {
                int value_6Phap = int.Parse(lstKQ_6_Phap.Items[i].ToString());
                lstKQ_6_Phap.Items[i] = (value_6Phap + 2).ToString();
            }
        }

        private void btnThaybinhphuong_6_Phap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKQ_6_Phap.Items.Count; i++)
            {
                int value_6Phap = int.Parse(lstKQ_6_Phap.Items[i].ToString());
                lstKQ_6_Phap.Items[i] = (value_6Phap * value_6Phap).ToString();
            }
        }

        private void btnChonsochan_6_Phap_Click(object sender, EventArgs e)
        {
            lstKQ_6_Phap.SelectedIndex = -1;
            int n_6_Phap = lstKQ_6_Phap.Items.Count;
            for (int i = 0; i < n_6_Phap; i++)
            {
                if (int.Parse(lstKQ_6_Phap.Items[i].ToString()) % 2 == 0)
                {
                    lstKQ_6_Phap.SelectedIndex = i;
                }
            }
        }

        private void btnChonsole_6_Phap_Click(object sender, EventArgs e)
        {
            lstKQ_6_Phap.SelectedIndex = -1;
            int n_6_Phap = lstKQ_6_Phap.Items.Count;
            for (int i = n_6_Phap - 1; i >= 0; i--)
            {
                if (int.Parse(lstKQ_6_Phap.Items[i].ToString()) % 2 == 1)
                {
                    lstKQ_6_Phap.SelectedIndex = i;
                }
            }
        }
        private void btnKetthuc_6_Phap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
