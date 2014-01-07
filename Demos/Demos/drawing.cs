using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //for LinearGradientBrush

namespace Demos
{
    public partial class drawing : Form
    {
        public drawing()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //SolidBrush sb = new SolidBrush(Color.Blue);
            //Graphics g = panel1.CreateGraphics();
            ////g.FillRectangle(sb, 20, 20, 50, 50);
            ////g.FillEllipse(sb, 50, 50, 50, 50);
            ////g.FillPie(sb, 20, 20, 60, 60, 0, 270);
            //Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            //g.FillPolygon(sb, points);
            //FontFamily ff = new FontFamily("Courier New");
            //System.Drawing.Font font = new System.Drawing.Font(ff, 50, FontStyle.Bold);
            //g.DrawString("Adam", font, sb, new Point(20, 20));

            //Pen pen = new Pen(Color.Red, 3);
            //Graphics g = panel1.CreateGraphics();
            //g.DrawRectangle(pen, 20, 20, 50, 50);
            //g.DrawArc(pen, 20, 20, 100, 100, 0, 90);
            //g.DrawBezier(pen, new Point(20, 20), new Point(30, 60), new Point(70, 40), new Point(50, 100));
            //g.DrawLine(pen, new Point(0, 0), new Point(100, 100));

            //LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Red, Color.Yellow);
            //Graphics g = panel1.CreateGraphics();
            ////g.FillRectangle(lgb, 20, 20, 50, 50);
            ////g.FillEllipse(lgb, 70, 70, 50, 50);
            //ColorBlend cb = new ColorBlend();
            //cb.Colors = new Color[] { Color.Black, Color.Blue, Color.White };
            //cb.Positions = new float[] { 0, .5F, 1F };
            //lgb.InterpolationColors = cb;
            //g.FillRectangle(lgb, 20, 20, 50, 50);

            GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(20, 20, 100, 100);
            //Rectangle r = new Rectangle(20, 20, 50, 50);
            //gp.AddRectangle(r);
            Point[] points = { new Point(20, 20), new Point(20, 70), new Point(70, 20) };
            gp.AddPolygon(points);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.Red;
            pgb.SurroundColors = new Color[] { Color.Yellow };
            Graphics g = panel1.CreateGraphics();
            //g.FillEllipse(pgb, 20, 20, 100, 100);
            //g.FillRectangle(pgb, r);
            g.FillPolygon(pgb, points);
        }

        void SelectColor()
        {
            ColorDialog cd = new ColorDialog();
            //cd.AllowFullOpen = false;
            //cd.FullOpen = true;
            cd.ShowHelp = true;
            cd.HelpRequest += cd_HelpRequest;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color c = cd.Color; //Color.FromKnowColor(KnowColor.GradientActiveCaption);
                //int i = c.ToArgb();

                //c.IsNamedColor
                //KnowColor.WindowText
                button1.BackColor = cd.Color;
            }
        }

        void cd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Test"); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SelectColor();
        }
    }
}
