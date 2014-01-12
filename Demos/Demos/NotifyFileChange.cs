using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demos
{
    public partial class NotifyFileChange : Form
    {
        public NotifyFileChange()
        {
            InitializeComponent();
        }

        private void NotifyFileChange_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            fsw.Filter = "*.txt";
            fsw.Changed += fsw_Changed;
            fsw.Renamed += fsw_Renamed;
            fsw.EnableRaisingEvents = true;
        }

        void fsw_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show("A text file has been renamed!");
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("You have saved a text file.");
        }
    }
}
