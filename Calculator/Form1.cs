using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
     double EvenTT = 0, answer;
        string numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvenTT = 1;
            numbers = textBox1.Text;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvenTT = 2;
            numbers = textBox1.Text;
            textBox1.Text = "";

        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            EvenTT = 3;
            numbers = textBox1.Text;
            textBox1.Text = "";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            EvenTT = 4;
            numbers = textBox1.Text;
            textBox1.Text = "";
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            EvenTT = 5;
            numbers = textBox1.Text;
            
            answer = Convert.ToDouble(numbers) * Convert.ToDouble(numbers);
            textBox1.Text = Convert.ToString(answer);
            EvenTT = 0;
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            EvenTT = 6;
            numbers = textBox1.Text;

            answer = Convert.ToDouble(numbers) * Convert.ToDouble(numbers) * Convert.ToDouble(numbers);
            textBox1.Text = Convert.ToString(answer);
            EvenTT = 0;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

      

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (EvenTT == 1)
            {
                answer = Convert.ToDouble(numbers) + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(answer);
                EvenTT = 0;
            }
            else if (EvenTT == 2)
            {
                answer = Convert.ToDouble(numbers) - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(answer);
                EvenTT = 0;

            }
            else if (EvenTT == 3)
            {
                answer = Convert.ToDouble(numbers) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(answer);
                EvenTT = 0;
            }
            else if (EvenTT == 4)
            {
                answer = Convert.ToDouble(numbers) / Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(answer);
                EvenTT = 0;

            }
            
        }

        private void DigitHandler(object sender, EventArgs e)
        {
            string digit = ((Button)sender).Text;
            textBox1.Text += digit;
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }


        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmClear_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            answer = 0;
            numbers = "";
        }

      



      
       
    }
}
