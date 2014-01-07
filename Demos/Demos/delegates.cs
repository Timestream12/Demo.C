using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demos;

namespace Demos
{
    public partial class delegates : Form
    {
        public delegates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classDelegate cd = new classDelegate();
            cd.ShowThoseMessages();
        }

        
    }
}
