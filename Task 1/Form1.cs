using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pounds, kilograms;

            if (comboBox1.SelectedIndex == 0)
            {
                pounds = Convert.ToDouble(textBox1.Text);
                kilograms = pounds * 0.453592;
                kilograms = Math.Round(kilograms, 2);
                textBox2.Text = Convert.ToString(kilograms);
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                kilograms = Convert.ToDouble(textBox1.Text);
                pounds = kilograms * 2.20462;
                pounds = Math.Round(pounds, 2);
                textBox2.Text = pounds.ToString();
            }

            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = ("Please enter a value");
            }

            else
            {
                textBox2.Text = ("Invalid input");
            }
        }
    }
}
