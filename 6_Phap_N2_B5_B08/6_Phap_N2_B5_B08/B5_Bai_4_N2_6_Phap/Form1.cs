using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5_Bai_4_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }
        private void btnOpen_6_Phap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile_6_Phap = new OpenFileDialog();
            openFile_6_Phap.Title = "Mở file LTGD ";
            openFile_6_Phap.Filter = "File anh|*.jpg;|All file|*.*";
            if (openFile_6_Phap.ShowDialog() == DialogResult.OK)
                pcbx_6_Phap.Image = Image.FromFile(openFile_6_Phap.FileName);
        }
    }
}
