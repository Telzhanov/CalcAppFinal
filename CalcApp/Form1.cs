using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        CalcBrain brain = new CalcBrain();
        string symbol;
        double m;
        public Form1()
        {
            InitializeComponent();
        }
        private void digitbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }
        private void operationbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "=")
            {

                brain.secondoperand = double.Parse(textBox1.Text);
 
                if (symbol == "+")
                {
                textBox1.Text = brain.Plus().ToString();
                }
                if (symbol == "-")
                {
                    textBox1.Text = brain.Minus().ToString();
                }
                if (symbol == "*")
                {
                    textBox1.Text = brain.Multiple().ToString();
                }
                if (symbol == "/")
                {
                    textBox1.Text = brain.Divide().ToString();
                }
            }
            else if (btn.Text == "%")
            {
                brain.secondoperand = double.Parse(textBox1.Text);
                brain.secondoperand = brain.Multiple()/100;
                textBox1.Text = brain.secondoperand.ToString();

            }
            else if (btn.Text == "MS")
            {
                m = double.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            else if (btn.Text == "MC")
            {
                m = 0;
            }
            else if (btn.Text == "M+")
            {
                brain.firstoperand = double.Parse(textBox1.Text);
                textBox1.Text = (brain.firstoperand + m).ToString();
            }
            else if (btn.Text == "M-")
            {
                brain.firstoperand = double.Parse(textBox1.Text);
                textBox1.Text = (brain.firstoperand - m).ToString();
            }
            else 
            {
                brain.firstoperand = double.Parse(textBox1.Text);
                symbol = btn.Text;
                textBox1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            brain.firstoperand = 0;
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
             textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            brain.firstoperand = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
            textBox1.Text = brain.firstoperand.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            brain.firstoperand = 1/double.Parse(textBox1.Text);
            textBox1.Text = brain.firstoperand.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brain.firstoperand = Math.Sqrt(double.Parse(textBox1.Text));          
            textBox1.Text = brain.firstoperand.ToString();
        }

    }
}
