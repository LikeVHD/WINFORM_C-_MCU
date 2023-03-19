using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide10_baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chklbTrai.CheckedItems;
            foreach (var i in items)
            {
                chklbPhai.Items.Add(i);
            }
            foreach (string s in chklbPhai.Items)
            {
                chklbTrai.Items.Remove(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chklbPhai.Items.AddRange(chklbTrai.Items);
            chklbTrai.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đóng ứng dụng?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
