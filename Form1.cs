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
            SaveFirstNumber();
        }

        private void buttonMINUS_Click(object sender, EventArgs e)
        {
            operationCode = 2;
            SaveFirstNumber();
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            operationCode = 3;
            SaveFirstNumber();
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            operationCode = 4;
            SaveFirstNumber();
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
            Calculate();
        }

        private void blaBlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundFileDialog.ShowDialog();
                this.BackgroundImage = Image.FromFile(this.BackgroundFileDialog.FileName);
            }
            catch(System.IO.FileNotFoundException error)
            {
                MessageBox.Show(error.Message);
            }
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            numericPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void ResultBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Typed = e.KeyChar;
            bool goodKey = (char.IsDigit(Typed) || Typed == ',' || Typed == '.' || Typed == (char)ENTER || Typed == (char)BACKSPACE);
            e.Handled = true;
            if (goodKey)
            {
                if (this.ResultBox.Text.Length < this.ResultBox.MaxLength)
                {
                    if (char.IsDigit(Typed))
                    {
                        if (this.ResultBox.Text == "0" && this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!")
                        {
                            this.ResultBox.Text = Typed.ToString();
                            this.ResultBox.SelectionStart = this.ResultBox.Text.Length;
                        }
                        else
                        {
                            this.ResultBox.Text += Typed.ToString();
                            this.ResultBox.SelectionStart = this.ResultBox.Text.Length;
                        }
                    }
                    else if (Typed == ',' || Typed == '.')
                    {
                        if (this.ResultBox.Text[this.ResultBox.Text.Length - 1] != ',' && 
                            this.ResultBox.Text != "Nie można dzielić przez 0!" && this.ResultBox.Text != "Liczba została źle wpisana!" 
                            && resultCalculated == false)
                        {
                            this.ResultBox.Text += ",";
                            this.ResultBox.SelectionStart = this.ResultBox.Text.Length;
                        }
                    }
                }
                if (Typed == (char)BACKSPACE)
                {
                    if (this.ResultBox.Text.Length > 1)
                    {
                        this.ResultBox.Text = this.ResultBox.Text.Remove(this.ResultBox.Text.Length - 1);
                        this.ResultBox.SelectionStart = this.ResultBox.Text.Length;
                    }
                    else
                    {
                        this.ResultBox.Text = "0";
                        this.ResultBox.SelectionStart = this.ResultBox.Text.Length;
                    }
                }
                if (Typed == (char)ENTER)
                {
                    Calculate();
                }
            }
            else
            {
                switch(Typed)
                {
                    case '+':
                        operationCode = 1;
                        SaveFirstNumber();
                        break;
                    case '-':
                        operationCode = 2;
                        SaveFirstNumber();
                        break;
                    case '*':
                        operationCode = 3;
                        SaveFirstNumber();
                        break;
                    case '/':
                        SaveFirstNumber();
                        operationCode = 4;
                        break;
                    case '=':
                        Calculate();
                        break;
                }
            }

        }

        private void ResultBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void Add()
        {
            if (Double.TryParse(this.ResultBox.Text, out b))
            {
                a += b;
                this.ResultBox.Text = a.ToString();
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }
        private void Subtract()
        {
            if (Double.TryParse(this.ResultBox.Text, out b))
            {
                a -= b;
                this.ResultBox.Text = a.ToString();
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }
        private void Multiplicate()
        {
            if (Double.TryParse(this.ResultBox.Text, out b))
            {
                a *= b;
                this.ResultBox.Text = a.ToString();
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }
        private void Divide()
        {
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
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }
        private void Calculate()
        {
            switch (operationCode)
            {
                // Dodawanie
                case 1:
                    Add();
                    break;
                // Odejmowanie
                case 2:
                    Subtract();
                    break;
                // Mnożenie
                case 3:
                    Multiplicate();
                    break;
                // Dzielenie
                case 4:
                    Divide();
                    break;
            }
            resultCalculated = true;
        }
        private void SaveFirstNumber()
        {
            if (Double.TryParse(this.ResultBox.Text, out a))
            {
                this.ResultBox.Text = "0";
            }
            else
            {
                this.ResultBox.Text = "Liczba została źle wpisana!";
            }
        }

        private void darkOrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = Color.FromArgb(40, 40, 40);
            this.button0.ForeColor = Color.White;
            this.button1.BackColor = Color.FromArgb(40, 40, 40);
            this.button1.ForeColor = Color.White;
            this.button2.BackColor = Color.FromArgb(40, 40, 40);
            this.button2.ForeColor = Color.White;
            this.button3.BackColor = Color.FromArgb(40, 40, 40);
            this.button3.ForeColor = Color.White;
            this.button4.BackColor = Color.FromArgb(40, 40, 40);
            this.button4.ForeColor = Color.White;
            this.button5.BackColor = Color.FromArgb(40, 40, 40);
            this.button5.ForeColor = Color.White;
            this.button6.BackColor = Color.FromArgb(40, 40, 40);
            this.button6.ForeColor = Color.White;
            this.button7.BackColor = Color.FromArgb(40, 40, 40);
            this.button7.ForeColor = Color.White;
            this.button8.BackColor = Color.FromArgb(40, 40, 40);
            this.button8.ForeColor = Color.White;
            this.button9.BackColor = Color.FromArgb(40, 40, 40);
            this.button9.ForeColor = Color.White;
            this.buttonPoint.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonPoint.ForeColor = Color.White;
            this.buttonMmin.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMmin.ForeColor = Color.White;
            this.buttonMplus.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMplus.ForeColor = Color.White;
            this.buttonMS.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMS.ForeColor = Color.White;
            this.buttonMR.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMR.ForeColor = Color.White;
            this.buttonMC.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMC.ForeColor = Color.White;
            this.buttonSQRT.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonSQRT.ForeColor = Color.White;
            this.buttonPM.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonPM.ForeColor = Color.White;
            this.buttonC.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonC.ForeColor = Color.White;
            this.buttonCE.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonCE.ForeColor = Color.White;
            this.buttonRET.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonRET.ForeColor = Color.White;
            this.buttonRESULT.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonRESULT.ForeColor = Color.White;
            this.buttonPLUS.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonPLUS.ForeColor = Color.White;
            this.buttonMINUS.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMINUS.ForeColor = Color.White;
            this.buttonMUL.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonMUL.ForeColor = Color.White;
            this.buttonDIV.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonDIV.ForeColor = Color.White;
            this.buttonINV.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonINV.ForeColor = Color.White;
            this.buttonPERCENT.BackColor = Color.FromArgb(40, 40, 40);
            this.buttonPERCENT.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(0, 0, 34);
            this.panel1.BackColor = Color.FromArgb(0, 0, 34);
            this.panel2.BackColor = Color.FromArgb(0, 0, 70);
            this.panel3.BackColor = Color.FromArgb(0, 0, 70);
            this.numericPanel.BackColor = Color.FromArgb(0, 0, 70);
            this.ResultBox.BackColor = Color.DarkGray;
            this.ResultBox.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.seconds++;
            if (this.seconds == 60)
            {
                this.minutes++;
                this.seconds = 0;
            }
            String secs;
            String mins;
            if (this.seconds < 10)
            {
                secs = ":0" + this.seconds.ToString();
            }
            else
            {
                secs = ":" + this.seconds.ToString();
            }
            if (this.minutes < 10)
            {
                mins = "0" + this.minutes.ToString();
            }
            else
            {
                mins = this.minutes.ToString();
            }
            this.timelabel.Text = mins + secs;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = Color. FromArgb(182, 1, 12);
            this.button0.ForeColor = Color.FromArgb(227, 227, 227);
            this.button1.BackColor = Color. FromArgb(182, 1, 12);
            this.button1.ForeColor = Color.FromArgb(227, 227, 227);
            this.button2.BackColor = Color. FromArgb(182, 1, 12);
            this.button2.ForeColor = Color.FromArgb(227, 227, 227);
            this.button3.BackColor = Color. FromArgb(182, 1, 12);
            this.button3.ForeColor = Color.FromArgb(227, 227, 227);
            this.button4.BackColor = Color. FromArgb(182, 1, 12);
            this.button4.ForeColor = Color.FromArgb(227, 227, 227);
            this.button5.BackColor = Color. FromArgb(182, 1, 12);
            this.button5.ForeColor = Color.FromArgb(227, 227, 227);
            this.button6.BackColor = Color. FromArgb(182, 1, 12);
            this.button6.ForeColor = Color.FromArgb(227, 227, 227);
            this.button7.BackColor = Color. FromArgb(182, 1, 12);
            this.button7.ForeColor = Color.FromArgb(227, 227, 227);
            this.button8.BackColor = Color. FromArgb(182, 1, 12);
            this.button8.ForeColor = Color.FromArgb(227, 227, 227);
            this.button9.BackColor = Color. FromArgb(182, 1, 12);
            this.button9.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonPoint.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonPoint.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMmin.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMmin.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMplus.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMplus.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMS.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMS.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMR.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMR.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMC.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMC.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonSQRT.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonSQRT.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonPM.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonPM.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonC.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonC.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonCE.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonCE.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonRET.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonRET.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonRESULT.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonRESULT.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonPLUS.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonPLUS.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMINUS.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMINUS.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonMUL.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonMUL.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonDIV.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonDIV.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonINV.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonINV.ForeColor = Color.FromArgb(227, 227, 227);
            this.buttonPERCENT.BackColor = Color. FromArgb(182, 1, 12);
            this.buttonPERCENT.ForeColor = Color.FromArgb(227, 227, 227);
            this.BackColor = Color.FromArgb(38, 38, 38);
            this.panel1.BackColor = Color.FromArgb(38, 38, 38);
            this.panel2.BackColor = Color.FromArgb(38, 38, 38);
            this.panel3.BackColor = Color.FromArgb(38, 38, 38);
            this.numericPanel.BackColor = Color.FromArgb(38, 38, 38);
            this.ResultBox.BackColor = Color.FromArgb(227, 227, 227);
            this.ResultBox.ForeColor = Color.Black;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button0.BackColor = Color.FromArgb(227, 227, 227);
            this.button0.ForeColor = Color.Black;
            this.button1.BackColor = Color.FromArgb(227, 227, 227);
            this.button1.ForeColor = Color.Black;
            this.button2.BackColor = Color.FromArgb(227, 227, 227);
            this.button2.ForeColor = Color.Black;
            this.button3.BackColor = Color.FromArgb(227, 227, 227);
            this.button3.ForeColor = Color.Black;
            this.button4.BackColor = Color.FromArgb(227, 227, 227);
            this.button4.ForeColor = Color.Black;
            this.button5.BackColor = Color.FromArgb(227, 227, 227);
            this.button5.ForeColor = Color.Black;
            this.button6.BackColor = Color.FromArgb(227, 227, 227);
            this.button6.ForeColor = Color.Black;
            this.button7.BackColor = Color.FromArgb(227, 227, 227);
            this.button7.ForeColor = Color.Black;
            this.button8.BackColor = Color.FromArgb(227, 227, 227);
            this.button8.ForeColor = Color.Black;
            this.button9.BackColor = Color.FromArgb(227, 227, 227);
            this.button9.ForeColor = Color.Black;
            this.buttonPoint.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonPoint.ForeColor = Color.Black;
            this.buttonMmin.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMmin.ForeColor = Color.Black;
            this.buttonMplus.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMplus.ForeColor = Color.Black;
            this.buttonMS.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMS.ForeColor = Color.Black;
            this.buttonMR.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMR.ForeColor = Color.Black;
            this.buttonMC.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMC.ForeColor = Color.Black;
            this.buttonSQRT.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonSQRT.ForeColor = Color.Black;
            this.buttonPM.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonPM.ForeColor = Color.Black;
            this.buttonC.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonC.ForeColor = Color.Black;
            this.buttonCE.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonCE.ForeColor = Color.Black;
            this.buttonRET.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonRET.ForeColor = Color.Black;
            this.buttonRESULT.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonRESULT.ForeColor = Color.Black;
            this.buttonPLUS.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonPLUS.ForeColor = Color.Black;
            this.buttonMINUS.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMINUS.ForeColor = Color.Black;
            this.buttonMUL.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonMUL.ForeColor = Color.Black;
            this.buttonDIV.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonDIV.ForeColor = Color.Black;
            this.buttonINV.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonINV.ForeColor = Color.Black;
            this.buttonPERCENT.BackColor = Color.FromArgb(227, 227, 227);
            this.buttonPERCENT.ForeColor = Color.Black;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.panel1.BackColor = Color.FromArgb(240, 240, 240);
            this.panel2.BackColor = Color.FromArgb(227, 227, 227);
            this.panel3.BackColor = Color.FromArgb(227, 227, 227);
            this.numericPanel.BackColor = Color.FromArgb(227, 227, 227);
            this.ResultBox.BackColor = Color.White;
            this.ResultBox.ForeColor = Color.Black;
        }
    }
}

