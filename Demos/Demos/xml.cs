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

        string savepath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 16) + "\\xDoc1.xml";
        private void button4_Click(object sender, EventArgs e)
        {            
            XmlTextWriter xWriter = new XmlTextWriter(savepath, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartElement("People");
            xWriter.WriteStartElement("Person");
            xWriter.WriteStartElement("Name");
            xWriter.WriteString(textBox1.Text);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Age");
            xWriter.WriteString(numericUpDown1.Value.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Email");
            xWriter.WriteString(textBox3.Text);
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.Close();
        }

        private void button5_Click(object sender, EventArgs e)  //
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(savepath);
            XmlNode person = doc.CreateElement("Person");
            XmlNode name = doc.CreateElement("Name");
            name.InnerText = textBox1.Text;
            person.AppendChild(name);
            XmlNode age = doc.CreateElement("Age");
            age.InnerText = numericUpDown1.Value.ToString();
            person.AppendChild(age);
            XmlNode email = doc.CreateElement("Email");
            email.InnerText = textBox3.Text;
            person.AppendChild(email);
            doc.DocumentElement.AppendChild(person);
            doc.Save(savepath);            
        }

        private void button6_Click(object sender, EventArgs e)  //
        {
            XmlDocument xDoc2 = new XmlDocument();
            xDoc2.Load(savepath);
            foreach (XmlNode xNode in xDoc2.SelectNodes("People/Person"))
                if (xNode.SelectSingleNode("Name").InnerText == textBox2.Text) xNode.ParentNode.RemoveChild(xNode);
            xDoc2.Save(savepath);
        }
    }
}
