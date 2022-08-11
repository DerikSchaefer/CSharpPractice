namespace Mod6BinarySerialization
{
    partial class XMLForm
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
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.textEmpSalary = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnXMLDeserialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnJSONSerialize = new System.Windows.Forms.Button();
            this.btnJSONDeSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(350, 74);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(100, 20);
            this.textEmpID.TabIndex = 0;
            // 
            // textEmpSalary
            // 
            this.textEmpSalary.Location = new System.Drawing.Point(350, 185);
            this.textEmpSalary.Name = "textEmpSalary";
            this.textEmpSalary.Size = new System.Drawing.Size(100, 20);
            this.textEmpSalary.TabIndex = 1;
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(350, 135);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(100, 20);
            this.textEmpName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "XML Serialization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(232, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emp Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(232, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emp Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(232, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Id";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(350, 265);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnXMLDeserialize
            // 
            this.btnXMLDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXMLDeserialize.Location = new System.Drawing.Point(423, 342);
            this.btnXMLDeserialize.Name = "btnXMLDeserialize";
            this.btnXMLDeserialize.Size = new System.Drawing.Size(120, 23);
            this.btnXMLDeserialize.TabIndex = 8;
            this.btnXMLDeserialize.Text = "XML Deserialize";
            this.btnXMLDeserialize.UseVisualStyleBackColor = true;
            this.btnXMLDeserialize.Click += new System.EventHandler(this.btnXMLDeserialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXMLSerialize.Location = new System.Drawing.Point(245, 342);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(120, 23);
            this.btnXMLSerialize.TabIndex = 9;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnJSONSerialize
            // 
            this.btnJSONSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnJSONSerialize.Location = new System.Drawing.Point(245, 391);
            this.btnJSONSerialize.Name = "btnJSONSerialize";
            this.btnJSONSerialize.Size = new System.Drawing.Size(120, 23);
            this.btnJSONSerialize.TabIndex = 10;
            this.btnJSONSerialize.Text = "JSON Serialize";
            this.btnJSONSerialize.UseVisualStyleBackColor = true;
            this.btnJSONSerialize.Click += new System.EventHandler(this.btnJSONSerialize_Click);
            // 
            // btnJSONDeSerialize
            // 
            this.btnJSONDeSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnJSONDeSerialize.Location = new System.Drawing.Point(423, 391);
            this.btnJSONDeSerialize.Name = "btnJSONDeSerialize";
            this.btnJSONDeSerialize.Size = new System.Drawing.Size(120, 23);
            this.btnJSONDeSerialize.TabIndex = 11;
            this.btnJSONDeSerialize.Text = "JSON Deserialize";
            this.btnJSONDeSerialize.UseVisualStyleBackColor = true;
            this.btnJSONDeSerialize.Click += new System.EventHandler(this.btnJSONDeSerialize_Click);
            // 
            // XMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONDeSerialize);
            this.Controls.Add(this.btnJSONSerialize);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.btnXMLDeserialize);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpSalary);
            this.Controls.Add(this.textEmpID);
            this.Name = "XMLForm";
            this.Text = "XMLForm";
            this.Load += new System.EventHandler(this.XMLForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.TextBox textEmpSalary;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnXMLDeserialize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnJSONSerialize;
        private System.Windows.Forms.Button btnJSONDeSerialize;
    }
}