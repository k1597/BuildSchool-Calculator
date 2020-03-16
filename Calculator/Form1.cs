using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLibrary;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double x=5, y=0;
        int alpha = 0;
        number num = new number();

        public Form1()
        {
            InitializeComponent();
        }

        private void button24_Click(object sender, EventArgs e)
        {            
            num.y = int.Parse(textBox1.Text);
            switch (alpha) 
            {
                case 1: textBox1.Text=num.plus().ToString(); break;
                case 2: textBox1.Text = num.sub().ToString(); break;
                case 3: textBox1.Text = num.mult().ToString(); break;
                case 4: textBox1.Text = num.division().ToString(); break;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            num.x = int.Parse(textBox1.Text);
            alpha = 1;
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "-";
            num.x = int.Parse(textBox1.Text);
            alpha = 2;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "*";
            num.x = int.Parse(textBox1.Text);
            alpha = 3;
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "/";
            num.x = int.Parse(textBox1.Text);
            alpha = 4;
            textBox1.Clear();
        }
    }
}
