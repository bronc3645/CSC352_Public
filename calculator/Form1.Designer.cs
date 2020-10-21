namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.currentcal = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.posNeg = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.TextBox();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.parenth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(148, 319);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 40);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(240, 319);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 40);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(332, 319);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 40);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(148, 380);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 43);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(240, 380);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 44);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(332, 380);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 44);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(148, 441);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 42);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(240, 440);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 43);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(332, 440);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 43);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // currentcal
            // 
            this.currentcal.Location = new System.Drawing.Point(92, 119);
            this.currentcal.Name = "currentcal";
            this.currentcal.ReadOnly = true;
            this.currentcal.Size = new System.Drawing.Size(450, 22);
            this.currentcal.TabIndex = 9;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(240, 489);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 58);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(437, 373);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 59);
            this.add.TabIndex = 11;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(332, 255);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 43);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(240, 255);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 43);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(148, 255);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 43);
            this.clear.TabIndex = 15;
            this.clear.Text = "c";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(332, 489);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(75, 58);
            this.dec.TabIndex = 16;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // posNeg
            // 
            this.posNeg.Location = new System.Drawing.Point(148, 489);
            this.posNeg.Name = "posNeg";
            this.posNeg.Size = new System.Drawing.Size(75, 58);
            this.posNeg.TabIndex = 17;
            this.posNeg.Text = "+/-";
            this.posNeg.UseVisualStyleBackColor = true;
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(437, 440);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(84, 107);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.evaluate_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(437, 319);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(84, 40);
            this.minus.TabIndex = 19;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(437, 255);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 43);
            this.delete.TabIndex = 20;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exponent
            // 
            this.exponent.Location = new System.Drawing.Point(49, 188);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(75, 43);
            this.exponent.TabIndex = 21;
            this.exponent.Text = "^";
            this.exponent.UseVisualStyleBackColor = true;
            this.exponent.Click += new System.EventHandler(this.exponent_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(148, 188);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 43);
            this.sin.TabIndex = 22;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(92, 23);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(450, 78);
            this.history.TabIndex = 23;
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(240, 188);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 43);
            this.cos.TabIndex = 24;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(332, 188);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 43);
            this.tan.TabIndex = 25;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            // 
            // parenth
            // 
            this.parenth.Location = new System.Drawing.Point(437, 188);
            this.parenth.Name = "parenth";
            this.parenth.Size = new System.Drawing.Size(75, 43);
            this.parenth.TabIndex = 26;
            this.parenth.Text = "( )";
            this.parenth.UseVisualStyleBackColor = true;
            this.parenth.Click += new System.EventHandler(this.parenth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 620);
            this.Controls.Add(this.parenth);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.history);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.posNeg);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.add);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.currentcal);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "calculator";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.TextBox currentcal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button posNeg;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button parenth;
    }
}

