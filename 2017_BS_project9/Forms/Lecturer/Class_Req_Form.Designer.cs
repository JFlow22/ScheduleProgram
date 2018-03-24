namespace _2017_BS_project9.Forms
{
    partial class Class_Req_Form
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
            this.Lab = new System.Windows.Forms.CheckBox();
            this.Projector = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            this.Insert_Request = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Lab.Location = new System.Drawing.Point(12, 188);
            this.Lab.Margin = new System.Windows.Forms.Padding(2);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(46, 21);
            this.Lab.TabIndex = 0;
            this.Lab.Text = "Lab";
            this.Lab.UseVisualStyleBackColor = true;
            // 
            // Projector
            // 
            this.Projector.AutoSize = true;
            this.Projector.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projector.Location = new System.Drawing.Point(12, 166);
            this.Projector.Margin = new System.Windows.Forms.Padding(2);
            this.Projector.Name = "Projector";
            this.Projector.Size = new System.Drawing.Size(76, 21);
            this.Projector.TabIndex = 1;
            this.Projector.Text = "Projector";
            this.Projector.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please pick the course and check the requests you want";
            // 
            // Course
            // 
            this.Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(11, 130);
            this.Course.Margin = new System.Windows.Forms.Padding(2);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(182, 25);
            this.Course.TabIndex = 3;
            // 
            // Insert_Request
            // 
            this.Insert_Request.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Request.Location = new System.Drawing.Point(233, 210);
            this.Insert_Request.Margin = new System.Windows.Forms.Padding(2);
            this.Insert_Request.Name = "Insert_Request";
            this.Insert_Request.Size = new System.Drawing.Size(133, 46);
            this.Insert_Request.TabIndex = 4;
            this.Insert_Request.Text = "Insert Request";
            this.Insert_Request.UseVisualStyleBackColor = true;
            this.Insert_Request.Click += new System.EventHandler(this.Insert_Request_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "PractitionerID:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(242, 65);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(29, 25);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // Class_Req_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 272);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insert_Request);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Projector);
            this.Controls.Add(this.Lab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Class_Req_Form";
            this.Resizable = false;
            this.Text = "Class request";
            this.Load += new System.EventHandler(this.Practitioner_Class_Req_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Lab;
        private System.Windows.Forms.CheckBox Projector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Button Insert_Request;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
    }
}