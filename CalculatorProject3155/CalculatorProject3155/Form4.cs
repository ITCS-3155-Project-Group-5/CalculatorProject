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
    public partial class Form4 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string unit = string.Empty;

        public Form4()
        {
            InitializeComponent();
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

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "0";
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
        }

        private void Inches_Click(object sender, EventArgs e)
        {

        }

        private void Feet_Click(object sender, EventArgs e)
        {

        }

        private void Yard_Click(object sender, EventArgs e)
        {

        }

        private void Miles_Click(object sender, EventArgs e)
        {
            
        }

        private void Millimeter_Click(object sender, EventArgs e)
        {

        }

        private void Centimeter_Click(object sender, EventArgs e)
        {

        }

        private void Meter_Click(object sender, EventArgs e)
        {

        }

        private void Kilometer_Click(object sender, EventArgs e)
        {

        }

        private void Pounds_Click(object sender, EventArgs e)
        {

        }

        private void Grams_Click(object sender, EventArgs e)
        {

        }

        private void Kilograms_Click(object sender, EventArgs e)
        {

        }

        private void Fahrenheit_Click(object sender, EventArgs e)
        {

        }

        private void Celsius_Click(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {

            //if statement to check if user input has the negative sign only in the front
            if (operand1.Contains('-'))
            {
                if (operand1.IndexOf('-') != 0)
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }
            }

            //if statement to check if user input does not have more than one negative sign or decimal
            if (operand1.Contains('-') || operand1.Contains('.'))
            {

                if (operand1.Count(f => (f == '-')) > 1 || operand1.Count(f => (f == '.')) > 1) 
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }

            }

        }
    }
}