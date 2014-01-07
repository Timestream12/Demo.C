using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class threading_demo : Form
    {
        public threading_demo()
        {
            InitializeComponent();
        }
        Thread t;
        string myString = "";
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(Write);
            object[] objA = { "Steve", 500 };
            t.Start(objA);
            t.Join(); //while (t.IsAlive) ; // NOT A GOOD CODING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //t.Abort();
            textBox1.Text = myString;
        }
        void Write(object array)
        {
            object[] o = array as object[];
            for (int i = 0; i < Convert.ToInt32(o[1]); i++)
            {
                Thread.Sleep(10);
                myString += o[0].ToString() + i.ToString() + "\r\n" ; //Environment.NewLine
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

    }
}
