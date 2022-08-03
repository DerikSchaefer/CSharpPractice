namespace Assignment4._3
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
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentAdmission = new System.Windows.Forms.Label();
            this.StudentGrade = new System.Windows.Forms.Label();
            this.StudentAddress = new System.Windows.Forms.Label();
            this.StudentLName = new System.Windows.Forms.Label();
            this.StudentFName = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.Label();
            this.BoxMonth = new System.Windows.Forms.ComboBox();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textGrade = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGrid
            // 
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Location = new System.Drawing.Point(273, 47);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(497, 243);
            this.StudentGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.StudentAdmission);
            this.groupBox1.Controls.Add(this.StudentGrade);
            this.groupBox1.Controls.Add(this.StudentAddress);
            this.groupBox1.Controls.Add(this.StudentLName);
            this.groupBox1.Controls.Add(this.StudentFName);
            this.groupBox1.Controls.Add(this.studentID);
            this.groupBox1.Controls.Add(this.BoxMonth);
            this.groupBox1.Controls.Add(this.textFName);
            this.groupBox1.Controls.Add(this.textLName);
            this.groupBox1.Controls.Add(this.textAddress);
            this.groupBox1.Controls.Add(this.textGrade);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(273, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(6, 214);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(90, 23);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(6, 74);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(101, 23);
            this.BtnDel.TabIndex = 14;
            this.BtnDel.Text = "Delete Student";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentAdmission
            // 
            this.StudentAdmission.AutoSize = true;
            this.StudentAdmission.Location = new System.Drawing.Point(232, 152);
            this.StudentAdmission.Name = "StudentAdmission";
            this.StudentAdmission.Size = new System.Drawing.Size(121, 13);
            this.StudentAdmission.TabIndex = 12;
            this.StudentAdmission.Text = "Month of Admission:";
            // 
            // StudentGrade
            // 
            this.StudentGrade.AutoSize = true;
            this.StudentGrade.Location = new System.Drawing.Point(232, 126);
            this.StudentGrade.Name = "StudentGrade";
            this.StudentGrade.Size = new System.Drawing.Size(93, 13);
            this.StudentGrade.TabIndex = 11;
            this.StudentGrade.Text = "Student Grade:";
            // 
            // StudentAddress
            // 
            this.StudentAddress.AutoSize = true;
            this.StudentAddress.Location = new System.Drawing.Point(232, 100);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(104, 13);
            this.StudentAddress.TabIndex = 10;
            this.StudentAddress.Text = "Student Address:";
            // 
            // StudentLName
            // 
            this.StudentLName.AutoSize = true;
            this.StudentLName.Location = new System.Drawing.Point(232, 74);
            this.StudentLName.Name = "StudentLName";
            this.StudentLName.Size = new System.Drawing.Size(119, 13);
            this.StudentLName.TabIndex = 9;
            this.StudentLName.Text = "Student Last Name:";
            // 
            // StudentFName
            // 
            this.StudentFName.AutoSize = true;
            this.StudentFName.Location = new System.Drawing.Point(232, 48);
            this.StudentFName.Name = "StudentFName";
            this.StudentFName.Size = new System.Drawing.Size(119, 13);
            this.StudentFName.TabIndex = 8;
            this.StudentFName.Text = "Student First Name:";
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Location = new System.Drawing.Point(232, 22);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(72, 13);
            this.studentID.TabIndex = 7;
            this.studentID.Text = "Student ID:";
            // 
            // BoxMonth
            // 
            this.BoxMonth.FormattingEnabled = true;
            this.BoxMonth.Location = new System.Drawing.Point(370, 149);
            this.BoxMonth.Name = "BoxMonth";
            this.BoxMonth.Size = new System.Drawing.Size(121, 21);
            this.BoxMonth.TabIndex = 6;
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(391, 45);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(100, 20);
            this.textFName.TabIndex = 2;
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(391, 71);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(100, 20);
            this.textLName.TabIndex = 3;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(391, 97);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 4;
            // 
            // textGrade
            // 
            this.textGrade.Location = new System.Drawing.Point(391, 123);
            this.textGrade.Name = "textGrade";
            this.textGrade.Size = new System.Drawing.Size(100, 20);
            this.textGrade.TabIndex = 5;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(391, 19);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudentGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StudentAdmission;
        private System.Windows.Forms.Label StudentGrade;
        private System.Windows.Forms.Label StudentAddress;
        private System.Windows.Forms.Label StudentLName;
        private System.Windows.Forms.Label StudentFName;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.ComboBox BoxMonth;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textGrade;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button button1;
    }
}

