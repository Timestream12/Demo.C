﻿using System;
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
    public partial class notifyicon : Form
    {
        public notifyicon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.ShowBalloonTip(1000, "Still Running", "Your app is still running.", ToolTipIcon.Info);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
