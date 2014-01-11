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
    public partial class UserControl1 : Button
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value == "XYX")
                {
                    MessageBox.Show("XYZ");
                    base.Text = "XYZ";
                    return;
                }
                base.Text = value;
            }
        }
        protected override void OnClick(EventArgs e)
        {
            //MessageBox.Show("");
            base.OnClick(e);
        }
    }
}
