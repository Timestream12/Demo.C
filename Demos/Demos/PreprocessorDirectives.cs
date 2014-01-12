#define Adam1
//#undef Adam1
using System;
using System.Windows.Forms;

namespace Demos
{
    public partial class PreprocessorDirectives : Form
    {
        public PreprocessorDirectives()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region mike
            //aolkisjdf;lajsdf
            //s;ladjfl;asjkdf;lasj
            #endregion

#if Adam1
//#error
//#warning
            MessageBox.Show("Adam1 is defined");
#elif Bob1
            MessageBox.Show("Bob1 is defined");
#else
            MessageBox.Show("Test");
#endif
        }
    }
}
