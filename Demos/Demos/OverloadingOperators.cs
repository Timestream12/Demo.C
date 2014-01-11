using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demos
{
    public partial class OverloadingOperators : Form
    {
        public OverloadingOperators()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Item item1 = new Item();
            //item1.Price = 4;
            //Item item2 = new Item();
            //item2.Price = 6;
            //Item item3 = item1 + item2;
            //MessageBox.Show(item3.Price.ToString());
            //if (item1 != item2) MessageBox.Show("These items are not the same.");
            //if (item1 < item2) MessageBox.Show("The second item is greater.");
            //item1++;
            //MessageBox.Show(item1.Price.ToString());

            //Item i = (Item)3;   //Explicit
            //Item item = 3;      //Implicit
            //MessageBox.Show(item.Price.ToString());

            int Age = 3;
            string name;
            Modify(ref Age, out name);
            MessageBox.Show(Age.ToString() + "::" + name);
        }

        void Modify(ref int age, out string Name)
        {
            age += 5;
            Name = "Adam";
        }
    }

    class Item
    {
        public int Price
        {
            get;
            set;
        }

        //public static explicit operator Item(int itemPrice)
        //{
        //    Item i = new Item();
        //    i.Price = itemPrice;
        //    return i;
        //}
        public static implicit operator Item(int itemPrice)
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        } 

        public static Item operator +(Item i1, Item i2)
        {
            Item i3 = new Item();
            i3.Price = i1.Price + i2.Price;
            return i3;
        }
        public static bool operator ==(Item i1, Item i2)
        {
            return (i1.Price == i2.Price) ? true : false;
        }
        public static bool operator !=(Item i1, Item i2)
        {
            return (i1.Price != i2.Price) ? true : false;
        }
        public static bool operator <(Item i1, Item i2)
        {
            return (i1.Price < i2.Price) ? true : false;
        }
        public static bool operator >(Item i1, Item i2)
        {
            return (i1.Price > i2.Price) ? true : false;
        }
        public static Item operator ++(Item i)
        {
            Item i2 = new Item();
            i2.Price = i.Price + 1;
            return i2;
        }
        public static Item operator --(Item i)
        {
            Item i2 = new Item();
            i2.Price = i.Price - 1;
            return i2;
        }


    }
}
