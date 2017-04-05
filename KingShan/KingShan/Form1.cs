using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingShan
{
    public partial class Form1 : Form
    {
        double bikeTraffSped = 10;
        double tuktukTraffSped = 12;
        double carTraffSped = 20;
        double obit1TraffSped;
        double obit2TraffSped;
        string weather;
        string obitOuput;
        string vehicleOuput;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            weather = "sunny";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            weather = "rainy";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            weather = "windy";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            obit1TraffSped = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            obit2TraffSped = double.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (weather != null)
            {
                if (obit1TraffSped != 0)
                {
                    if (obit2TraffSped != 0)
                    {
                        if (obit1TraffSped > obit2TraffSped)
                        {
                            obitOuput = "Orbit1";
                            if (weather == "sunny")
                            {
                                if (obit1TraffSped >= carTraffSped)
                                {
                                    vehicleOuput = "Car";
                                }
                                else if (obit1TraffSped >= tuktukTraffSped)
                                {
                                    vehicleOuput = "Tuk Tuk";
                                }
                                else
                                {
                                    vehicleOuput = "Bike";
                                }
                            }
                            else if (weather == "rainy")
                            {
                                if (obit1TraffSped >= carTraffSped)
                                {
                                    vehicleOuput = "Car";
                                }
                                else
                                {
                                    vehicleOuput = "Tuk Tuk";
                                }
                            }
                            else if (weather == "windy")
                            {
                                if (obit1TraffSped >= carTraffSped)
                                {
                                    vehicleOuput = "Car";
                                }
                                else if (obit1TraffSped >= tuktukTraffSped)
                                {
                                    vehicleOuput = "Tuk Tuk";
                                }
                                else
                                {
                                    vehicleOuput = "Bike";
                                }
                            }
                            lblOut.Text = "Vehicle " + vehicleOuput + " on " + obitOuput;
                        }
                        else
                        {
                            obitOuput = "Orbit2";
                            if (weather == "sunny")
                            {
                                if (obit2TraffSped >= carTraffSped)
                                {
                                    vehicleOuput = "Car";
                                }
                                else if (obit2TraffSped >= tuktukTraffSped)
                                {
                                    vehicleOuput = "Tuk Tuk";
                                }
                                else
                                {
                                    vehicleOuput = "Bike";
                                }
                            }
                            else if (weather == "rainy")
                            {
                                if (obit2TraffSped >= carTraffSped)
                                {
                                    vehicleOuput = "Car";
                                }
                                else
                                {
                                    vehicleOuput = "Tuk Tuk";
                                }
                            }
                            else if (weather == "windy")
                            {
                                if (obit2TraffSped >= carTraffSped)
                                {
                                    vehicleOuput = "Car";
                                }
                                else if (obit2TraffSped >= tuktukTraffSped)
                                {
                                    vehicleOuput = "Tuk Tuk";
                                }
                                else
                                {
                                    vehicleOuput = "Bike";
                                }
                            }
                            lblOut.Text = "Vehicle " + vehicleOuput + " on " + obitOuput;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Orbit2 Traffic Speed");
                        textBox2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Orbit1 Traffic Speed");
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Choose weather condition.");
            }
        }
    }
}
