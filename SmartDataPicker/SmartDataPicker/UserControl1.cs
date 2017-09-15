using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDataPicker
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("You selected the date {0}", dateTimePicker1.Text);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = string.Format("You selected the date {0}", dateTimePicker2.Text);
        }
    }
}
