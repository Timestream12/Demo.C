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
using System.Xml;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory; //Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Address Book - Adam"))
                Directory.CreateDirectory(path + "\\Address Book - Adam");
            if (!File.Exists(path + "\\Address Book - Adam\\settings.xml"))
            {
                //File.Create((path + "\\Address Book - Adam\\settings.xml"));
                XmlTextWriter xW = new XmlTextWriter(path + "\\Address Book - Adam\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("People");
                xW.WriteEndElement();
                xW.Close();
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book - Adam\\settings.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("People/Person"))
            {
                Person p = new Person();
                p.Name = xNode.SelectSingleNode("Name").InnerText;
                p.Email = xNode.SelectSingleNode("Email").InnerText;
                p.StreetAddress = xNode.SelectSingleNode("Address").InnerText;
                p.AdditionNotes = xNode.SelectSingleNode("Notes").InnerText;
                p.Birthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Birthday").InnerText));
                people.Add(p);
                listView1.Items.Add(p.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.StreetAddress = textBox3.Text;
            p.Email = textBox2.Text;
            p.Birthday = dateTimePicker1.Value;
            p.AdditionNotes = textBox4.Text;
            people.Add(p);
            listView1.Items.Add(p.Name);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = people[listView1.SelectedItems[0].Index].Name;
                textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
                textBox3.Text = people[listView1.SelectedItems[0].Index].StreetAddress;
                textBox4.Text = people[listView1.SelectedItems[0].Index].AdditionNotes;
                dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;
            }
            catch (Exception)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
        }

        void Remove()
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                people.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch { }
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            people[listView1.SelectedItems[0].Index].Name = textBox1.Text;
            people[listView1.SelectedItems[0].Index].Email = textBox2.Text;
            people[listView1.SelectedItems[0].Index].StreetAddress = textBox3.Text;
            people[listView1.SelectedItems[0].Index].AdditionNotes = textBox4.Text;
            people[listView1.SelectedItems[0].Index].Birthday = dateTimePicker1.Value;
            listView1.SelectedItems[0].Text = textBox1.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.CurrentDirectory; //Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\Address Book - Adam\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll();
            foreach (Person p in people)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xAddress = xDoc.CreateElement("Address");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");
                xName.InnerText = p.Name;
                xEmail.InnerText = p.Email;
                xAddress.InnerText = p.StreetAddress;
                xNotes.InnerText = p.AdditionNotes;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();
                xTop.AppendChild(xName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xNotes);
                xTop.AppendChild(xBirthday);
                xDoc.DocumentElement.AppendChild(xTop);                
            }
            xDoc.Save(path + "\\Address Book - Adam\\settings.xml");
        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string StreetAddress
        {
            get;
            set;
        }
        public string AdditionNotes
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
    }


}
