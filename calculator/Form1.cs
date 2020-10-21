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
        static int parenthesies = 0;
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
                    {
                        if (e.Shift)
                        {
                            closeParenth(sender, e);
                        }
                        else
                        {
                            Zero_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad0:
                    {
                        Zero_Click(sender, e);
                        break;
                    }
                case Keys.D1:
                case Keys.NumPad1:
                    {
                        One_Click(sender, e);
                        break;
                    }
                case Keys.D2:
                case Keys.NumPad2:
                    {
                        Two_Click(sender, e);
                        break;
                    }
                case Keys.D3:
                case Keys.NumPad3:
                    {
                        Three_Click(sender, e);
                        break;
                    }
                case Keys.D4:
                case Keys.NumPad4:
                    {
                        Four_Click(sender, e);
                        break;
                    }
                case Keys.D5:
                case Keys.NumPad5:
                    {
                        Five_Click(sender, e);
                        break;
                    }
                case Keys.D6:
                case Keys.NumPad6:
                    {
                        Six_Click(sender, e);
                        break;
                    }
                case Keys.D7:
                case Keys.NumPad7:
                    {
                        Seven_Click(sender, e);
                        break;
                    }
                case Keys.D8:
                    {
                        if (e.Shift)
                        {
                            Multiply_Click(sender, e);
                        }
                        else
                        {
                            Eight_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad8:
                    {
                        Eight_Click(sender, e);
                        break;
                    }
                case Keys.D9:
                    {
                        if (e.Shift)
                        {
                            openParenth(sender, e);
                        }
                        else
                        {
                            Nine_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad9:
                    {
                        Nine_Click(sender, e);
                        break;
                    }
                case Keys.Subtract:
                case Keys.OemMinus:
                    {
                        Minus_Click(sender, e);
                        break;
                    }
                case Keys.Multiply:
                    {
                        Multiply_Click(sender, e);
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
                        Divide_Click(sender, e);
                        break;
                    }
                case Keys.Decimal:
                    {
                        Decimal_Click(sender, e);
                        break;
                    }
                default:
                    {
                        //throw new NotImplementedException();
                        break;
                    }
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 5;
        }
        
        private void Six_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 9;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.currentcal.Text += 0;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (this.currentcal.TextLength != 0)
            {
                if (currentcal.Text.LastIndexOf(" ") != -1)
                {
                    if (!currentcal.Text.Substring(currentcal.Text.LastIndexOf(" ")).Contains("."))
                    {
                        this.currentcal.Text += ".";
                    }
                }
                else if (!currentcal.Text.Contains("."))
                {
                    this.currentcal.Text += ".";
                }
            }
            else
            {
                this.currentcal.Text += "0.";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (this.currentcal.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    currentcal.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    currentcal.Text += " + ";
                }
            }
            else if (this.currentcal.Text.LastIndexOf(" ") == this.currentcal.Text.Length - 1)
            {
                if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == '(')
                {
                    Form1.parenthesies--;
                }
                else if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == ')')
                {
                    Form1.parenthesies++;
                }
                this.currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 3);
                this.currentcal.Text += " + ";
            }
            else
            {
                currentcal.Text += " + ";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (this.currentcal.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    currentcal.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    currentcal.Text += " - ";
                }
            }
            else if (this.currentcal.Text.LastIndexOf(" ") == this.currentcal.Text.Length-1)
            {
                if(this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == '(')
                {
                    Form1.parenthesies--;
                }
                else if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == ')')
                {
                    Form1.parenthesies++;
                }
                this.currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 3);
                this.currentcal.Text += " - ";
            }
            else
            {
                currentcal.Text += " - ";
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (this.currentcal.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    currentcal.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    currentcal.Text += " * ";
                }
            }
            else if (this.currentcal.Text.LastIndexOf(" ") == this.currentcal.Text.Length-1)
            {
                if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == '(')
                {
                    Form1.parenthesies--;
                }
                else if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == ')')
                {
                    Form1.parenthesies++;
                }
                this.currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 3);
                this.currentcal.Text += " * ";
            }
            else
            {
                currentcal.Text += " * ";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (this.currentcal.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    currentcal.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    currentcal.Text += " / ";
                }
            }
            else if (this.currentcal.Text.LastIndexOf(" ") == this.currentcal.Text.Length-1)
            {
                if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == '(')
                {
                    Form1.parenthesies--;
                }
                else if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == ')')
                {
                    Form1.parenthesies++;
                }
                this.currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 3);
                this.currentcal.Text += " / ";
            }
            else
            {
                currentcal.Text += " / ";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.currentcal.Text = string.Empty;
        }

        

        private void evaluate_Click(object sender, EventArgs e)
        {
            if (currentcal.Text.Length != 0)
            {
                if (currentcal.Text.LastIndexOf(" ") != currentcal.Text.Length - 1)
                {
                    string rpn = Parser.ConvertTorpm(currentcal.Text);
                    history.Text = (currentcal.Text + Environment.NewLine + history.Text);
                    history.Text = (Evaluator.Eval(rpn) + Environment.NewLine + history.Text);
                    currentcal.Text = string.Empty;
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (currentcal.Text.Length != 0)
            {
                if (currentcal.Text[currentcal.Text.Length - 1] == ' ')
                {
                    if (currentcal.Text[currentcal.Text.Length-2] == '(')
                    {
                        Form1.parenthesies--;
                    }
                    else if (currentcal.Text[currentcal.Text.Length - 2] == ')')
                    {
                        Form1.parenthesies++;
                    } 
                    currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 3);
                }
                else
                {
                    currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 1);
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
            if (this.currentcal.Text.Length == 0)
            {
                if (this.history.Text.Length != 0)
                {
                    currentcal.Text += history.Text.Substring(0, history.Text.IndexOf(Environment.NewLine));
                    currentcal.Text += " ^ ";
                }
            }
            else if (this.currentcal.Text.LastIndexOf(" ") == this.currentcal.Text.Length - 1)
            {
                if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == '(')
                {
                    Form1.parenthesies--;
                }
                else if (this.currentcal.Text[this.currentcal.Text.LastIndexOf(" ") - 1] == ')')
                {
                    Form1.parenthesies++;
                }
                this.currentcal.Text = currentcal.Text.Substring(0, currentcal.Text.Length - 3);
                this.currentcal.Text += " ^ ";
            }
            else
            {
                currentcal.Text += " ^ ";
            }
        }

        private void openParenth(object sender,EventArgs e)
        {
            this.currentcal.Text += " ( ";
            Form1.parenthesies++;
        }

        private void closeParenth(object sender, EventArgs e)
        {
            if(currentcal.Text.LastIndexOf(" ") != currentcal.Text.Length - 1)
            {
                this.currentcal.Text += " ) ";
                        Form1.parenthesies--;
            }
            
        }

        private void parenth_Click(object sender, EventArgs e)
        {
            if (this.currentcal.Text.Contains("(")&&Form1.parenthesies!=0)
            {
                if(this.currentcal.Text.LastIndexOf(" ") == this.currentcal.Text.Length - 1)
                {
                    this.currentcal.Text += " ( ";
                    Form1.parenthesies++;
                }
                else
                {
                    this.currentcal.Text += " ) ";
                    Form1.parenthesies--;
                }
            }
            else
            {
                this.currentcal.Text += " ( ";
                Form1.parenthesies++;
            }
        }
    }
}
