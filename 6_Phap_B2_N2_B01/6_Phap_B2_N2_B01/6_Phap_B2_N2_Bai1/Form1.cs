using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Phap_B2_N2_Bai1
{
    struct Time_6_Phap
    {
        int hour_6_Phap, minute_6_Phap, second_6_Phap;
        public Time_6_Phap(int h, int m, int s)
        {
            hour_6_Phap = h;
            minute_6_Phap = m;
            second_6_Phap = s;
        }
        public int Hour_6_Phap
        {
            get { return hour_6_Phap; }
            set { hour_6_Phap = value; }
        }
        public int Minute_6_Phap
        {
            get { return minute_6_Phap; }
            set { minute_6_Phap = value; }
        }
        public int Second_6_Phap
        {
            get { return second_6_Phap; }
            set { second_6_Phap = value; }
        }
        public void Normalize_6Phap()
        {
            int t = second_6_Phap / 60;
            second_6_Phap = second_6_Phap >= 60 ? second_6_Phap % 60 : second_6_Phap;
            t = (minute_6_Phap + t) / 60;
            minute_6_Phap = (minute_6_Phap + t) >= 60 ? (minute_6_Phap + t) % 60 : (minute_6_Phap + t);
            hour_6_Phap = hour_6_Phap + t;
            hour_6_Phap = hour_6_Phap >= 24 ? hour_6_Phap % 24 : hour_6_Phap;
        }
        public string Showtime_6Phap()
        {

            return String.Format("{0:00}:{1:00}:{2:00}", hour_6_Phap, minute_6_Phap, second_6_Phap);
        }
    }
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }
        private void btnShowTime_6_Phap_Click(object sender, EventArgs e)
        {
            Time_6_Phap t = new Time_6_Phap(int.Parse(txtHour_6_Phap.Text), int.Parse(txtMinute_6_Phap.Text), int.Parse(txtSecond_6_Phap.Text));
            t.Normalize_6Phap();
            lbTime_6_Phap.Text = t.Showtime_6Phap();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_6Phap_Load(object sender, EventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }
    }
}
