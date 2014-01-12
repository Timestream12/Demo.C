using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Ionic.Zip;

// You need to download DotNetZip, go to "Tools" folder, extract "Ionic.Zip.dll", add it as a reference
namespace Demos
{
    public partial class Zipping : Form
    {
        public Zipping()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    ZipFile zf = new ZipFile("C:\\Users\\Adam\\Desktop\\MyZipFile.zip");
            //    zf.AddDirectoryByName("Adam");
            //    zf.AddFile(ofd.FileName, "Adam");
            //    zf.Save();
            //}


            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            //    ZipFile zf = new ZipFile("C:\\Users\\Adam\\Desktop\\MyZipFile.zip");
            //    zf.AddDirectory(fbd.SelectedPath, "");
            //    zf.Save();
            //}
        }

    }
}
