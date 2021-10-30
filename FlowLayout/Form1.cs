﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new TestRow("XD", "Holas", "20", "15", "30", "V", null));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new TestRow("XD", "Holas", "20", "15", "30", "V", "Contaminacion, no soldo"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new TestGroupHeader());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new TestGroupRow());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new TestHeader());
        }
    }
}
