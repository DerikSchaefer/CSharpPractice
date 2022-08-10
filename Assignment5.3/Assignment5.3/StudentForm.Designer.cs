namespace Assignment5._3
{
    partial class StudentForm
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
            this.buttonGPA = new System.Windows.Forms.Button();
            this.AddOrRemovePeople = new System.Windows.Forms.GroupBox();
            this.TextGPA = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RemovePersonButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.TextID = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.AddOrRemovePeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGrid
            // 
            this.StudentGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Location = new System.Drawing.Point(12, 12);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(436, 320);
            this.StudentGrid.TabIndex = 0;
            // 
            // buttonGPA
            // 
            this.buttonGPA.Location = new System.Drawing.Point(28, 19);
            this.buttonGPA.Name = "buttonGPA";
            this.buttonGPA.Size = new System.Drawing.Size(144, 23);
            this.buttonGPA.TabIndex = 1;
            this.buttonGPA.Text = "GetHighest GPA";
            this.buttonGPA.UseVisualStyleBackColor = true;
            this.buttonGPA.Click += new System.EventHandler(this.buttonGPA_Click);
            // 
            // AddOrRemovePeople
            // 
            this.AddOrRemovePeople.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AddOrRemovePeople.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddOrRemovePeople.Controls.Add(this.buttonGPA);
            this.AddOrRemovePeople.Controls.Add(this.TextGPA);
            this.AddOrRemovePeople.Controls.Add(this.ExitButton);
            this.AddOrRemovePeople.Controls.Add(this.RemovePersonButton);
            this.AddOrRemovePeople.Controls.Add(this.AddPersonButton);
            this.AddOrRemovePeople.Controls.Add(this.TextID);
            this.AddOrRemovePeople.Controls.Add(this.TextName);
            this.AddOrRemovePeople.Controls.Add(this.label5);
            this.AddOrRemovePeople.Controls.Add(this.label2);
            this.AddOrRemovePeople.Controls.Add(this.label1);
            this.AddOrRemovePeople.Location = new System.Drawing.Point(454, 213);
            this.AddOrRemovePeople.Name = "AddOrRemovePeople";
            this.AddOrRemovePeople.Size = new System.Drawing.Size(344, 236);
            this.AddOrRemovePeople.TabIndex = 2;
            this.AddOrRemovePeople.TabStop = false;
            // 
            // TextGPA
            // 
            this.TextGPA.Location = new System.Drawing.Point(240, 81);
            this.TextGPA.Name = "TextGPA";
            this.TextGPA.Size = new System.Drawing.Size(100, 20);
            this.TextGPA.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(265, 207);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit Form";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // RemovePersonButton
            // 
            this.RemovePersonButton.Location = new System.Drawing.Point(143, 116);
            this.RemovePersonButton.Name = "RemovePersonButton";
            this.RemovePersonButton.Size = new System.Drawing.Size(109, 23);
            this.RemovePersonButton.TabIndex = 9;
            this.RemovePersonButton.Text = "Remove Student";
            this.RemovePersonButton.UseVisualStyleBackColor = true;
            this.RemovePersonButton.Click += new System.EventHandler(this.RemovePersonButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(28, 116);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(109, 23);
            this.AddPersonButton.TabIndex = 8;
            this.AddPersonButton.Text = "Add Student";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(134, 81);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(100, 20);
            this.TextID.TabIndex = 7;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(28, 81);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GPA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddOrRemovePeople);
            this.Controls.Add(this.StudentGrid);
            this.Name = "StudentForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.AddOrRemovePeople.ResumeLayout(false);
            this.AddOrRemovePeople.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.Button buttonGPA;
        private System.Windows.Forms.GroupBox AddOrRemovePeople;
        private System.Windows.Forms.TextBox TextGPA;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RemovePersonButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}