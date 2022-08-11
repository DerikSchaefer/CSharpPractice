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
            this.txtEid = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btbCreate = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnXMLDS = new System.Windows.Forms.Button();
            this.btnJSONSer = new System.Windows.Forms.Button();
            this.btnJSONDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(415, 74);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(100, 20);
            this.txtEid.TabIndex = 0;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(415, 135);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(100, 20);
            this.txtEname.TabIndex = 1;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(415, 202);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "XML Serialization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emp Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emp Salary";
            // 
            // btbCreate
            // 
            this.btbCreate.Location = new System.Drawing.Point(350, 265);
            this.btbCreate.Name = "btbCreate";
            this.btbCreate.Size = new System.Drawing.Size(75, 23);
            this.btbCreate.TabIndex = 7;
            this.btbCreate.Text = "Create";
            this.btbCreate.UseVisualStyleBackColor = true;
            this.btbCreate.Click += new System.EventHandler(this.btbCreate_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Location = new System.Drawing.Point(241, 343);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(107, 23);
            this.btnXMLSerialize.TabIndex = 8;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnXMLDS
            // 
            this.btnXMLDS.Location = new System.Drawing.Point(464, 343);
            this.btnXMLDS.Name = "btnXMLDS";
            this.btnXMLDS.Size = new System.Drawing.Size(100, 23);
            this.btnXMLDS.TabIndex = 9;
            this.btnXMLDS.Text = "XML Deserialize";
            this.btnXMLDS.UseVisualStyleBackColor = true;
            this.btnXMLDS.Click += new System.EventHandler(this.btnXMLDS_Click);
            // 
            // btnJSONSer
            // 
            this.btnJSONSer.Location = new System.Drawing.Point(244, 404);
            this.btnJSONSer.Name = "btnJSONSer";
            this.btnJSONSer.Size = new System.Drawing.Size(104, 23);
            this.btnJSONSer.TabIndex = 10;
            this.btnJSONSer.Text = "JSON Serialize";
            this.btnJSONSer.UseVisualStyleBackColor = true;
            this.btnJSONSer.Click += new System.EventHandler(this.btnJSONSer_Click);
            // 
            // btnJSONDS
            // 
            this.btnJSONDS.Location = new System.Drawing.Point(460, 404);
            this.btnJSONDS.Name = "btnJSONDS";
            this.btnJSONDS.Size = new System.Drawing.Size(104, 23);
            this.btnJSONDS.TabIndex = 11;
            this.btnJSONDS.Text = "JSON DeSerialize";
            this.btnJSONDS.UseVisualStyleBackColor = true;
            this.btnJSONDS.Click += new System.EventHandler(this.btnJSONDS_Click);
            // 
            // XMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONDS);
            this.Controls.Add(this.btnJSONSer);
            this.Controls.Add(this.btnXMLDS);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.btbCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEid);
            this.Name = "XMLForm";
            this.Text = "XMLForm";
            this.Load += new System.EventHandler(this.XMLForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btbCreate;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnXMLDS;
        private System.Windows.Forms.Button btnJSONSer;
        private System.Windows.Forms.Button btnJSONDS;
    }
}