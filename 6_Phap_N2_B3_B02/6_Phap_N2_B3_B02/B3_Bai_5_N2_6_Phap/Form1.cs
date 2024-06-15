using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Bai_5_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnCalc_6_Phap_Click(object sender, EventArgs e)
        {
            this.GetPay_6_Phap();
        }
        private void GetPay_6_Phap()
        {
            if(txtName_6_Phap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName_6_Phap.Focus();
            }
            else
            {
                int total_6_Phap = 0;
                if (chkClean_6_Phap.Checked)
                    total_6_Phap += 100000;
                if (chkWhitening_6_Phap.Checked)
                    total_6_Phap += 1200000;
                if (chkXRay_6_Phap.Checked)
                    total_6_Phap += 200000;

                total_6_Phap += (int)numFilling_6_Phap.Value * 80000;
                txtTotal_6_Phap.Text = String.Format("${0}", total_6_Phap);
            }    
        }

        private void btnExit_6_Phap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }
    }
}
