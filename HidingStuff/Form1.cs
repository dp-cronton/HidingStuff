using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HidingStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Show();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {

            }
            else if (comboBox1.SelectedIndex == 2)
            {

            }
            else if (comboBox1.SelectedIndex == 3)
            {

            }
            else if (comboBox1.SelectedIndex == 4)
            {

            }
            else if (comboBox1.SelectedIndex == 5)
            {

            }
            else if (comboBox1.SelectedIndex == 6)
            {

            }
        }
    }
}
