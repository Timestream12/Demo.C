using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Demos
{
    public partial class IEnumerableDemo : Form
    {
        public IEnumerableDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int i in GetNumbers(0, 10))
            {
                if (i == 2) break;
                MessageBox.Show(i.ToString());
            }
        }

        IEnumerable GetNumbers(int min, int max)
        {
            for (; min <= max; min++)
                yield return min;
        }
    }
}
