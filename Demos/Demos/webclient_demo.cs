using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WebClient_Demo
{
    public partial class webclient_demo : Form
    {
        public webclient_demo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WebClient wc = new WebClient();
            //textBox1.Text = wc.DownloadString("c:\\Users\\User\\Documents\\words.txt"); //ENTER WEBSITE ADDRESS INSTEAD
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "myFileName";
            sfd.Title = "Save Text File";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WebClient wc2 = new WebClient();
                wc2.DownloadFileAsync(new Uri("c:\\Users\\User\\Documents\\words.txt"), sfd.FileName);
                wc2.DownloadFileCompleted += wc2_DownloadFileCompleted;
                wc2.DownloadProgressChanged += wc2_DownloadProgressChanged;
            }
        }

        void wc2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            label1.Text = "Progress: " + e.ProgressPercentage.ToString();
        }

        void wc2_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File is downloaded.");
        }

    }
}
