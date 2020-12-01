using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CalculatorProject3155
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float minVal = float.Parse(textBox1.Text);
            float maxVal = float.Parse(textBox2.Text);
            string equation = textBox3.Text;

            //initializing arrays
            float range = maxVal - minVal;
            double[] yVals = new double[100];
            double[] xVals = new double[100];
            for (int i = 0; i < 100; i++)
            {
                xVals[i] = minVal + i * (range / 100);
            }
            DataTable dt = new DataTable();

            //if a constant value is entered
            if (!equation.Contains('x') & !equation.Contains('X'))
            {
                for (int i = 0; i < 100; i++)
                {
                    yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                }
            }

            //If There Is A Variable In The Equation
            else
            {
                if (equation.Contains('x'))
                {

                    if (equation.Contains('^'))
                    {

                        int indexOfX = equation.IndexOf('x');
                        int indexOfSq = equation.IndexOf('^');
                        string string1 = equation.Substring(0, indexOfX);
                        string string2 = equation.Substring(indexOfX + 1, equation.Length - (indexOfX + 1));
                        int powerNum = int.Parse(equation.Substring(indexOfSq + 1, 1));
                        if (equation.IndexOf('x') + 1 == equation.IndexOf('^'))
                        {
                            string2 = equation.Substring(indexOfX + 3, equation.Length - (indexOfX + 3));
                            for (int i = 0; i < 100; i++)
                            {
                                double newXVal = Math.Pow(xVals[i], powerNum);
                                equation = string1 + newXVal.ToString() + string2;
                                yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                            }
                        }

                        else
                        {
                            int baseNum = int.Parse(equation.Substring(indexOfSq - 1, 1));
                            powerNum = int.Parse(equation.Substring(indexOfSq + 1, 1));
                            double expVal = Math.Pow(baseNum, powerNum);
                            if (indexOfX > indexOfSq)
                            {
                                string1 = equation.Substring(0, indexOfSq - 1);
                                string2 = equation.Substring(indexOfSq + 2, indexOfX);
                                string string3 = equation.Substring(indexOfX + 1, equation.Length - (indexOfX + 1));
                                for (int i = 0; i < 100; i++)
                                {
                                    equation = string1 + expVal.ToString() + string2 + xVals[i].ToString() + string3;
                                    yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                                }
                            }
                            else
                            {
                                string1 = equation.Substring(0, indexOfX);
                                string2 = equation.Substring(indexOfX + 1, indexOfSq - 1);
                                string string3 = equation.Substring(indexOfSq + 2, equation.Length - (indexOfSq + 2));
                                for (int i = 0; i < 100; i++)
                                {
                                    equation = string1 + xVals[i].ToString() + string2 + expVal.ToString() + string3;
                                    yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                                }
                            }
                        }

                    }

                    else
                    {
                        int indexOfX = equation.IndexOf('x');
                        string string1 = equation.Substring(0, indexOfX);
                        string string2 = equation.Substring(indexOfX + 1, equation.Length - (indexOfX + 1));
                        for (int i = 0; i < 100; i++)
                        {
                            equation = string1 + xVals[i].ToString() + string2;
                            yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                        }
                    }

                }




                if (equation.Contains('X'))
                {
                    int indexOfX = equation.IndexOf('X');
                    string string1 = equation.Substring(0, indexOfX);
                    string string2 = equation.Substring(indexOfX + 1, equation.Length - (indexOfX + 1));
                    for (int i = 0; i < 100; i++)
                    {
                        equation = string1 + xVals[i].ToString() + string2;
                        yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                    }
                }
            }
            double maxY = 0;
            for (int i = 0; i < 100; i++)
            {
                if (yVals[i] > maxY)
                {
                    maxY = yVals[i];
                }
            }

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = maxY;
            chart.AxisX.Minimum = minVal;
            chart.AxisX.Maximum = maxVal;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = (int)maxY / 10;

            chart1.Series.Add("Series 1");
            chart1.Series["Series 1"].ChartType = SeriesChartType.Line;
            chart1.Series["Series 1"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;

            for (int i = 0; i < 100; i++)
            {
                chart1.Series["Series 1"].Points.AddXY(xVals[i], yVals[i]);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
