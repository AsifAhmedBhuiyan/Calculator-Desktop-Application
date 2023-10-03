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
            displayBox = new TextBox();
            buttonBinary = new Button();
            buttonHexa = new Button();
            buttonClear = new Button();
            buttonAllclear = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonAdd = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSubtract = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonMultiply = new Button();
            buttonZero = new Button();
            buttonDot = new Button();
            buttonEqual = new Button();
            buttonDivide = new Button();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.AccessibleDescription = "Displays all the operation";
            displayBox.AccessibleName = "Display Box";
            displayBox.Location = new Point(198, 31);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(360, 23);
            displayBox.TabIndex = 0;
            displayBox.TextChanged += displayBox_TextChanged;
            // 
            // buttonBinary
            // 
            buttonBinary.AccessibleDescription = "It converts binary";
            buttonBinary.AccessibleName = "Button Binary";
            buttonBinary.Location = new Point(198, 76);
            buttonBinary.Name = "buttonBinary";
            buttonBinary.Size = new Size(75, 23);
            buttonBinary.TabIndex = 1;
            buttonBinary.Text = "Binary";
            buttonBinary.UseVisualStyleBackColor = true;
            buttonBinary.Click += buttonBinary_Click;
            // 
            // buttonHexa
            // 
            buttonHexa.AccessibleDescription = "It converts digits to Hexa";
            buttonHexa.AccessibleName = "Button Hexa";
            buttonHexa.Location = new Point(294, 76);
            buttonHexa.Name = "buttonHexa";
            buttonHexa.Size = new Size(75, 23);
            buttonHexa.TabIndex = 2;
            buttonHexa.Text = "Hexa";
            buttonHexa.UseVisualStyleBackColor = true;
            buttonHexa.Click += buttonHexa_Click;
            // 
            // buttonClear
            // 
            buttonClear.AccessibleDescription = "It clears digit by digit";
            buttonClear.AccessibleName = "Button Clear";
            buttonClear.BackColor = Color.Red;
            buttonClear.ForeColor = SystemColors.ButtonHighlight;
            buttonClear.Location = new Point(389, 76);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAllclear
            // 
            buttonAllclear.AccessibleDescription = "Clears the whole display";
            buttonAllclear.AccessibleName = "Button Allclear";
            buttonAllclear.BackColor = Color.Red;
            buttonAllclear.ForeColor = SystemColors.ButtonFace;
            buttonAllclear.Location = new Point(483, 76);
            buttonAllclear.Name = "buttonAllclear";
            buttonAllclear.Size = new Size(75, 23);
            buttonAllclear.TabIndex = 4;
            buttonAllclear.Text = "AC";
            buttonAllclear.UseVisualStyleBackColor = false;
            buttonAllclear.Click += buttonAllclear_Click;
            // 
            // buttonOne
            // 
            buttonOne.AccessibleDescription = "Shows number One";
            buttonOne.AccessibleName = "Button One";
            buttonOne.Location = new Point(198, 119);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(75, 23);
            buttonOne.TabIndex = 5;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.AccessibleDescription = "Shows number two";
            buttonTwo.AccessibleName = "Button Two";
            buttonTwo.Location = new Point(294, 119);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(75, 23);
            buttonTwo.TabIndex = 6;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonThree
            // 
            buttonThree.AccessibleDescription = "Shows number three";
            buttonThree.AccessibleName = "Button Three";
            buttonThree.Location = new Point(389, 119);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(75, 23);
            buttonThree.TabIndex = 7;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.AccessibleDescription = "Addition operation";
            buttonAdd.AccessibleName = "Button Add";
            buttonAdd.BackColor = Color.Orange;
            buttonAdd.ForeColor = SystemColors.ButtonFace;
            buttonAdd.Location = new Point(483, 119);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonFour
            // 
            buttonFour.AccessibleDescription = "Shows number four";
            buttonFour.AccessibleName = "Button Four";
            buttonFour.Location = new Point(198, 161);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(75, 23);
            buttonFour.TabIndex = 9;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonFive
            // 
            buttonFive.AccessibleDescription = "Shows number five";
            buttonFive.AccessibleName = "Button Five";
            buttonFive.Location = new Point(294, 161);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(75, 23);
            buttonFive.TabIndex = 10;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonSix
            // 
            buttonSix.AccessibleDescription = "Shows number six";
            buttonSix.AccessibleName = "Button Six";
            buttonSix.Location = new Point(389, 161);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(75, 23);
            buttonSix.TabIndex = 11;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.AccessibleDescription = "Subtraction operation";
            buttonSubtract.AccessibleName = "Button Substract";
            buttonSubtract.BackColor = Color.Orange;
            buttonSubtract.ForeColor = SystemColors.ButtonFace;
            buttonSubtract.Location = new Point(483, 161);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 23);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.AccessibleDescription = "Shows number seven";
            buttonSeven.AccessibleName = "Button Seven";
            buttonSeven.Location = new Point(198, 202);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(75, 23);
            buttonSeven.TabIndex = 13;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonEight
            // 
            buttonEight.AccessibleDescription = "Shows number eight";
            buttonEight.AccessibleName = "Button Eight";
            buttonEight.Location = new Point(294, 202);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(75, 23);
            buttonEight.TabIndex = 14;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonNine
            // 
            buttonNine.AccessibleDescription = "Shows number nine";
            buttonNine.AccessibleName = "Button Nine";
            buttonNine.Location = new Point(389, 202);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(75, 23);
            buttonNine.TabIndex = 15;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.AccessibleDescription = "Multiplication operation";
            buttonMultiply.AccessibleName = "Button Multiply";
            buttonMultiply.BackColor = Color.Orange;
            buttonMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.ForeColor = SystemColors.ButtonFace;
            buttonMultiply.Location = new Point(483, 202);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 23);
            buttonMultiply.TabIndex = 16;
            buttonMultiply.Text = "X";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonZero
            // 
            buttonZero.AccessibleDescription = "Shows number zero";
            buttonZero.AccessibleName = "Button Zero";
            buttonZero.Location = new Point(198, 241);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(75, 23);
            buttonZero.TabIndex = 17;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonDot
            // 
            buttonDot.AccessibleDescription = "Shows dot ";
            buttonDot.AccessibleName = "Button Dot";
            buttonDot.Location = new Point(294, 241);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(75, 23);
            buttonDot.TabIndex = 18;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.AccessibleDescription = "Shows equal between number";
            buttonEqual.AccessibleName = "Button Equal";
            buttonEqual.Location = new Point(389, 241);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(75, 23);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.AccessibleDescription = "Division operation";
            buttonDivide.AccessibleName = "Button Divide ";
            buttonDivide.BackColor = Color.Orange;
            buttonDivide.ForeColor = SystemColors.ButtonFace;
            buttonDivide.Location = new Point(483, 241);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 23);
            buttonDivide.TabIndex = 20;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(730, 304);
            Controls.Add(buttonDivide);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDot);
            Controls.Add(buttonZero);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonAdd);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonAllclear);
            Controls.Add(buttonClear);
            Controls.Add(buttonHexa);
            Controls.Add(buttonBinary);
            Controls.Add(displayBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayBox;
        private Button buttonBinary;
        private Button buttonHexa;
        private Button buttonClear;
        private Button buttonAllclear;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonAdd;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSubtract;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonMultiply;
        private Button buttonZero;
        private Button buttonDot;
        private Button buttonEqual;
        private Button buttonDivide;
    }
}