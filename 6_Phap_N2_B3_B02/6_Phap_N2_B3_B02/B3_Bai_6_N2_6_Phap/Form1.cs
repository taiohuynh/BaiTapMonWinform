using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_Bai_6_N2_6_Phap
{
    public partial class frmMain_6_Phap : Form
    {
        public frmMain_6_Phap()
        {
            InitializeComponent();
        }

        private void btnAddPhai_6_Phap_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items_6_Phap = clbTrai_6_Phap.CheckedItems;
            foreach (var i in items_6_Phap)
                clbPhai_6_Phap.Items.Add(i);
            foreach (var s in clbPhai_6_Phap.Items)
                clbTrai_6_Phap.Items.Remove(s);
        }
        private void btnAddAllPhai_6_Phap_Click(object sender, EventArgs e)
        {
            clbPhai_6_Phap.Items.AddRange(clbTrai_6_Phap.Items);
            clbTrai_6_Phap.Items.Clear();
        }
        private void btnAddTrai_6_Phap_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items_6_Phap = clbPhai_6_Phap.CheckedItems;
            foreach (var i in items_6_Phap)
                clbTrai_6_Phap.Items.Add(i);
            foreach (var s in clbTrai_6_Phap.Items)
                clbPhai_6_Phap.Items.Remove(s);
        }
        private void btnAddAllTrai_6_Phap_Click(object sender, EventArgs e)
        {
            clbTrai_6_Phap.Items.AddRange(clbPhai_6_Phap.Items);
            clbPhai_6_Phap.Items.Clear();
        }
    }
}
