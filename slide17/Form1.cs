using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                //MessageBox.Show("Có dòng đang chọn:");
                ListViewItem lv1 = lvSanPham.SelectedItems[0];
                string ma = lv1.SubItems[0].Text;
                string ten = lv1.SubItems[1].Text;
                string gia = lv1.SubItems[2].Text;
                MessageBox.Show(ma + " | " + ten + " | " + gia);
            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            MessageBox.Show(lvSanPham.Columns[e.Column] + "");
        }
    }
}
