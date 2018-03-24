namespace _2017_BS_project9
{
    partial class Add_new_course
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
            this.course_textbox = new System.Windows.Forms.TextBox();
            this.Lectur_duration_combobox = new System.Windows.Forms.ComboBox();
            this.Practice_duration_combobox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.lab_duration_combobox = new System.Windows.Forms.ComboBox();
            this.Practice_checkbox = new System.Windows.Forms.CheckBox();
            this.Lab_Checkbox = new System.Windows.Forms.CheckBox();
            this.View_courses = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LecturerID_combo = new System.Windows.Forms.ComboBox();
            this.practitionerID_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "In oreder to create new course,\r\nfill all the required fields.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_textbox
            // 
            this.course_textbox.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.course_textbox.ForeColor = System.Drawing.Color.Gray;
            this.course_textbox.Location = new System.Drawing.Point(17, 135);
            this.course_textbox.Name = "course_textbox";
            this.course_textbox.Size = new System.Drawing.Size(147, 32);
            this.course_textbox.TabIndex = 1;
            this.course_textbox.Text = "Course name";
            this.course_textbox.Enter += new System.EventHandler(this.course_textbox_Enter);
            this.course_textbox.Leave += new System.EventHandler(this.course_textbox_Leave);
            // 
            // Lectur_duration_combobox
            // 
            this.Lectur_duration_combobox.FormattingEnabled = true;
            this.Lectur_duration_combobox.Items.AddRange(new object[] {
            "2 Hours",
            "3 Hours",
            "4 Hours"});
            this.Lectur_duration_combobox.Location = new System.Drawing.Point(175, 135);
            this.Lectur_duration_combobox.Name = "Lectur_duration_combobox";
            this.Lectur_duration_combobox.Size = new System.Drawing.Size(147, 21);
            this.Lectur_duration_combobox.TabIndex = 3;
            this.Lectur_duration_combobox.Text = "-- Lectuer duration --";
            // 
            // Practice_duration_combobox
            // 
            this.Practice_duration_combobox.Enabled = false;
            this.Practice_duration_combobox.FormattingEnabled = true;
            this.Practice_duration_combobox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours"});
            this.Practice_duration_combobox.Location = new System.Drawing.Point(175, 224);
            this.Practice_duration_combobox.Name = "Practice_duration_combobox";
            this.Practice_duration_combobox.Size = new System.Drawing.Size(147, 21);
            this.Practice_duration_combobox.TabIndex = 5;
            this.Practice_duration_combobox.Text = "-- Practice duration --";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(17, 306);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(147, 50);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // lab_duration_combobox
            // 
            this.lab_duration_combobox.Enabled = false;
            this.lab_duration_combobox.FormattingEnabled = true;
            this.lab_duration_combobox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours"});
            this.lab_duration_combobox.Location = new System.Drawing.Point(175, 251);
            this.lab_duration_combobox.Name = "lab_duration_combobox";
            this.lab_duration_combobox.Size = new System.Drawing.Size(147, 21);
            this.lab_duration_combobox.TabIndex = 7;
            this.lab_duration_combobox.Text = "-- Lab duration --";
            // 
            // Practice_checkbox
            // 
            this.Practice_checkbox.AutoSize = true;
            this.Practice_checkbox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practice_checkbox.Location = new System.Drawing.Point(17, 220);
            this.Practice_checkbox.Name = "Practice_checkbox";
            this.Practice_checkbox.Size = new System.Drawing.Size(119, 25);
            this.Practice_checkbox.TabIndex = 8;
            this.Practice_checkbox.Text = "Have Practice";
            this.Practice_checkbox.UseVisualStyleBackColor = true;
            this.Practice_checkbox.CheckedChanged += new System.EventHandler(this.Practice_checkbox_CheckedChanged);
            // 
            // Lab_Checkbox
            // 
            this.Lab_Checkbox.AutoSize = true;
            this.Lab_Checkbox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Checkbox.Location = new System.Drawing.Point(17, 247);
            this.Lab_Checkbox.Name = "Lab_Checkbox";
            this.Lab_Checkbox.Size = new System.Drawing.Size(91, 25);
            this.Lab_Checkbox.TabIndex = 9;
            this.Lab_Checkbox.Text = "Have Lab";
            this.Lab_Checkbox.UseVisualStyleBackColor = true;
            this.Lab_Checkbox.CheckedChanged += new System.EventHandler(this.Lab_Checkbox_CheckedChanged);
            // 
            // View_courses
            // 
            this.View_courses.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_courses.Location = new System.Drawing.Point(175, 306);
            this.View_courses.Name = "View_courses";
            this.View_courses.Size = new System.Drawing.Size(147, 50);
            this.View_courses.TabIndex = 10;
            this.View_courses.Text = "View courses";
            this.View_courses.UseVisualStyleBackColor = true;
            this.View_courses.Click += new System.EventHandler(this.View_courses_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(305, 176);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // LecturerID_combo
            // 
            this.LecturerID_combo.FormattingEnabled = true;
            this.LecturerID_combo.Location = new System.Drawing.Point(17, 196);
            this.LecturerID_combo.Name = "LecturerID_combo";
            this.LecturerID_combo.Size = new System.Drawing.Size(147, 21);
            this.LecturerID_combo.TabIndex = 12;
            // 
            // practitionerID_combo
            // 
            this.practitionerID_combo.FormattingEnabled = true;
            this.practitionerID_combo.Location = new System.Drawing.Point(175, 196);
            this.practitionerID_combo.Name = "practitionerID_combo";
            this.practitionerID_combo.Size = new System.Drawing.Size(147, 21);
            this.practitionerID_combo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lectuter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Practitioner";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 25);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Must course";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Add_new_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 361);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.practitionerID_combo);
            this.Controls.Add(this.LecturerID_combo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View_courses);
            this.Controls.Add(this.Lab_Checkbox);
            this.Controls.Add(this.Practice_checkbox);
            this.Controls.Add(this.lab_duration_combobox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.Practice_duration_combobox);
            this.Controls.Add(this.Lectur_duration_combobox);
            this.Controls.Add(this.course_textbox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Add_new_course";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add new course";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox course_textbox;
        private System.Windows.Forms.ComboBox Lectur_duration_combobox;
        private System.Windows.Forms.ComboBox Practice_duration_combobox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox lab_duration_combobox;
        private System.Windows.Forms.CheckBox Practice_checkbox;
        private System.Windows.Forms.CheckBox Lab_Checkbox;
        private System.Windows.Forms.Button View_courses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox LecturerID_combo;
        private System.Windows.Forms.ComboBox practitionerID_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}