using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demos
{
    public partial class myButton : UserControl
    {
        public myButton()
        {
            InitializeComponent();
        }
        string text = "";
        Color myButtonColor;
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawButton(myButtonColor);
        }

        public string ButtonText
        {
            get { return text; }    //return label1.Text;
            set { text = value; }  //label1.Text = value;
        }

        private void myButton_MouseHover(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }

        public Color ButtonColor
        {
            get { return myButtonColor; }
            set
            {
                myButtonColor = value;
                try
                {
                    DrawButton(myButtonColor);
                }
                catch (Exception)
                {
                    //myButtonColor = Color.FromKnownColor(KnownColor.Control);
                    MessageBox.Show("Please select a valid color.");
                }
            }
        }

        void DrawButton(Color c)
        {
            SolidBrush s = new SolidBrush(c);   //(Color.FromKnownColor(KnownColor.Control));
            Graphics g = this.CreateGraphics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13);    //Color.FromKnownColor(KnownColor.ControlLight);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            //label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 2 - label1.Height / 2);
            //label1.BackColor = System.Drawing.Color.Transparent;
            PointF fpoint = new Point((this.Width / 2) - (text.Length * 5 / 2), (this.Height / 2) - (text.Length * 5 / 2));
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            s.Color = Color.Black;
            g.DrawString(text, f, s, fpoint);
        }

        private void myButton_MouseLeave(object sender, EventArgs e)
        {
            DrawButton(myButtonColor);
        }

        private void myButton_MouseEnter(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }

        private void myButton_MouseDown(object sender, MouseEventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R + 15, Color.FromKnownColor(KnownColor.Control).G - 15, 150);
            DrawButton(myColor);
        }
    }
}