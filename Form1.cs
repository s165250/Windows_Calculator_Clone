using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "1";
            }
            else
            {
                this.ResultBox.Text = "1";
                resultCalculated = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "2";
            }
            else
            {
                this.ResultBox.Text = "2";
                resultCalculated = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "3";
            }
            else
            {
                this.ResultBox.Text = "3";
                resultCalculated = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "4";
            }
            else
            {
                this.ResultBox.Text = "4";
                resultCalculated = false;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "5";
            }
            else
            {
                this.ResultBox.Text = "5";
                resultCalculated = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "6";
            }
            else
            {
                this.ResultBox.Text = "6";
                resultCalculated = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "7";
            }
            else
            {
                this.ResultBox.Text = "7";
                resultCalculated = false;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "8";
            }
            else
            {
                this.ResultBox.Text = "8";
                resultCalculated = false;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "9";
            }
            else
            {
                this.ResultBox.Text = "9";
                resultCalculated = false;

            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (this.ResultBox.Text != "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
            {
                this.ResultBox.Text += "0";
            }
            else
            {
                this.ResultBox.Text = "0";
                resultCalculated = false;

            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text.Length > 0)
            {
                if (this.ResultBox.Text[this.ResultBox.Text.Length - 1] != ',' && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" && resultCalculated == false)
                {
                    this.ResultBox.Text += ",";
                }
                else
                {
                    this.ResultBox.Text = "0,";
                    resultCalculated = false;
                }
            }
            else
            {
                this.ResultBox.Text = "0,";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.ResultBox.Text = "0";
            a = 0;
            b = 0;
            operationCode = 0;
        }

        private void buttonPLUS_Click(object sender, EventArgs e)
        {
            operationCode = 1;
            if(Double.TryParse(this.ResultBox.Text, out a))
            {
                this.ResultBox.Text = "0";
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonMINUS_Click(object sender, EventArgs e)
        {
            operationCode = 2;
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.ResultBox.Text = "0";
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            operationCode = 3;
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.ResultBox.Text = "0";
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            operationCode = 4;
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.ResultBox.Text = "0";
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                a *= -1;
                this.ResultBox.Text = a.ToString();
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonINV_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                if (a != 0)
                {
                    a = 1 / a;
                    this.ResultBox.Text = a.ToString();
                }
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonPERCENT_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                a /= 100;
                this.ResultBox.Text = a.ToString();
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                if (a >= 0)
                {
                    a = Math.Sqrt(a);
                    this.ResultBox.Text = a.ToString();
                }
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.buttonMC.Enabled = true;
                this.buttonMR.Enabled = true;
                memory += a;
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonMmin_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.buttonMC.Enabled = true;
                this.buttonMR.Enabled = true;
                memory -= a;
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.buttonMC.Enabled = true;
                this.buttonMR.Enabled = true;
                memory = a;
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            this.ResultBox.Text = memory.ToString();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            this.buttonMC.Enabled = false;
            this.buttonMR.Enabled = false;
            memory = 0;
        }

        private void buttonRET_Click(object sender, EventArgs e)
        {
            if (this.ResultBox.Text.Length > 1)
            {
                this.ResultBox.Text = this.ResultBox.Text.Remove(this.ResultBox.Text.Length - 1);
            }
            else
            {
                this.ResultBox.Text = "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            this.ResultBox.Text = "0";
        }

        private void buttonRESULT_Click(object sender, EventArgs e)
        {
            switch(operationCode)
            {
                // Dodawanie
                case 1:
                    if(Double.TryParse(this.ResultBox.Text, out b))
                    {
                        a += b;
                        this.ResultBox.Text = a.ToString();
                    }
                    break;
                // Odejmowanie
                case 2:
                    if (Double.TryParse(this.ResultBox.Text, out b))
                    {
                        a -= b;
                        this.ResultBox.Text = a.ToString();
                    }
                    break;
                // Mnożenie
                case 3:
                    if (Double.TryParse(this.ResultBox.Text, out b))
                    {
                        a *= b;
                        this.ResultBox.Text = a.ToString();
                    }
                    break;
                // Dzielenie
                case 4:
                    if (Double.TryParse(this.ResultBox.Text, out b))
                    {
                        if (b != 0)
                        {
                            a /= b;
                            this.ResultBox.Text = a.ToString();
                        }
                        else
                        {
                            this.ResultBox.Text = "Nie można dzielić przez 0!";
                        }
                    }
                    break;
            }
            resultCalculated = true;
        }
    }
}
