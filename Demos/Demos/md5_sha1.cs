using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //////////////////////////////

namespace Demos
{
    public partial class md5_sha1 : Form
    {
        public md5_sha1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            SHA1CryptoServiceProvider sh1 = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            string s = BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(textBox1.Text)));
            string s2 = BitConverter.ToString(sh1.ComputeHash(utf8.GetBytes(textBox1.Text)));
            MessageBox.Show(s + Environment.NewLine + s2);
        }
    }
}
