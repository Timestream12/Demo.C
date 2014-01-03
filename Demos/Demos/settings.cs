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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            textBox1.Text = Demos.Properties.Settings.Default.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Demos.Properties.Settings.Default.Name = textBox1.Text;
            Demos.Properties.Settings.Default.Save();
        }
    }
}
