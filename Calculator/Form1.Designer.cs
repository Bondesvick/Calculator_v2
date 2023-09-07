namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calcDisplay = new TextBox();
            ac_button = new Button();
            backspace = new Button();
            button3 = new Button();
            button4 = new Button();
            modulus = new Button();
            division = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            multiply = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            subract = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            add = new Button();
            button19 = new Button();
            zero = new Button();
            dot = new Button();
            equals = new Button();
            SuspendLayout();
            // 
            // calcDisplay
            // 
            calcDisplay.BackColor = Color.DarkSeaGreen;
            calcDisplay.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            calcDisplay.Location = new Point(12, 12);
            calcDisplay.MinimumSize = new Size(0, 50);
            calcDisplay.Name = "calcDisplay";
            calcDisplay.ReadOnly = true;
            calcDisplay.RightToLeft = RightToLeft.Yes;
            calcDisplay.Size = new Size(424, 50);
            calcDisplay.TabIndex = 0;
            // 
            // ac_button
            // 
            ac_button.Location = new Point(12, 90);
            ac_button.Name = "ac_button";
            ac_button.Size = new Size(96, 42);
            ac_button.TabIndex = 1;
            ac_button.Text = "AC";
            ac_button.UseVisualStyleBackColor = true;
            ac_button.Click += ac_button_Click;
            // 
            // backspace
            // 
            backspace.Location = new Point(114, 90);
            backspace.Name = "backspace";
            backspace.Size = new Size(96, 42);
            backspace.TabIndex = 1;
            backspace.Text = "<-";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // button3
            // 
            button3.Location = new Point(216, 90);
            button3.Name = "button3";
            button3.Size = new Size(96, 42);
            button3.TabIndex = 1;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(340, 90);
            button4.Name = "button4";
            button4.Size = new Size(96, 42);
            button4.TabIndex = 1;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // modulus
            // 
            modulus.Location = new Point(216, 90);
            modulus.Name = "modulus";
            modulus.Size = new Size(96, 42);
            modulus.TabIndex = 1;
            modulus.Text = "%";
            modulus.UseVisualStyleBackColor = true;
            modulus.Click += modulus_Click;
            // 
            // division
            // 
            division.Location = new Point(340, 90);
            division.Name = "division";
            division.Size = new Size(96, 42);
            division.TabIndex = 1;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += opperation_Click;
            // 
            // seven
            // 
            seven.Location = new Point(12, 138);
            seven.Name = "seven";
            seven.Size = new Size(96, 42);
            seven.TabIndex = 1;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += numButton_Click;
            // 
            // eight
            // 
            eight.Location = new Point(114, 138);
            eight.Name = "eight";
            eight.Size = new Size(96, 42);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += numButton_Click;
            // 
            // nine
            // 
            nine.Location = new Point(216, 138);
            nine.Name = "nine";
            nine.Size = new Size(96, 42);
            nine.TabIndex = 1;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += numButton_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(340, 138);
            multiply.Name = "multiply";
            multiply.Size = new Size(96, 42);
            multiply.TabIndex = 1;
            multiply.Text = "X";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += opperation_Click;
            // 
            // four
            // 
            four.Location = new Point(12, 186);
            four.Name = "four";
            four.Size = new Size(96, 42);
            four.TabIndex = 1;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += numButton_Click;
            // 
            // five
            // 
            five.Location = new Point(114, 186);
            five.Name = "five";
            five.Size = new Size(96, 42);
            five.TabIndex = 1;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += numButton_Click;
            // 
            // six
            // 
            six.Location = new Point(216, 186);
            six.Name = "six";
            six.Size = new Size(96, 42);
            six.TabIndex = 1;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += numButton_Click;
            // 
            // subract
            // 
            subract.Location = new Point(340, 186);
            subract.Name = "subract";
            subract.Size = new Size(96, 42);
            subract.TabIndex = 1;
            subract.Text = "-";
            subract.UseVisualStyleBackColor = true;
            subract.Click += opperation_Click;
            // 
            // one
            // 
            one.Location = new Point(12, 234);
            one.Name = "one";
            one.Size = new Size(96, 42);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += numButton_Click;
            // 
            // two
            // 
            two.Location = new Point(114, 234);
            two.Name = "two";
            two.Size = new Size(96, 42);
            two.TabIndex = 1;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += numButton_Click;
            // 
            // three
            // 
            three.Location = new Point(216, 234);
            three.Name = "three";
            three.Size = new Size(96, 42);
            three.TabIndex = 1;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += numButton_Click;
            // 
            // add
            // 
            add.Location = new Point(340, 234);
            add.Name = "add";
            add.Size = new Size(96, 42);
            add.TabIndex = 1;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += opperation_Click;
            // 
            // button19
            // 
            button19.Location = new Point(12, 282);
            button19.Name = "button19";
            button19.Size = new Size(96, 42);
            button19.TabIndex = 1;
            button19.Text = "button1";
            button19.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            zero.Location = new Point(114, 282);
            zero.Name = "zero";
            zero.Size = new Size(96, 42);
            zero.TabIndex = 1;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += numButton_Click;
            // 
            // dot
            // 
            dot.Location = new Point(216, 282);
            dot.Name = "dot";
            dot.Size = new Size(96, 42);
            dot.TabIndex = 1;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // equals
            // 
            equals.Location = new Point(340, 282);
            equals.Name = "equals";
            equals.Size = new Size(96, 42);
            equals.TabIndex = 1;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 348);
            Controls.Add(equals);
            Controls.Add(add);
            Controls.Add(subract);
            Controls.Add(multiply);
            Controls.Add(division);
            Controls.Add(dot);
            Controls.Add(three);
            Controls.Add(six);
            Controls.Add(nine);
            Controls.Add(modulus);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(zero);
            Controls.Add(button19);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(backspace);
            Controls.Add(ac_button);
            Controls.Add(calcDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calcDisplay;
        private Button ac_button;
        private Button backspace;
        private Button button3;
        private Button button4;
        private Button modulus;
        private Button division;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button multiply;
        private Button four;
        private Button five;
        private Button six;
        private Button subract;
        private Button one;
        private Button two;
        private Button three;
        private Button add;
        private Button button19;
        private Button zero;
        private Button dot;
        private Button equals;
    }
}