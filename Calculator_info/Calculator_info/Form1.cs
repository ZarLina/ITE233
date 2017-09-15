using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The CE button clears the most recent entry, " +
                "so if you make a mistake in a long computation," +
                " you don't need to start all over again.";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button subtracts the number from textbox " +
                "by the number that you put next.";
        }

        private void in_power_of_2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button calculates the number of the power of 2.";
        }

        private void in_power_of_3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button calculates the number of the power of 3.";
        }

        private void in_power_of_number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button calculates the number of the power of next number that you put.";
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The n! button is used to calculate the factorial of the number.";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button multiplies the number from textbox by the number that you put next";
        }

        private void division_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button performs division.";
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The Mod button is used to calculate the modulo of the number.";
        }

        private void ten_in_power_of_number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button calculates 10 in number of the number in the textbox.";
        }

        private void memory_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The MC button clears the memory of any stored number.";
        }

        private void exp_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button is used to enter a number in exponential form.";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This buttom sums up your numbers.";
        }

        private void solution_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button prints out your result.";
        }

        private void sub_from_memory_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The M+ button subtracts the number from memmory " +
                "by the number from the textbox.";
        }

        private void add_from_memory_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The M+ button adds the number from textbox to the memmory.";
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The C button will clear all input to the calculator.";
        }

        private void clear_one_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "This button will remove the last digit of the displayed number.";
        }
    }
}
