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

        private int button1Count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1Count > 0)
            {
                button1Count = 0;
                Form5 myForm = new Form5();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            if (textBox3.Text == "")
            {
                Form5 myForm = new Form5();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            button1Count++;
            float minVal = 0;
            float maxVal = 10;

            if (textBox1.Text != "")
            {
                minVal = float.Parse(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                maxVal = float.Parse(textBox2.Text);
            }
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



            //if a constant values only are entered
            if (!equation.Contains('x') & !equation.Contains('X'))
            {
                //for basic sqrt function
                if (equation.Contains("sqrt"))
                {
                    int firstParaIndex = equation.IndexOf('(');
                    int lastParaIndex = equation.IndexOf(')');
                    double sqrtNum = int.Parse(equation.Substring(firstParaIndex + 1, (lastParaIndex - firstParaIndex - 1)));
                    double newXVal = Math.Sqrt(sqrtNum);
                    string string1 = equation.Substring(0, firstParaIndex - 4);
                    string string2 = equation.Substring(lastParaIndex + 1, equation.Length - lastParaIndex);
                    for (int i = 0; i < 100; i++)
                    {
                        equation = string1 + newXVal.ToString() + string2;
                        yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                    }
                }

                //for basic exp function
                if (equation.Contains('^'))
                {
                    int indexOfSq = equation.IndexOf('^');
                    int baseNum = int.Parse(equation.Substring(indexOfSq - 1, 1));
                    int powerNum = int.Parse(equation.Substring(indexOfSq + 1, 1));
                    double expVal = Math.Pow(baseNum, powerNum);
                    for (int i = 0; i < 100; i++)
                    {
                        yVals[i] = expVal;
                    }
                }

                //any normal operations
                else
                {
                    for (int i = 0; i < 100; i++)
                    {
                        yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                    }
                }

            }

            //If There Is A Variable In The Equation
            else
            {
                //if user used a capital x instead of lowercase
                if (equation.Contains('X'))
                {
                    int indexOfX = equation.IndexOf('X');
                    equation[indexOfX].ToString().ToLower();
                }
                if (equation.Contains('x'))
                {

                    if (equation.Contains('^'))
                    {
                        //for x^#
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

                        //code for "#^x"
                        else if (equation.IndexOf('x') - 1 == equation.IndexOf('^'))
                        {
                            int xIndex = equation.IndexOf('x');
                            int baseNum = int.Parse(equation.Substring(xIndex - 3, 2));
                            string1 = equation.Substring(0, equation.Length - (xIndex - 3));
                            string2 = equation.Substring(xIndex, equation.Length - xIndex);
                            for (int i = 0; i < 100; i++)
                            {
                                double newXVal = Math.Pow(baseNum, xVals[i]);
                                equation = string1 + newXVal.ToString() + string2;
                                yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                            }
                        }

                        //code incase of "x + 2^2" or something
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


                    //code for square root
                    else if (equation.Contains("sqrt"))
                    {
                        int indexOfX = equation.IndexOf('x');
                        int firstParaIndex = equation.IndexOf('(');
                        int lastParaIndex = equation.IndexOf(')');

                        //if x come before the sqrt
                        if (indexOfX < firstParaIndex)
                        {
                            string string1 = equation.Substring(0, indexOfX);
                            string string2 = equation.Substring(indexOfX + 1, firstParaIndex - 4 - indexOfX);
                            string string3 = equation.Substring(lastParaIndex + 1, equation.Length - lastParaIndex + 2);
                            double sqrtNum = double.Parse(equation.Substring(firstParaIndex + 1, (lastParaIndex - firstParaIndex - 1)));
                            double newXVal = Math.Sqrt(sqrtNum);
                            for (int i = 0; i < 100; i++)
                            {
                                equation = string1 + xVals[i].ToString() + string2 + newXVal.ToString() + string3;
                                yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                            }
                        }

                        //if x comes after the sqrt
                        else if (indexOfX > lastParaIndex)
                        {
                            string string1 = equation.Substring(0, firstParaIndex - 4);
                            string string2 = equation.Substring(lastParaIndex + 1, indexOfX - lastParaIndex);
                            string string3 = equation.Substring(indexOfX + 1, equation.Length - indexOfX + 2);
                            double sqrtNum = double.Parse(equation.Substring(firstParaIndex + 1, (lastParaIndex - firstParaIndex - 1)));
                            double newXVal = Math.Sqrt(sqrtNum);
                            for (int i = 0; i < 100; i++)
                            {
                                equation = string1 + newXVal.ToString() + string2 + xVals[i].ToString() + string3;
                                yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                            }
                        }

                        //if x is in the sqrt
                        else
                        {
                            if (equation.Length == 7)
                            {
                                for (int i = 0; i < 100; i++)
                                {
                                    yVals[i] = Math.Sqrt(xVals[i]);
                                }
                            }
                            else
                            {
                                string string1 = equation.Substring(0, firstParaIndex - 4);
                                string string2 = equation.Substring(lastParaIndex + 1, (equation.Length - lastParaIndex - 1));
                                for (int i = 0; i < 100; i++)
                                {
                                    double newXVal = Math.Sqrt(xVals[i]);
                                    equation = string1 + newXVal.ToString() + string2;
                                    yVals[i] = Convert.ToDouble(dt.Compute(equation, ""));
                                }
                            }
                        }
                    }

                    //code for ordinary operations.
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

                double maxY = 0;
                double minY = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (yVals[i] > maxY)
                    {
                        maxY = yVals[i];
                    }
                    if (yVals[i] < minY)
                    {
                        minY = yVals[i];
                    }
                }

                var chart = chart1.ChartAreas[0];
                chart.AxisX.IntervalType = DateTimeIntervalType.Number;
                chart.AxisX.LabelStyle.Format = "";
                chart.AxisY.LabelStyle.Format = "";
                chart.AxisY.LabelStyle.IsEndLabelVisible = true;
                chart.AxisY.Minimum = minY;
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
