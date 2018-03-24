namespace _2017_BS_project9.Forms
{
    partial class Adding_PracticeLab_Form
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
            this.PractitionerName_Label = new System.Windows.Forms.Label();
            this.DayTimeLab_combo = new System.Windows.Forms.ComboBox();
            this.DayTimeLab_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PracticeDuration_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LabDuration_label = new System.Windows.Forms.Label();
            this.DayTimePractice_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Adding
            // 
            this.Adding.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adding.Location = new System.Drawing.Point(54, 397);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(178, 48);
            this.Adding.TabIndex = 21;
            this.Adding.Text = "Add";
            this.Adding.UseVisualStyleBackColor = true;
            this.Adding.Click += new System.EventHandler(this.Adding_Click);
            // 
            // CourseNames_combo
            // 
            this.CourseNames_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseNames_combo.FormattingEnabled = true;
            this.CourseNames_combo.Location = new System.Drawing.Point(129, 80);
            this.CourseNames_combo.Name = "CourseNames_combo";
            this.CourseNames_combo.Size = new System.Drawing.Size(176, 21);
            this.CourseNames_combo.TabIndex = 22;
            this.CourseNames_combo.SelectedIndexChanged += new System.EventHandler(this.CourseNames_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Practitioner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Course:";
            // 
            // PractitionerName_Label
            // 
            this.PractitionerName_Label.AutoSize = true;
            this.PractitionerName_Label.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PractitionerName_Label.Location = new System.Drawing.Point(169, 131);
            this.PractitionerName_Label.Name = "PractitionerName_Label";
            this.PractitionerName_Label.Size = new System.Drawing.Size(200, 32);
            this.PractitionerName_Label.TabIndex = 25;
            this.PractitionerName_Label.Text = "Practitioner_Name";
            this.PractitionerName_Label.Visible = false;
            // 
            // DayTimeLab_combo
            // 
            this.DayTimeLab_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayTimeLab_combo.FormattingEnabled = true;
            this.DayTimeLab_combo.Location = new System.Drawing.Point(321, 350);
            this.DayTimeLab_combo.Name = "DayTimeLab_combo";
            this.DayTimeLab_combo.Size = new System.Drawing.Size(176, 21);
            this.DayTimeLab_combo.TabIndex = 26;
            this.DayTimeLab_combo.Visible = false;
            this.DayTimeLab_combo.SelectedIndexChanged += new System.EventHandler(this.DayTimeLab_combo_SelectedIndexChanged);
            // 
            // DayTimeLab_label
            // 
            this.DayTimeLab_label.AutoSize = true;
            this.DayTimeLab_label.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTimeLab_label.Location = new System.Drawing.Point(18, 344);
            this.DayTimeLab_label.Name = "DayTimeLab_label";
            this.DayTimeLab_label.Size = new System.Drawing.Size(239, 32);
            this.DayTimeLab_label.TabIndex = 27;
            this.DayTimeLab_label.Text = "Days and hours of lab:";
            this.DayTimeLab_label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Practice Duration:";
            // 
            // PracticeDuration_Label
            // 
            this.PracticeDuration_Label.AutoSize = true;
            this.PracticeDuration_Label.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeDuration_Label.Location = new System.Drawing.Point(229, 184);
            this.PracticeDuration_Label.Name = "PracticeDuration_Label";
            this.PracticeDuration_Label.Size = new System.Drawing.Size(191, 32);
            this.PracticeDuration_Label.TabIndex = 29;
            this.PracticeDuration_Label.Text = "Practice_Duration";
            this.PracticeDuration_Label.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Days and hours of practice:";
            this.label6.Visible = false;
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(282, 397);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(178, 48);
            this.Exit_button.TabIndex = 31;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Lab Duration:";
            // 
            // LabDuration_label
            // 
            this.LabDuration_label.AutoSize = true;
            this.LabDuration_label.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDuration_label.Location = new System.Drawing.Point(182, 239);
            this.LabDuration_label.Name = "LabDuration_label";
            this.LabDuration_label.Size = new System.Drawing.Size(148, 32);
            this.LabDuration_label.TabIndex = 33;
            this.LabDuration_label.Text = "Lab_Duration";
            this.LabDuration_label.Visible = false;
            // 
            // DayTimePractice_combo
            // 
            this.DayTimePractice_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayTimePractice_combo.FormattingEnabled = true;
            this.DayTimePractice_combo.Location = new System.Drawing.Point(321, 300);
            this.DayTimePractice_combo.Name = "DayTimePractice_combo";
            this.DayTimePractice_combo.Size = new System.Drawing.Size(176, 21);
            this.DayTimePractice_combo.TabIndex = 34;
            this.DayTimePractice_combo.Visible = false;
            this.DayTimePractice_combo.SelectedIndexChanged += new System.EventHandler(this.DayTimePractice_combo_SelectedIndexChanged);
            // 
            // Adding_PracticeLab_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DayTimePractice_combo);
            this.Controls.Add(this.LabDuration_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.PracticeDuration_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DayTimeLab_label);
            this.Controls.Add(this.DayTimeLab_combo);
            this.Controls.Add(this.PractitionerName_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseNames_combo);
            this.Controls.Add(this.Adding);
            this.MaximizeBox = false;
            this.Name = "Adding_PracticeLab_Form";
            this.Resizable = false;
            this.Text = "Adding Practice/Lab";
            this.Load += new System.EventHandler(this.Adding_PracticeLab_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.ComboBox CourseNames_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PractitionerName_Label;
        private System.Windows.Forms.ComboBox DayTimeLab_combo;
        private System.Windows.Forms.Label DayTimeLab_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PracticeDuration_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabDuration_label;
        private System.Windows.Forms.ComboBox DayTimePractice_combo;
    }
}