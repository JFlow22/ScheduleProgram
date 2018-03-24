namespace _2017_BS_project9.Forms
{
    partial class Adding_Lecture_Form
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
            this.Adding = new System.Windows.Forms.Button();
            this.CourseNames_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LecturerName_Label = new System.Windows.Forms.Label();
            this.DayTime_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LectureDuration_Label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adding
            // 
            this.Adding.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adding.Location = new System.Drawing.Point(62, 310);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(178, 48);
            this.Adding.TabIndex = 8;
            this.Adding.Text = "Add";
            this.Adding.UseVisualStyleBackColor = true;
            this.Adding.Click += new System.EventHandler(this.Adding_Click);
            // 
            // CourseNames_combo
            // 
            this.CourseNames_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseNames_combo.FormattingEnabled = true;
            this.CourseNames_combo.Location = new System.Drawing.Point(130, 83);
            this.CourseNames_combo.Name = "CourseNames_combo";
            this.CourseNames_combo.Size = new System.Drawing.Size(176, 21);
            this.CourseNames_combo.TabIndex = 9;
            this.CourseNames_combo.SelectedIndexChanged += new System.EventHandler(this.CourseNames_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lecturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Course:";
            // 
            // LecturerName_Label
            // 
            this.LecturerName_Label.AutoSize = true;
            this.LecturerName_Label.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerName_Label.Location = new System.Drawing.Point(134, 134);
            this.LecturerName_Label.Name = "LecturerName_Label";
            this.LecturerName_Label.Size = new System.Drawing.Size(168, 32);
            this.LecturerName_Label.TabIndex = 14;
            this.LecturerName_Label.Text = "Lecturer_Name";
            this.LecturerName_Label.Visible = false;
            // 
            // DayTime_combo
            // 
            this.DayTime_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayTime_combo.FormattingEnabled = true;
            this.DayTime_combo.Location = new System.Drawing.Point(322, 256);
            this.DayTime_combo.Name = "DayTime_combo";
            this.DayTime_combo.Size = new System.Drawing.Size(176, 21);
            this.DayTime_combo.TabIndex = 15;
            this.DayTime_combo.SelectedIndexChanged += new System.EventHandler(this.DayTime_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Days and hours of lecturer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lecture Duration:";
            // 
            // LectureDuration_Label
            // 
            this.LectureDuration_Label.AutoSize = true;
            this.LectureDuration_Label.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LectureDuration_Label.Location = new System.Drawing.Point(223, 195);
            this.LectureDuration_Label.Name = "LectureDuration_Label";
            this.LectureDuration_Label.Size = new System.Drawing.Size(186, 32);
            this.LectureDuration_Label.TabIndex = 18;
            this.LectureDuration_Label.Text = "Lecture_Duration";
            this.LectureDuration_Label.Visible = false;
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(293, 310);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(178, 48);
            this.Exit_button.TabIndex = 20;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Adding_Lecture_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 379);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.LectureDuration_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DayTime_combo);
            this.Controls.Add(this.LecturerName_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseNames_combo);
            this.Controls.Add(this.Adding);
            this.MaximizeBox = false;
            this.Name = "Adding_Lecture_Form";
            this.Resizable = false;
            this.Text = "Adding Lecture";
            this.Load += new System.EventHandler(this.Adding_Lecture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.ComboBox CourseNames_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LecturerName_Label;
        private System.Windows.Forms.ComboBox DayTime_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LectureDuration_Label;
        private System.Windows.Forms.Button Exit_button;
    }
}