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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "http://www.google.com/intl/en_com/images/srpr/logo1w.png"
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //pictureBox1.ImageLocation = ofd.FileName;     
                //or
                //Image image = Image.FromFile(ofd.FileName);
                //pictureBox1.Image = image;
                //test
            }
        }
    }
}
