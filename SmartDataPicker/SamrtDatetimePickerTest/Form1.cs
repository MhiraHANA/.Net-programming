﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamrtDatetimePickerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (smartDatetimePicker1.BackColor == Color.Yellow)
                smartDatetimePicker1.BackColor = Color.Turquoise;
            else
                smartDatetimePicker1.BackColor = Color.Yellow;
        }
    }
}
