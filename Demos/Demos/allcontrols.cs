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
    public partial class allcontrols : Form
    {
        public allcontrols()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessAll(this.Controls);
        }
        void AccessAll(Control.ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                //c.Text = "Adam";
                //if (c is Button) c.Enabled = false;
                //if (c is CheckBox)
                //{
                //    CheckBox ch = c as CheckBox;
                //    ch.Checked = true;
                //}
                if (c is Button)
                {
                    Button b = c as Button;
                    b.Click += b_Click;
                }
                if (c.HasChildren) AccessAll(c.Controls);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked a button.");
        }
    }
}
