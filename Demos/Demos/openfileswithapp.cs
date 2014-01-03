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
    public partial class openfileswithapp : Form
    {
        public openfileswithapp(string s)
        {
            InitializeComponent();
            MessageBox.Show(s);
            //also need to edit Program.cs and enter these codes:
            //static void Main(string[] files)
            //and include argument in new instance
        }
    }
}
