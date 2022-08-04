namespace Assignent4._4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BeverageGrid = new System.Windows.Forms.DataGridView();
            this.AddOrRemoveBeverages = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextPrice1 = new System.Windows.Forms.TextBox();
            this.TextPrice2 = new System.Windows.Forms.TextBox();
            this.TextBevName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BeverageGrid)).BeginInit();
            this.AddOrRemoveBeverages.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeverageGrid
            // 
            this.BeverageGrid.AllowUserToOrderColumns = true;
            this.BeverageGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BeverageGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.BeverageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BeverageGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BeverageGrid.Location = new System.Drawing.Point(39, 12);
            this.BeverageGrid.Name = "BeverageGrid";
            this.BeverageGrid.Size = new System.Drawing.Size(405, 494);
            this.BeverageGrid.TabIndex = 0;
            // 
            // AddOrRemoveBeverages
            // 
            this.AddOrRemoveBeverages.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AddOrRemoveBeverages.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AddOrRemoveBeverages.Controls.Add(this.ExitButton);
            this.AddOrRemoveBeverages.Controls.Add(this.RemoveButton);
            this.AddOrRemoveBeverages.Controls.Add(this.AddButton);
            this.AddOrRemoveBeverages.Controls.Add(this.TextPrice1);
            this.AddOrRemoveBeverages.Controls.Add(this.TextPrice2);
            this.AddOrRemoveBeverages.Controls.Add(this.TextBevName);
            this.AddOrRemoveBeverages.Controls.Add(this.label5);
            this.AddOrRemoveBeverages.Controls.Add(this.label4);
            this.AddOrRemoveBeverages.Controls.Add(this.label3);
            this.AddOrRemoveBeverages.Controls.Add(this.label2);
            this.AddOrRemoveBeverages.Controls.Add(this.label1);
            this.AddOrRemoveBeverages.Location = new System.Drawing.Point(572, 237);
            this.AddOrRemoveBeverages.Name = "AddOrRemoveBeverages";
            this.AddOrRemoveBeverages.Size = new System.Drawing.Size(395, 269);
            this.AddOrRemoveBeverages.TabIndex = 1;
            this.AddOrRemoveBeverages.TabStop = false;
            this.AddOrRemoveBeverages.Text = "AddOrRemoveBeverages";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(292, 207);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit Form";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(28, 207);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove Beverage";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(28, 164);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(109, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Beverage";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TextPrice1
            // 
            this.TextPrice1.Location = new System.Drawing.Point(134, 81);
            this.TextPrice1.Name = "TextPrice1";
            this.TextPrice1.Size = new System.Drawing.Size(100, 20);
            this.TextPrice1.TabIndex = 6;
            this.TextPrice1.Validating += new System.ComponentModel.CancelEventHandler(this.TextPrice1_Validating);
            // 
            // TextPrice2
            // 
            this.TextPrice2.Location = new System.Drawing.Point(240, 81);
            this.TextPrice2.Name = "TextPrice2";
            this.TextPrice2.Size = new System.Drawing.Size(100, 20);
            this.TextPrice2.TabIndex = 7;
            this.TextPrice2.Validating += new System.ComponentModel.CancelEventHandler(this.TextPrice2_Validating);
            // 
            // TextBevName
            // 
            this.TextBevName.Location = new System.Drawing.Point(28, 81);
            this.TextBevName.Name = "TextBevName";
            this.TextBevName.Size = new System.Drawing.Size(100, 20);
            this.TextBevName.TabIndex = 5;
            this.TextBevName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBevName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Large";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Regular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 538);
            this.Controls.Add(this.AddOrRemoveBeverages);
            this.Controls.Add(this.BeverageGrid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BeverageGrid)).EndInit();
            this.AddOrRemoveBeverages.ResumeLayout(false);
            this.AddOrRemoveBeverages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BeverageGrid;
        private System.Windows.Forms.GroupBox AddOrRemoveBeverages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPrice1;
        private System.Windows.Forms.TextBox TextPrice2;
        private System.Windows.Forms.TextBox TextBevName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
    }
}

