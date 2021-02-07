using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.00; double weight = 0.00; double BMI = 0.00;
            height = Convert.ToDouble(textBox1.Text);
            weight = Convert.ToDouble(textBox2.Text);
            BMI = weight / (height * height);

            if (comboBox1.SelectedIndex == 0)
            {
                BMI = Math.Round(BMI, 2);
                textBox3.Text = Convert.ToString(BMI);
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                BMI = BMI * 703;
                BMI = Math.Round(BMI, 2);
                textBox3.Text = Convert.ToString(BMI);
            }
            else
            {
                textBox3.Text = ("Select an option for conversion");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
