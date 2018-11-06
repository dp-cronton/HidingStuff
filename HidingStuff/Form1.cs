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
            HideAll();
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label4.Show();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label5.Show();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label6.Show();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                label7.Show();
            }
        }

        private void HideAll()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }
    }
}
