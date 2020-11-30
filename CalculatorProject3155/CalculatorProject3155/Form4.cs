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
        }

        private void Convert_Click(object sender, EventArgs e)
        {

        }

        //From List
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //To List
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}