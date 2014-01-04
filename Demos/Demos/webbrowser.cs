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
    public partial class webbrowser : Form
    {
        public webbrowser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        WebBrowser wb = new WebBrowser();
        private void button6_Click(object sender, EventArgs e)
        {
            wb.Navigate("http://wwww." + textBox2.Text + ".com");
            wb.DocumentCompleted += wb_DocumentCompleted;
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = "Last Played: " + wb.Document.GetElementById("<id_name>").InnerText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("p_13838465-p").InnerText = textBox3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("search-submit").InvokeMember("Click");
        }
    }
}
