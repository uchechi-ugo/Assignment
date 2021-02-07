using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Statistics_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value_1 = Convert.ToDouble(textBox6.Text);
            double value_2 = Convert.ToDouble(textBox8.Text);
            double value_3 = Convert.ToDouble(textBox9.Text);
            double value_4 = Convert.ToDouble(textBox10.Text);
            double value_5 = Convert.ToDouble(textBox11.Text);
            double value_6 = Convert.ToDouble(textBox16.Text);
            double value_7 = Convert.ToDouble(textBox15.Text);
            double value_8 = Convert.ToDouble(textBox14.Text);
            double value_9 = Convert.ToDouble(textBox13.Text);
            double value_10 = Convert.ToDouble(textBox12.Text);

            double average = (value_1 + value_2 + value_3 + value_4 + value_5 + value_6 + value_7 + value_8 + value_9 + value_10) / 10;

            List<double> ten_values = new List<double>()
            {
                value_1, value_2, value_3, value_4, value_5, value_6, value_7, value_8, value_9, value_10
            };

            ten_values.Sort();
            double median = (ten_values[4] + ten_values[5]) / 2;
            double ans = 0;

            foreach (double value in ten_values )
            {
                double new_ans = (value - average) * (value - average);
                ans += new_ans;
            }

            double variance = ans / 10;
            double standard_deviation = Math.Sqrt(variance);

            textBox2.Text = Convert.ToString(median);
            textBox5.Text = Convert.ToString(average);
            textBox3.Text = Convert.ToString(variance);
            textBox1.Text = Convert.ToString(standard_deviation);


            //Dictionary to hold the number of values for a key.
            Dictionary<double, int> dict = new Dictionary<double, int>();
            double mode = 0.00;
            int max = 0;

            foreach (double key in ten_values)
            {
                if (!dict.ContainsKey(key))
                    dict.Add(key, 1);
                else
                    dict[key] += 1;

                if (dict[key] > max)
                    max = dict[key];
            }

            SortedSet<double> keys = new SortedSet<double>(dict.Keys);
            foreach (double key in keys)
                if (dict[key] == max)
                    mode = key;

            textBox4.Text = Convert.ToString(mode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
