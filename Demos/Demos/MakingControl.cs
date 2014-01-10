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
    public partial class MakingControl : Form
    {
        public MakingControl()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void myButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
