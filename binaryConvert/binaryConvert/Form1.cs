﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaryConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
           int input = int.Parse(enter_num.Text);
           output.Text = Convert.ToString(input, 2);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            enter_num.Clear();
            output.Clear();
        }
    }
}
