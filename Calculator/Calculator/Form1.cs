using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double answer = 0;

        public static string prevEquation = "", prevOperation = "", operation = "";

        private void ALLBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnDelete":
                    if (textDisplay2.Text.Length > 0)
                    {
                        textDisplay2.Text = textDisplay2.Text.Substring(0, textDisplay2.Text.Length - 1);
                    }
                    break;
                case "btnClear":
                    operation = "";
                    textDisplay2.ResetText();
                    textDisplay1.ResetText();
                    break;
                case "btnClearEntry":
                    textDisplay2.ResetText();
                    break;
                case "btnDecimal":
                    if (!textDisplay2.Text.Contains("."))
                    {
                        textDisplay2.Text += ".";
                    }
                    break;
                case "btnPlusMinus":
                    if (textDisplay2.Text.Length>0)
                    {
                        if (!textDisplay2.Text.Contains("-"))
                        {
                            textDisplay2.Text = "-" + textDisplay2.Text;
                        }
                        else if (textDisplay2.Text.Contains("-"))
                        {
                            textDisplay2.Text = textDisplay2.Text.Substring(1, textDisplay2.Text.Length - 1);
                        }
                    }
                    break;
                default:
                    if(operation == "=")
                    {
                        operation = "";
                        textDisplay2.ResetText();
                    }
                    textDisplay2.Text += btn.Text;
                    break;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button opr = sender as Button;

            switch (opr.Text)
            {
                case "+":
                    if (textDisplay2.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "+";
                            prevOperation = operation;
                            prevEquation = textDisplay2.Text;
                            textDisplay1.Text = prevEquation + operation;
                            textDisplay2.ResetText();
                        }
                    }
                    else
                    {
                        operation = "+";
                        multi_equation();
                    }
                    break;
                case "-":
                    if (textDisplay2.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "-";
                            prevOperation = operation;
                            prevEquation = textDisplay2.Text;
                            textDisplay1.Text = prevEquation + operation;
                            textDisplay2.ResetText();
                        }
                    }
                    else
                    {
                        operation = "+";
                        multi_equation();
                    }
                    break;
                case "/":
                    if (textDisplay2.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "/";
                            prevOperation = operation;
                            prevEquation = textDisplay2.Text;
                            textDisplay1.Text = prevEquation + operation;
                            textDisplay2.ResetText();
                        }
                    }
                    else
                    {
                        operation = "/";
                        multi_equation();
                    }
                    break;
                case "x":
                    if (textDisplay2.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "x";
                            prevOperation = operation;
                            prevEquation = textDisplay2.Text;
                            textDisplay1.Text = prevEquation + operation;
                            textDisplay2.ResetText();
                        }
                    }
                    else
                    {
                        operation = "x";
                        multi_equation();
                    }
                    break;
                case "=":
                    if (textDisplay2.Text.Length > 0)
                    {
                        operation = "=";
                        multi_equation();
                        textDisplay1.ResetText();
                        textDisplay2.Text = answer.ToString();
                    }
                    break;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void multi_equation()
        {
            if(prevOperation == "+")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) + Convert.ToDouble(textDisplay2.Text);

                prevEquation = answer.ToString();
                textDisplay1.Text = prevEquation + operation;
                textDisplay2.ResetText();
            }
            else if(prevOperation == "-")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) - Convert.ToDouble(textDisplay2.Text);

                prevEquation = answer.ToString();
                textDisplay1.Text = prevEquation + operation;
                textDisplay2.ResetText();
            }
            else if (prevOperation == "/")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) / Convert.ToDouble(textDisplay2.Text);

                prevEquation = answer.ToString();
                textDisplay1.Text = prevEquation + operation;
                textDisplay2.ResetText();
            }
            else if (prevOperation == "x")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) * Convert.ToDouble(textDisplay2.Text);

                prevEquation = answer.ToString();
                textDisplay1.Text = prevEquation + operation;
                textDisplay2.ResetText();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
