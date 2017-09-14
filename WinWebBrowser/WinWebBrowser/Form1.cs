using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(new Uri(comboBox2.SelectedItem.ToString()));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            webBrowser2.GoHome();

        }
    }
}
