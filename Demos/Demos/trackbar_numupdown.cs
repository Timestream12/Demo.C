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
    public partial class trackbar_numupdown : Form
    {
        public trackbar_numupdown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(trackBar1.Value.ToString());
            MessageBox.Show(numericUpDown1.Value.ToString());
        }
    }
}
