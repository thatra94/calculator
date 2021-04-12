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
        string operation = "";
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
            operation = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(calculateTextBox.Text != "")
            {
                calculateTextBox.Text += ",";
            } else
            {
                calculateTextBox.Text += "0,";
            }
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
                if (CheckForOperator() == true)
                {
                    calculateTextBox.Text += "+";
                }
                operation = "+";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text != "")
            {
                calculate();
                if (CheckForOperator() == true)
                {
                    calculateTextBox.Text += "/";
                }
                operation = "/";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text != "")
            {
                calculate();
                if (CheckForOperator() == true)
                {
                    calculateTextBox.Text += "-";
                }
                operation = "-";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text != "")
            {
                calculate();
                if (CheckForOperator() == true)
                {
                    calculateTextBox.Text += "*";
                }
                operation = "*";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            calculate();
        }
        private void calculate() {
            int position = calculateTextBox.Text.IndexOf(operation);
            if(position > 0 && position != calculateTextBox.Text.Length -1)
            {
                float firstNumber = float.Parse(calculateTextBox.Text.Substring(0, position));
                float secondNumer = float.Parse(calculateTextBox.Text.Substring(position + 1));

                switch (operation)
                {
                    case "+":
                        calculateTextBox.Text = (firstNumber + secondNumer).ToString();
                        break;
                    case "-":
                        calculateTextBox.Text = (firstNumber - secondNumer).ToString();
                        break;
                    case "/":
                        calculateTextBox.Text = (firstNumber / secondNumer).ToString();
                        break;
                    case "*":
                        calculateTextBox.Text = (firstNumber * secondNumer).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
        public bool CheckForOperator()
        {
            string lastLetter = calculateTextBox.Text[calculateTextBox.Text.Length - 1].ToString();
            if (lastLetter != "-" && lastLetter != "+" && lastLetter != "/" && lastLetter != "*")
            {
                return true;
            }
            return false;
        }
    }
}
