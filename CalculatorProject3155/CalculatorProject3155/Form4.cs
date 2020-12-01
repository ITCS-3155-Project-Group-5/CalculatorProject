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
        string unit1 = string.Empty;
        string unit2 = string.Empty;
        double result = 0.0;

        

        public Form4()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "0";
            this.OutcomeTextBox.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += ".";
            this.OutcomeTextBox.Text += input;
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "-";
            this.OutcomeTextBox.Text += input;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "1";
            this.OutcomeTextBox.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "2";
            this.OutcomeTextBox.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "3";
            this.OutcomeTextBox.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "4";
            this.OutcomeTextBox.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "5";
            this.OutcomeTextBox.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "6";
            this.OutcomeTextBox.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "7";
            this.OutcomeTextBox.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            this.OutcomeTextBox.Text = "";
            input += "8";
            this.OutcomeTextBox.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
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
            //this.unit1 = string.Empty;
            //this.unit2 = string.Empty;
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            //if statement to check if user input has the negative sign only in the front
            if (input.Contains('-'))
            {
                if (input.IndexOf('-') != 0)
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }
            }

            if (input.Contains('-') || input.Contains('.'))
            {

                if (input.Count(f => (f == '-')) > 1 || input.Count(f => (f == '.')) > 1 )
                {
                    OutcomeTextBox.Text = "Misuse of decimal or negative button. Press CLEAR.";
                    return;
                }

            }

            double num1;
            double.TryParse(input, out num1);

            //Temp
            if(unit1 == "Celcius")
            {
                if(unit2 == "Fahrenheit")
                {
                    result = num1 * 1.8 + 32;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Celcius")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If length or weight are selected
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Centimeters")
            {
                if(unit2 == "Feet")
                {
                    result = num1 / 30.48;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 / 2.54;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 / 100000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 / 100;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 160934;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 10;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 / 91.44;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Centimeters")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight is selected
                else
                {
                    OutcomeTextBox.Text = "Cna not convert. Press CLEAR, reclick new units";
                }
            }

            //Temp
            else if(unit1 == "Fahrenheit")
            {
                if(unit2 == "Celcius")
                {
                    result = (num1 - 32) / ( 9/5 );
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Fahrenheit")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If weight or length
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Feet")
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 * 30.48;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 * 12;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 / 3281;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 / 3.281;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 5280;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 305;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 / 3;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Weight
            else if(unit1 == "Grams")
            {
                if(unit2 == "Kilograms")
                {
                    result = num1 / 1000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Pounds")
                {
                    result = num1 / 454;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Grams")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or length
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Inches")
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 * 2.54;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1 / 12;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 / 39370;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 / 39.37;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 63360;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 25.4;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 / 36;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Weight
            else if(unit1 == "Kilograms")
            {
                if(unit2 == "Grams")
                {
                    result = num1 * 1000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilograms")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Pounds")
                {
                    result = num1 * 2.205;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or length
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Kilometers")
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 * 100000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1 * 3281;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 * 39370;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 * 1000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 1.609;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 1000000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 * 1094;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Meters")
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 * 100;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1 * 3.281;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 * 39.37;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 / 1000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 1609;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 1000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 * 1.094;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If weight or temp
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Miles")
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 * 160934;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1 * 5280;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 * 63360;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 * 1.609;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 * 1609;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 1609000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 * 1760;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Length
            else if(unit1 == "Millimeters")
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 / 10;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1 / 305;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 / 25.4;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 / 1000000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 / 1000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 1609000;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1 / 914;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Weight
            else if(unit1 == "Pounds")
            {
                if(unit2 == "Grams")
                {
                    result = num1 * 454;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilograms")
                {
                    result = num1 / 2.205;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Pounds")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or length
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

            //Yards, length
            else
            {
                if(unit2 == "Centimeters")
                {
                    result = num1 * 91.44;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Feet")
                {
                    result = num1 * 3;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Inches")
                {
                    result = num1 * 36;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Kilometers")
                {
                    result = num1 / 1094;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Meters")
                {
                    result = num1 / 1.094;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Miles")
                {
                    result = num1 / 1760;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Millimeters")
                {
                    result = num1 * 914;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                else if(unit2 == "Yards")
                {
                    result = num1;
                    OutcomeTextBox.Text = result.ToString();
                    input = result.ToString();
                }
                //If temp or weight
                else
                {
                    OutcomeTextBox.Text = "Can not convert. Press CLEAR, reclick units";
                }
            }

        }

        //From List
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            unit1 = listBox1.SelectedItem.ToString();
        }

        //To List
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            unit2 = listBox2.SelectedItem.ToString();
        }

        //
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}