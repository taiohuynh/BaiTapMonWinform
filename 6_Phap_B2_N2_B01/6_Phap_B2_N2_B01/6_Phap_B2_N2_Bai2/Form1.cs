using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Phap_B2_N2_Bai2
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnKetQua_6_Phap_Click(object sender, EventArgs e)
        {
            try
            {
                int sol_6_Phap, so2_6_Phap, kq_6_Phap;
                sol_6_Phap = int.Parse(txtSo1_6_Phap.Text);
                so2_6_Phap = int.Parse(txtSo2_6_Phap.Text);
                if (int.Parse(txtSo1_6_Phap.Text) > 10 || int.Parse(txtSo1_6_Phap.Text) < 0
                 || int.Parse(txtSo2_6_Phap.Text) > 10 || int.Parse(txtSo2_6_Phap.Text) < 0)
                    throw new Exception("Điểm phải nằm trong khoảng từ 6 đến 10!!!!");
                kq_6_Phap = sol_6_Phap / so2_6_Phap;
                txtKetQua_6_Phap.Text = kq_6_Phap.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            try
            {                
                int sol_6_Phap = int.Parse(txtSo1_6_Phap.Text);
                int so2_6_Phap = int.Parse(txtSo2_6_Phap.Text);
                int kq_6_Phap = sol_6_Phap / so2_6_Phap;
                txtKetQua_6_Phap.Text = kq_6_Phap.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!!!!");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi chia cho 0!!!!");
            }
        }
    }
}
