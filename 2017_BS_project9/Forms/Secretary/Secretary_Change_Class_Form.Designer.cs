namespace _2017_BS_project9.Forms
{
    partial class Secretary_Change_Class_Form
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
            this.Class_Search = new System.Windows.Forms.Button();
            this.Lecture_Select = new System.Windows.Forms.ComboBox();
            this.Current_Class = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Lecture = new System.Windows.Forms.CheckBox();
            this.Practice = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.End_Time = new System.Windows.Forms.ListBox();
            this.Start_Time = new System.Windows.Forms.ListBox();
            this.Courses = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Class_Search
            // 
            this.Class_Search.Enabled = false;
            this.Class_Search.Location = new System.Drawing.Point(19, 216);
            this.Class_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Class_Search.Name = "Class_Search";
            this.Class_Search.Size = new System.Drawing.Size(61, 28);
            this.Class_Search.TabIndex = 6;
            this.Class_Search.Text = "Search";
            this.Class_Search.UseVisualStyleBackColor = true;
            this.Class_Search.Click += new System.EventHandler(this.Class_Search_Click);
            // 
            // Lecture_Select
            // 
            this.Lecture_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lecture_Select.Enabled = false;
            this.Lecture_Select.FormattingEnabled = true;
            this.Lecture_Select.Location = new System.Drawing.Point(19, 152);
            this.Lecture_Select.Margin = new System.Windows.Forms.Padding(2);
            this.Lecture_Select.Name = "Lecture_Select";
            this.Lecture_Select.Size = new System.Drawing.Size(92, 21);
            this.Lecture_Select.TabIndex = 7;
            this.Lecture_Select.SelectedIndexChanged += new System.EventHandler(this.Lecture_Select_SelectedIndexChanged);
            // 
            // Current_Class
            // 
            this.Current_Class.AutoSize = true;
            this.Current_Class.Location = new System.Drawing.Point(100, 188);
            this.Current_Class.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Current_Class.Name = "Current_Class";
            this.Current_Class.Size = new System.Drawing.Size(35, 13);
            this.Current_Class.TabIndex = 8;
            this.Current_Class.Text = "label2";
            this.Current_Class.Visible = false;
            // 
            // Classes
            // 
            this.Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Classes.FormattingEnabled = true;
            this.Classes.Location = new System.Drawing.Point(94, 264);
            this.Classes.Margin = new System.Windows.Forms.Padding(2);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(92, 21);
            this.Classes.TabIndex = 9;
            this.Classes.Visible = false;
            this.Classes.SelectedIndexChanged += new System.EventHandler(this.Classes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose Class:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Please select the ID you want";
            // 
            // UpdateDB
            // 
            this.UpdateDB.Enabled = false;
            this.UpdateDB.Location = new System.Drawing.Point(17, 297);
            this.UpdateDB.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDB.Name = "UpdateDB";
            this.UpdateDB.Size = new System.Drawing.Size(91, 41);
            this.UpdateDB.TabIndex = 16;
            this.UpdateDB.Text = "Update";
            this.UpdateDB.UseVisualStyleBackColor = true;
            this.UpdateDB.Visible = false;
            this.UpdateDB.Click += new System.EventHandler(this.Update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Current class:";
            // 
            // Lecture
            // 
            this.Lecture.AutoSize = true;
            this.Lecture.Location = new System.Drawing.Point(19, 99);
            this.Lecture.Margin = new System.Windows.Forms.Padding(2);
            this.Lecture.Name = "Lecture";
            this.Lecture.Size = new System.Drawing.Size(62, 17);
            this.Lecture.TabIndex = 18;
            this.Lecture.Text = "Lecture";
            this.Lecture.UseVisualStyleBackColor = true;
            this.Lecture.CheckedChanged += new System.EventHandler(this.Lecture_CheckedChanged);
            // 
            // Practice
            // 
            this.Practice.AutoSize = true;
            this.Practice.Location = new System.Drawing.Point(102, 99);
            this.Practice.Margin = new System.Windows.Forms.Padding(2);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(65, 17);
            this.Practice.TabIndex = 19;
            this.Practice.Text = "Practice";
            this.Practice.UseVisualStyleBackColor = true;
            this.Practice.CheckedChanged += new System.EventHandler(this.Practice_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Please choose what you want to update";
            // 
            // End_Time
            // 
            this.End_Time.FormattingEnabled = true;
            this.End_Time.Location = new System.Drawing.Point(462, 83);
            this.End_Time.Margin = new System.Windows.Forms.Padding(2);
            this.End_Time.Name = "End_Time";
            this.End_Time.Size = new System.Drawing.Size(62, 290);
            this.End_Time.TabIndex = 21;
            // 
            // Start_Time
            // 
            this.Start_Time.FormattingEnabled = true;
            this.Start_Time.Location = new System.Drawing.Point(396, 83);
            this.Start_Time.Margin = new System.Windows.Forms.Padding(2);
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Size = new System.Drawing.Size(62, 290);
            this.Start_Time.TabIndex = 22;
            // 
            // Courses
            // 
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(280, 83);
            this.Courses.Margin = new System.Windows.Forms.Padding(2);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(113, 290);
            this.Courses.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.FormattingEnabled = true;
            this.ID.Location = new System.Drawing.Point(230, 83);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(46, 290);
            this.ID.TabIndex = 24;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 387);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(567, 26);
            this.progressBar1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Start time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "End time";
            // 
            // Days
            // 
            this.Days.FormattingEnabled = true;
            this.Days.Location = new System.Drawing.Point(527, 83);
            this.Days.Margin = new System.Windows.Forms.Padding(2);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(54, 290);
            this.Days.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Days";
            // 
            // Secretary_Change_Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 429);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Start_Time);
            this.Controls.Add(this.End_Time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Practice);
            this.Controls.Add(this.Lecture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.Current_Class);
            this.Controls.Add(this.Lecture_Select);
            this.Controls.Add(this.Class_Search);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Secretary_Change_Class_Form";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Secretary Insert Class";
            this.Load += new System.EventHandler(this.Secretary_Change_Class_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Class_Search;
        private System.Windows.Forms.ComboBox Lecture_Select;
        private System.Windows.Forms.Label Current_Class;
        private System.Windows.Forms.ComboBox Classes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Lecture;
        private System.Windows.Forms.CheckBox Practice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox End_Time;
        private System.Windows.Forms.ListBox Start_Time;
        private System.Windows.Forms.ListBox Courses;
        private System.Windows.Forms.ListBox ID;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Days;
        private System.Windows.Forms.Label label9;
    }
}