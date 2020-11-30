using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject3155
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "0";
            this.OutcomeTextBox.Text += input;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += ".";
            this.OutcomeTextBox.Text += input;
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "-";
            this.OutcomeTextBox.Text += input;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "1";
            this.OutcomeTextBox.Text += input;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "2";
            this.OutcomeTextBox.Text += input;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "3";
            this.OutcomeTextBox.Text += input;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "4";
            this.OutcomeTextBox.Text += input;
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "5";
            this.OutcomeTextBox.Text += input;
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "6";
            this.OutcomeTextBox.Text += input;
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "7";
            this.OutcomeTextBox.Text += input;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "8";
            this.OutcomeTextBox.Text += input;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "9";
            this.OutcomeTextBox.Text += input;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            operand2 = input;

            //if statement to check if user input has the negative sign only in the front
            if (operand1.Contains('-'))
            {
                if (operand1.IndexOf('-') != 0)
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }
            }

            //if statement to check if user input has the negative sign only in the front
            if (operand2.Contains('-'))
            {
                if (operand2.IndexOf('-') != 0)
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }
            }

            //if statement to check if user input does not have more than one negative sign or decimal
            if (operand1.Contains('-') || operand2.Contains('-') || operand1.Contains('.') || operand2.Contains('.'))
            {

                if (operand1.Count(f => (f == '-')) > 1 || operand2.Count(f => (f == '-')) > 1 ||
                    operand1.Count(f => (f == '.')) > 1 || operand2.Count(f => (f == '.')) > 1)
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }

            }

            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                OutcomeTextBox.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                OutcomeTextBox.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                OutcomeTextBox.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else
                {
                    OutcomeTextBox.Text = "Dividing By Zero";
                }


            }
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void OutcomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
