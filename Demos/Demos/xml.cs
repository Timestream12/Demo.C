using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;           //===================================================

namespace Demos
{
    public partial class xml : Form
    {
        public xml()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);    // or just url
                //MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText); 
                foreach (XmlNode node in xDoc.SelectNodes("People/Person"))
                    MessageBox.Show(node.SelectSingleNode("Name").InnerText);  
            }
        }

        XmlDocument xDoc;
        string path;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                xDoc = new XmlDocument();
                xDoc.Load(path);
                textBox1.Text = xDoc.SelectSingleNode("People/Person/Name").InnerText;
                numericUpDown1.Value = Convert.ToInt32(xDoc.SelectSingleNode("People/Person/Age").InnerText);
                textBox3.Text = xDoc.SelectSingleNode("People/Person/Email").InnerText;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xDoc.SelectSingleNode("People/Person/Name").InnerText = textBox1.Text;
            xDoc.SelectSingleNode("People/Person/Age").InnerText = numericUpDown1.Value.ToString();
            xDoc.SelectSingleNode("People/Person/Email").InnerText = textBox3.Text;
            xDoc.Save(path);
        }
    }
}
