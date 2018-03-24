namespace _2017_BS_project9.Forms
{
    partial class SearchForSubstitute_Form
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
            this.course_chooser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cLec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sLec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sPrac = new System.Windows.Forms.ComboBox();
            this.cPrac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // course_chooser
            // 
            this.course_chooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_chooser.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_chooser.FormattingEnabled = true;
            this.course_chooser.Location = new System.Drawing.Point(362, 67);
            this.course_chooser.Name = "course_chooser";
            this.course_chooser.Size = new System.Drawing.Size(152, 29);
            this.course_chooser.Sorted = true;
            this.course_chooser.TabIndex = 35;
            this.course_chooser.SelectedIndexChanged += new System.EventHandler(this.course_chooser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Course :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Current lecturer :";
            // 
            // cLec
            // 
            this.cLec.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLec.Location = new System.Drawing.Point(192, 119);
            this.cLec.Name = "cLec";
            this.cLec.ReadOnly = true;
            this.cLec.Size = new System.Drawing.Size(164, 29);
            this.cLec.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "substitute Lecturer :";
            // 
            // sLec
            // 
            this.sLec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sLec.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLec.FormattingEnabled = true;
            this.sLec.Location = new System.Drawing.Point(553, 119);
            this.sLec.Name = "sLec";
            this.sLec.Size = new System.Drawing.Size(152, 29);
            this.sLec.Sorted = true;
            this.sLec.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "substitute practitioner :";
            // 
            // sPrac
            // 
            this.sPrac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sPrac.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPrac.FormattingEnabled = true;
            this.sPrac.Location = new System.Drawing.Point(553, 172);
            this.sPrac.Name = "sPrac";
            this.sPrac.Size = new System.Drawing.Size(152, 29);
            this.sPrac.Sorted = true;
            this.sPrac.TabIndex = 46;
            // 
            // cPrac
            // 
            this.cPrac.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPrac.Location = new System.Drawing.Point(192, 172);
            this.cPrac.Name = "cPrac";
            this.cPrac.ReadOnly = true;
            this.cPrac.Size = new System.Drawing.Size(164, 29);
            this.cPrac.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Current practitioner :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.button1.Location = new System.Drawing.Point(566, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 49;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.delete_button.Location = new System.Drawing.Point(421, 225);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(139, 43);
            this.delete_button.TabIndex = 48;
            this.delete_button.Text = "Confirm";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // SearchForSubstitute_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sPrac);
            this.Controls.Add(this.cPrac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sLec);
            this.Controls.Add(this.cLec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course_chooser);
            this.MaximizeBox = false;
            this.Name = "SearchForSubstitute_Form";
            this.Resizable = false;
            this.Text = "Search For Substitute";
            this.Load += new System.EventHandler(this.SearchForSubstitute_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox course_chooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cLec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sLec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sPrac;
        private System.Windows.Forms.TextBox cPrac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_button;
    }
}