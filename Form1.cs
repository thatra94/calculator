using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formCalculator
{
    public partial class Form1 : Form
    {
        float currentNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateInput_changed_textbox(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btnOne_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "1";
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "2";
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "3";
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "4";
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "5";
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "6";
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "7";
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "8";
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "9";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "0";
        }
        private void btnClearResult_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text = ",";
        }

        private void btnRemoveLastChar_Click(object sender, EventArgs e)
        {
            if(calculateTextBox.Text.Length != 0)
            {
                calculateTextBox.Text = calculateTextBox.Text.Remove(calculateTextBox.Text.Length - 1);
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text != "")
            {
                calculate();
                if (calculateTextBox.Text[calculateTextBox.Text.Length - 1].ToString() != "+")
                {
                    calculateTextBox.Text += "+";
                }
                operation = "addition";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "/";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "*";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }
        private void calculate() {
            Console.WriteLine("calc");
            switch(this.operation)
            {
                case "addition":
                    Console.WriteLine("addition");
                    //calculateTextBox.Text += "addition";
                    calculateTextBox.Text = currentNumber + calculateTextBox.Text;
                    break;
                case "subtract":
                    Console.WriteLine("subtract");
                    break;
                case "divide":
                    Console.WriteLine("divide");
                    break;
                case "multiply":
                    Console.WriteLine("multiply");
                    break;
                default:
                    break;
            }

        }

    }
}
