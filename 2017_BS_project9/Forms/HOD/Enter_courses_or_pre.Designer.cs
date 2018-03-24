namespace _2017_BS_project9
{
    partial class Enter_courses_or_pre
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
            this.new_course_button = new System.Windows.Forms.Button();
            this.set_pre_course_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "What you would like to do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // new_course_button
            // 
            this.new_course_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.new_course_button.FlatAppearance.BorderSize = 0;
            this.new_course_button.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.new_course_button.Location = new System.Drawing.Point(10, 74);
            this.new_course_button.Name = "new_course_button";
            this.new_course_button.Size = new System.Drawing.Size(148, 74);
            this.new_course_button.TabIndex = 2;
            this.new_course_button.Text = "Enter new courses";
            this.new_course_button.UseVisualStyleBackColor = true;
            this.new_course_button.Click += new System.EventHandler(this.new_course_button_Click);
            // 
            // set_pre_course_button
            // 
            this.set_pre_course_button.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_pre_course_button.Location = new System.Drawing.Point(164, 74);
            this.set_pre_course_button.Name = "set_pre_course_button";
            this.set_pre_course_button.Size = new System.Drawing.Size(148, 74);
            this.set_pre_course_button.TabIndex = 3;
            this.set_pre_course_button.Text = "Set pre courses";
            this.set_pre_course_button.UseVisualStyleBackColor = true;
            this.set_pre_course_button.Click += new System.EventHandler(this.set_pre_course_button_Click);
            // 
            // Enter_courses_or_pre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 155);
            this.Controls.Add(this.set_pre_course_button);
            this.Controls.Add(this.new_course_button);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Enter_courses_or_pre";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit courses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_course_button;
        private System.Windows.Forms.Button set_pre_course_button;
    }
}