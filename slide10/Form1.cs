using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chklbDanhSach.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChkIn_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection = chklbDanhSach.CheckedIndices;
            string strCheck = "";
            foreach (int i in indexCollection)
            {
                strCheck += i + " ";
            }
            MessageBox.Show("Phần tử đang được chọn là: " + strCheck);
        }

        private void btnCheckedItem_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection itm = chklbDanhSach.CheckedItems;
            string strItems = "";
            foreach  (string s in itm)
            {
                strItems += s + " ";
            }
            MessageBox.Show("Các phần tử đang được chọn gồm: " + strItems);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đóng ứng dụng?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
