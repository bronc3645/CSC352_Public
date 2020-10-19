using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator.logic;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"Recieved {e.KeyData}");

            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    {
                        button10_Click(sender, e);
                        break;
                    }
                case Keys.D1:
                case Keys.NumPad1:
                    {
                        button1_Click(sender, e);
                        break;
                    }
                case Keys.D2:
                case Keys.NumPad2:
                    {
                        button2_Click(sender, e);
                        break;
                    }
                case Keys.D3:
                case Keys.NumPad3:
                    {
                        button3_Click(sender, e);
                        break;
                    }
                case Keys.D4:
                case Keys.NumPad4:
                    {
                        button4_Click(sender, e);
                        break;
                    }
                case Keys.D5:
                case Keys.NumPad5:
                    {
                        button5_Click(sender, e);
                        break;
                    }
                case Keys.D6:
                case Keys.NumPad6:
                    {
                        button6_Click(sender, e);
                        break;
                    }
                case Keys.D7:
                case Keys.NumPad7:
                    {
                        button7_Click(sender, e);
                        break;
                    }
                case Keys.D8:
                    {
                        if (e.Shift)
                        {
                            button13_Click(sender, e);
                        }
                        else
                        {
                            button8_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad8:
                    {
                        button8_Click(sender, e);
                        break;
                    }
                case Keys.D9:
                case Keys.NumPad9:
                    {
                        button9_Click(sender, e);
                        break;
                    }
                case Keys.Subtract:
                case Keys.OemMinus:
                    {
                        button12_Click(sender, e);
                        break;
                    }
                case Keys.Multiply:
                    {
                        button13_Click(sender, e);
                        break;
                    }
                case Keys.Oemplus:
                    {
                        if (e.Shift)
                        {
                            add_Click(sender, e);
                        }
                        else
                        {
                            evaluate_Click(sender, e);
                        }
                        break;
                    }
                case Keys.Add:
                    {
                        add_Click(sender, e);
                        break;
                    }
                case Keys.Delete:
                    {
                        clear_Click(sender, e);
                        break;
                    }
                case Keys.Back:
                    {
                        delete_Click(sender, e);
                        break;
                    }
                case Keys.Return:
                    {
                        evaluate_Click(sender, e);
                        e.Handled = true;
                        break;
                    }
                case Keys.Divide:
                    {
                        button14_Click(sender, e);
                        break;
                    }
                case Keys.Decimal:
                    {
                        button16_Click(sender, e);
                        break;
                    }
                default:
                    {
                        //throw new NotImplementedException();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 5;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength != 0)
            {
                if (textBox1.Text.LastIndexOf(" ") != -1)
                {
                    if (!textBox1.Text.Substring(textBox1.Text.LastIndexOf(" ")).Contains("."))
                    {
                        this.textBox1.Text += ".";
                    }
                }
                else if (!textBox1.Text.Contains("."))
                {
                    this.textBox1.Text += ".";
                }
            }
            else
            {
                this.textBox1.Text += "0.";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    textBox1.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    textBox1.Text += " + ";
                }
            }
            else if (this.textBox1.Text.LastIndexOf(" ") == this.textBox1.Text.Length - 1)
            {
                this.textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                this.textBox1.Text += " + ";
            }
            else
            {
                textBox1.Text += " + ";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    textBox1.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    textBox1.Text += " - ";
                }
            }
            else if (this.textBox1.Text.LastIndexOf(" ") == this.textBox1.Text.Length-1)
            {
                this.textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                this.textBox1.Text += " - ";
            }
            else
            {
                textBox1.Text += " - ";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    textBox1.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    textBox1.Text += " * ";
                }
            }
            else if (this.textBox1.Text.LastIndexOf(" ") == this.textBox1.Text.Length-1)
            {
                this.textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                this.textBox1.Text += " * ";
            }
            else
            {
                textBox1.Text += " * ";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    textBox1.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    textBox1.Text += " / ";
                }
            }
            else if (this.textBox1.Text.LastIndexOf(" ") == this.textBox1.Text.Length-1)
            {
                this.textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                this.textBox1.Text += " / ";
            }
            else
            {
                textBox1.Text += " / ";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        

        private void evaluate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text.LastIndexOf(" ") != textBox1.Text.Length - 1)
                {
                    string rpn = Parser.ConvertTorpm(textBox1.Text);
                    history.Text = (textBox1.Text + Environment.NewLine + history.Text);
                    history.Text = (Evaluator.Eval(rpn) + Environment.NewLine + history.Text);
                    textBox1.Text = string.Empty;
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == ' ')
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    textBox1.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    textBox1.Text += " ^ ";
                }
            }
            else if (this.textBox1.Text.LastIndexOf(" ") == this.textBox1.Text.Length - 1)
            {
                this.textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                this.textBox1.Text += " ^ ";
            }
            else
            {
                textBox1.Text += " ^ ";
            }
        }
    }
}
