namespace Assignment5._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSerializeBinary = new System.Windows.Forms.Button();
            this.btnDeserializeBinary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeserializeJSON = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSerializeJSON = new System.Windows.Forms.Button();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextFName = new System.Windows.Forms.TextBox();
            this.btnDeserializeXML = new System.Windows.Forms.Button();
            this.btnSerializeXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(340, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "  Serialization \r\nTake your pick! \r\n";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnCreate.Location = new System.Drawing.Point(265, 177);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 26);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnSerializeBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializeBinary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSerializeBinary.Location = new System.Drawing.Point(143, 209);
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(120, 32);
            this.btnSerializeBinary.TabIndex = 12;
            this.btnSerializeBinary.Text = "Serialize";
            this.btnSerializeBinary.UseVisualStyleBackColor = false;
            this.btnSerializeBinary.Click += new System.EventHandler(this.btnSerializeBinary_Click_1);
            // 
            // btnDeserializeBinary
            // 
            this.btnDeserializeBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnDeserializeBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserializeBinary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnDeserializeBinary.Location = new System.Drawing.Point(351, 209);
            this.btnDeserializeBinary.Name = "btnDeserializeBinary";
            this.btnDeserializeBinary.Size = new System.Drawing.Size(120, 32);
            this.btnDeserializeBinary.TabIndex = 13;
            this.btnDeserializeBinary.Text = "DeSerialize";
            this.btnDeserializeBinary.UseVisualStyleBackColor = false;
            this.btnDeserializeBinary.Click += new System.EventHandler(this.btnDeserializeBinary_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.btnDeserializeJSON);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSerializeJSON);
            this.groupBox1.Controls.Add(this.TextAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextMobile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextFName);
            this.groupBox1.Controls.Add(this.btnSerializeBinary);
            this.groupBox1.Controls.Add(this.btnDeserializeBinary);
            this.groupBox1.Controls.Add(this.btnDeserializeXML);
            this.groupBox1.Controls.Add(this.btnSerializeXML);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.groupBox1.Location = new System.Drawing.Point(98, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 357);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnDeserializeJSON
            // 
            this.btnDeserializeJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnDeserializeJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserializeJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnDeserializeJSON.Location = new System.Drawing.Point(351, 287);
            this.btnDeserializeJSON.Name = "btnDeserializeJSON";
            this.btnDeserializeJSON.Size = new System.Drawing.Size(120, 32);
            this.btnDeserializeJSON.TabIndex = 21;
            this.btnDeserializeJSON.Text = "JSON DeSerialize";
            this.btnDeserializeJSON.UseVisualStyleBackColor = false;
            this.btnDeserializeJSON.Click += new System.EventHandler(this.btnDeserializeJSON_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address";
            // 
            // btnSerializeJSON
            // 
            this.btnSerializeJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnSerializeJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializeJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSerializeJSON.Location = new System.Drawing.Point(143, 287);
            this.btnSerializeJSON.Name = "btnSerializeJSON";
            this.btnSerializeJSON.Size = new System.Drawing.Size(120, 32);
            this.btnSerializeJSON.TabIndex = 20;
            this.btnSerializeJSON.Text = "JSON Serialize";
            this.btnSerializeJSON.UseVisualStyleBackColor = false;
            this.btnSerializeJSON.Click += new System.EventHandler(this.btnSerializeJSON_Click);
            // 
            // TextAddress
            // 
            this.TextAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.TextAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TextAddress.Location = new System.Drawing.Point(265, 111);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(206, 20);
            this.TextAddress.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mobile";
            // 
            // TextMobile
            // 
            this.TextMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.TextMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TextMobile.Location = new System.Drawing.Point(265, 66);
            this.TextMobile.Name = "TextMobile";
            this.TextMobile.Size = new System.Drawing.Size(100, 20);
            this.TextMobile.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(202, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name";
            // 
            // TextFName
            // 
            this.TextFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.TextFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TextFName.Location = new System.Drawing.Point(265, 31);
            this.TextFName.Name = "TextFName";
            this.TextFName.Size = new System.Drawing.Size(100, 20);
            this.TextFName.TabIndex = 14;
            // 
            // btnDeserializeXML
            // 
            this.btnDeserializeXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnDeserializeXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserializeXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnDeserializeXML.Location = new System.Drawing.Point(351, 249);
            this.btnDeserializeXML.Name = "btnDeserializeXML";
            this.btnDeserializeXML.Size = new System.Drawing.Size(120, 32);
            this.btnDeserializeXML.TabIndex = 13;
            this.btnDeserializeXML.Text = "XML DeSerialize";
            this.btnDeserializeXML.UseVisualStyleBackColor = false;
            this.btnDeserializeXML.Click += new System.EventHandler(this.btnDeserializeXML_Click);
            // 
            // btnSerializeXML
            // 
            this.btnSerializeXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.btnSerializeXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializeXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSerializeXML.Location = new System.Drawing.Point(143, 249);
            this.btnSerializeXML.Name = "btnSerializeXML";
            this.btnSerializeXML.Size = new System.Drawing.Size(120, 32);
            this.btnSerializeXML.TabIndex = 12;
            this.btnSerializeXML.Text = "XML Serialize";
            this.btnSerializeXML.UseVisualStyleBackColor = false;
            this.btnSerializeXML.Click += new System.EventHandler(this.btnSerializeXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(72)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(228)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSerializeBinary;
        private System.Windows.Forms.Button btnDeserializeBinary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextFName;
        private System.Windows.Forms.Button btnDeserializeJSON;
        private System.Windows.Forms.Button btnSerializeJSON;
        private System.Windows.Forms.Button btnSerializeXML;
        private System.Windows.Forms.Button btnDeserializeXML;
    }
}

