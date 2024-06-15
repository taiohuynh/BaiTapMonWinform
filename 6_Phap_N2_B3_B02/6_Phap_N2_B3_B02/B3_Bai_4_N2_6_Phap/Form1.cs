using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Bai_4_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        int diem_6_Phap = 0;
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnQuaySo_6_Phap_Click(object sender, EventArgs e)
        {
            int tong_6_Phap = 0;
            Random random_6_Phap = new Random();

            int so1_6_Phap = random_6_Phap.Next(0, 7);
            int so2_6_Phap = random_6_Phap.Next(0, 7);
            int so3_6_Phap = random_6_Phap.Next(0, 7);
            lb1_6_Phap.Text = so1_6_Phap.ToString();
            lb2_6_Phap.Text = so2_6_Phap.ToString();
            lb3_6_Phap.Text = so3_6_Phap.ToString();

            tong_6_Phap = so1_6_Phap + so2_6_Phap + so3_6_Phap;

            if (rdbtn1_6_Phap.Checked)
            {
                if (tong_6_Phap >= 3 && tong_6_Phap <= 10)
                    diem_6_Phap += 10;
                else
                    diem_6_Phap -= 10;
            }
            else if (rdbtn2_6_Phap.Checked)
            {    
                if (tong_6_Phap >= 11 && tong_6_Phap <= 18)
                    diem_6_Phap += 10;
                else
                    diem_6_Phap -= 10;
            }
                lbKQ_6_Phap.Text = diem_6_Phap.ToString();
        }
    }
}
