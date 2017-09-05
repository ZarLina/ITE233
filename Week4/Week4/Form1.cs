using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          input.Text = input.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
          input.Text = input.Text + 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + '.';
        }
        private void button00_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + 00;
        }


        public double a, b, c;
        public char sign;
        public double memory;
        public double first, second;
        private double Factorial(double n)
        {
            int e = 1;
            for (int j = 1; j <= n; j++)
            {
                e *= j;
            }
            return e;
        }


        private void addition_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            sign = '+';
            input.Clear();   
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            sign = '-';
            input.Clear();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            sign = '*';
            input.Clear();
        }


        private void division_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            sign = '/';
            input.Clear();
        }

        private void clear_one_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 1)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1);
            }
            else
            {
                input.Text = 0.ToString();
            }
        }

        private void clear_number_Click(object sender, EventArgs e)
        {
            input.Focus();
            input.SelectAll();
            SendKeys.Send("{BACKSPACE}");
        }

        private void in_power_of_2_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            b = Math.Pow(a, 2);
            input.Text = b.ToString();
        }

        private void in_power_of_3_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            b = Math.Pow(a, 3);
            input.Text = b.ToString();
        }

        private void ten_in_power_of_number_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            b = Math.Pow(10, a);
            input.Text = b.ToString();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(input.Text);
            a = Factorial(n);
            input.Text = a.ToString();

        }

        private void in_power_of_number_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(input.Text);
            sign = '^';
            input.Text = "";
            input.Focus();
        }

        private void module_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            sign = 'm';
            input.Clear();

        }

        private void exp_Click(object sender, EventArgs e)
        {
            a = Double.Parse(input.Text);
            sign = 'e';
            input.Clear();
        }

        private void memory_clear_Click(object sender, EventArgs e)
        {
            memoryBox.Clear();
        }


        private void add_from_memory_Click(object sender, EventArgs e)
        {
            if (memoryBox.Text == string.Empty)
            {
                memory = Double.Parse(input.Text);
                memoryBox.Text = memory.ToString();
            }
            else
            {

                first = Double.Parse(input.Text);
                second = memory + first;
                memoryBox.Text = second.ToString();
            }

        }

        private void sub_from_memory_Click(object sender, EventArgs e)
        {   
            first = Double.Parse(input.Text);
            second = memory - first;
            memoryBox.Text = second.ToString();
        }



        private void solution_Click(object sender, EventArgs e)
        {
            if (sign == '+')
            {
                b = Double.Parse(input.Text);
                c = a + b;
                input.Text = c.ToString();
            }
            if (sign == '-')
            {
                b = Double.Parse(input.Text);
                c = a - b;
                input.Text = c.ToString();
            }
            if (sign == '*')
            {
                b = Double.Parse(input.Text);
                c = a * b;
                input.Text = c.ToString();
            }
            if (sign == '/')
            {
                b = Double.Parse(input.Text);
                c = a / b;
                input.Text = c.ToString();
            }
            if (sign == '^')
            {
                b = Double.Parse(input.Text);
                c = Math.Pow(a, b);
                input.Text = c.ToString();
            }
            if (sign == 'm')
            {
                b = Double.Parse(input.Text);
                c = a % b;
                input.Text = c.ToString();
            }

            if (sign == 'e')
            { 
                c = Math.Exp(a);
                input.Text = c.ToString();

            }

        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            input.Clear();
        }


    }
}
