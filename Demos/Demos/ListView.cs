using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demos
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lvi);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void getNameOfItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                foreach (ListViewItem lvi in listView1.SelectedItems)
                    MessageBox.Show(lvi.SubItems[0].Text);
            }
        }

        private void removeSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                foreach (ListViewItem lvi in listView1.SelectedItems)
                    lvi.Remove();
            }
        }

        private void removeAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
                if (lvi.Checked) lvi.Remove();
        }
    }
}
