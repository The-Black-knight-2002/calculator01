using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator01
{
    public partial class Form1 : Form
    {
        double result;
        double firstdigit;
        string abbb;
        bool isoptr = false;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            Height = 350;
            Width = 530;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isoptr)
            {
                textBox1.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            textBox1.Text = result.ToString();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Exp(result);
            textBox1.Text = result.ToString();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Tanh(result);
            textBox1.Text = result.ToString();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cosh(result);
            textBox1.Text = result.ToString();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sinh(result);
            textBox1.Text = result.ToString();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Log10(result);
            textBox1.Text = result.ToString();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Log(result);
            textBox1.Text = result.ToString();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 2);
            textBox1.Text = result.ToString();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 3);
            textBox1.Text = result.ToString();
        }
        private void button25_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Ceiling(result);
            textBox1.Text = result.ToString();
        }
        private void button26_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = 1 / result;
            textBox1.Text = result.ToString();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Floor(result);
            textBox1.Text = result.ToString();
        }
        private void button28_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = (firstdigit % double.Parse(textBox1.Text));
            textBox1.Text = result.ToString();
        }
        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result * -1;
            textBox1.Text = result.ToString();
        }
        private void button34_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(textBox1.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }
   

        private void button38_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            switch (abbb)
            {
                case "+":
                    textBox1.Text = (firstdigit + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (firstdigit - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (firstdigit * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (firstdigit / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

    
    }
}
