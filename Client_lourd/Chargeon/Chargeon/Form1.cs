﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chargeon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowForm2(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }

        private void ShowForm3(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            
        }

        private void ShowForm4(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();

        }

        private void ShowForm5(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();

        }
    }
}
