using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            char[] delimiters = { ' ', ',', ';', '?', '.', '!' };
            string[] each_word = textBox1.Text.Split(delimiters);
            listBox1.Items.Clear();
            foreach (string item in each_word)
            {
                if (item.Length > 0)
                {
                    listBox1.Items.Add(item);
                    i = i + 1;
                }
            }
            listBox1.Items.Add("\n");
            listBox1.Items.Add(i.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
