namespace Assignment5._1
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
            this.CalcBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.CalcDisplay = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.CalcBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcBox
            // 
            this.CalcBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CalcBox.Controls.Add(this.clearButton);
            this.CalcBox.Controls.Add(this.CalcDisplay);
            this.CalcBox.Controls.Add(this.btn7);
            this.CalcBox.Controls.Add(this.btn8);
            this.CalcBox.Controls.Add(this.btn9);
            this.CalcBox.Controls.Add(this.divideButton);
            this.CalcBox.Controls.Add(this.multiplyButton);
            this.CalcBox.Controls.Add(this.btn6);
            this.CalcBox.Controls.Add(this.btn5);
            this.CalcBox.Controls.Add(this.btn4);
            this.CalcBox.Controls.Add(this.subtractButton);
            this.CalcBox.Controls.Add(this.btn3);
            this.CalcBox.Controls.Add(this.btn2);
            this.CalcBox.Controls.Add(this.btn1);
            this.CalcBox.Controls.Add(this.plusButton);
            this.CalcBox.Controls.Add(this.decimalButton);
            this.CalcBox.Controls.Add(this.btn0);
            this.CalcBox.Controls.Add(this.equalButton);
            this.CalcBox.Location = new System.Drawing.Point(280, 111);
            this.CalcBox.Name = "CalcBox";
            this.CalcBox.Size = new System.Drawing.Size(205, 261);
            this.CalcBox.TabIndex = 0;
            this.CalcBox.TabStop = false;
            this.CalcBox.Text = "CalcBox";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(6, 58);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(193, 21);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "clear it!";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CalcDisplay
            // 
            this.CalcDisplay.Location = new System.Drawing.Point(7, 19);
            this.CalcDisplay.Multiline = true;
            this.CalcDisplay.Name = "CalcDisplay";
            this.CalcDisplay.Size = new System.Drawing.Size(193, 33);
            this.CalcDisplay.TabIndex = 2;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(6, 85);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 38);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click_1);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(56, 85);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 38);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click_1);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(106, 85);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 38);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click_1);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.divideButton.Location = new System.Drawing.Point(155, 85);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(44, 38);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.multiplyButton.Location = new System.Drawing.Point(155, 129);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(44, 38);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(106, 129);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 38);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click_1);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(56, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(44, 38);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click_1);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(6, 129);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(44, 38);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click_1);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.subtractButton.Location = new System.Drawing.Point(155, 173);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(44, 38);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(106, 173);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 38);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(56, 173);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 38);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(6, 173);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 38);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.plusButton.Location = new System.Drawing.Point(156, 217);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(44, 38);
            this.plusButton.TabIndex = 5;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.decimalButton.Location = new System.Drawing.Point(106, 217);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(44, 38);
            this.decimalButton.TabIndex = 4;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click_1);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(56, 217);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 38);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click_1);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.equalButton.Location = new System.Drawing.Point(6, 217);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(44, 38);
            this.equalButton.TabIndex = 2;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(819, 533);
            this.Controls.Add(this.CalcBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CalcBox.ResumeLayout(false);
            this.CalcBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CalcBox;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox CalcDisplay;
    }



}