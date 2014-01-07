using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class classDelegate
    {
        delegate void MyDelegate(string myString);
        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage);
            md += ShowAnotherMessage;
            md("Adam");
        }
        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        void ShowAnotherMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show(a, "Test");
        }
    }

}
