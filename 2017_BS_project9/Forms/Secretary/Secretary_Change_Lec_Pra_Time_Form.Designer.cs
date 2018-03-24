namespace _2017_BS_project9.Forms
{
    partial class Secretary_Change_Lec_Pra_Time_Form
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
            this.Lecture = new System.Windows.Forms.CheckBox();
            this.Practice = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.ListBox();
            this.Courses = new System.Windows.Forms.ListBox();
            this.Start_Time = new System.Windows.Forms.ListBox();
            this.End_Time = new System.Windows.Forms.ListBox();
            this.Days = new System.Windows.Forms.ListBox();
            this.New_Teacher_ID = new System.Windows.Forms.ListBox();
            this.New_Teacher_Name = new System.Windows.Forms.ListBox();
            this.Class = new System.Windows.Forms.ListBox();
            this.Teacher_ID = new System.Windows.Forms.ListBox();
            this.Lecture_Select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.ComboBox();
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Current_Class = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Teacher = new System.Windows.Forms.ComboBox();
            this.ClassCombobox = new System.Windows.Forms.ComboBox();
            this.UpdateDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lecture
            // 
            this.Lecture.AutoSize = true;
            this.Lecture.Location = new System.Drawing.Point(47, 104);
            this.Lecture.Margin = new System.Windows.Forms.Padding(2);
            this.Lecture.Name = "Lecture";
            this.Lecture.Size = new System.Drawing.Size(62, 17);
            this.Lecture.TabIndex = 0;
            this.Lecture.Text = "Lecture";
            this.Lecture.UseVisualStyleBackColor = true;
            this.Lecture.CheckedChanged += new System.EventHandler(this.Lecture_CheckedChanged);
            // 
            // Practice
            // 
            this.Practice.AutoSize = true;
            this.Practice.Location = new System.Drawing.Point(139, 104);
            this.Practice.Margin = new System.Windows.Forms.Padding(2);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(65, 17);
            this.Practice.TabIndex = 1;
            this.Practice.Text = "Practice";
            this.Practice.UseVisualStyleBackColor = true;
            this.Practice.CheckedChanged += new System.EventHandler(this.Practice_CheckedChanged);
            // 
            // ID
            // 
            this.ID.FormattingEnabled = true;
            this.ID.Location = new System.Drawing.Point(320, 104);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(91, 212);
            this.ID.TabIndex = 2;
            // 
            // Courses
            // 
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(414, 104);
            this.Courses.Margin = new System.Windows.Forms.Padding(2);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(91, 212);
            this.Courses.TabIndex = 3;
            // 
            // Start_Time
            // 
            this.Start_Time.FormattingEnabled = true;
            this.Start_Time.Location = new System.Drawing.Point(509, 104);
            this.Start_Time.Margin = new System.Windows.Forms.Padding(2);
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Size = new System.Drawing.Size(91, 212);
            this.Start_Time.TabIndex = 4;
            // 
            // End_Time
            // 
            this.End_Time.FormattingEnabled = true;
            this.End_Time.Location = new System.Drawing.Point(603, 104);
            this.End_Time.Margin = new System.Windows.Forms.Padding(2);
            this.End_Time.Name = "End_Time";
            this.End_Time.Size = new System.Drawing.Size(91, 212);
            this.End_Time.TabIndex = 5;
            // 
            // Days
            // 
            this.Days.FormattingEnabled = true;
            this.Days.Location = new System.Drawing.Point(698, 104);
            this.Days.Margin = new System.Windows.Forms.Padding(2);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(91, 212);
            this.Days.TabIndex = 6;
            // 
            // New_Teacher_ID
            // 
            this.New_Teacher_ID.FormattingEnabled = true;
            this.New_Teacher_ID.Location = new System.Drawing.Point(320, 368);
            this.New_Teacher_ID.Margin = new System.Windows.Forms.Padding(2);
            this.New_Teacher_ID.Name = "New_Teacher_ID";
            this.New_Teacher_ID.Size = new System.Drawing.Size(91, 121);
            this.New_Teacher_ID.TabIndex = 8;
            // 
            // New_Teacher_Name
            // 
            this.New_Teacher_Name.FormattingEnabled = true;
            this.New_Teacher_Name.Location = new System.Drawing.Point(423, 368);
            this.New_Teacher_Name.Margin = new System.Windows.Forms.Padding(2);
            this.New_Teacher_Name.Name = "New_Teacher_Name";
            this.New_Teacher_Name.Size = new System.Drawing.Size(116, 121);
            this.New_Teacher_Name.TabIndex = 9;
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(555, 368);
            this.Class.Margin = new System.Windows.Forms.Padding(2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(91, 121);
            this.Class.TabIndex = 10;
            // 
            // Teacher_ID
            // 
            this.Teacher_ID.FormattingEnabled = true;
            this.Teacher_ID.Location = new System.Drawing.Point(792, 104);
            this.Teacher_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Teacher_ID.Name = "Teacher_ID";
            this.Teacher_ID.Size = new System.Drawing.Size(91, 212);
            this.Teacher_ID.TabIndex = 11;
            // 
            // Lecture_Select
            // 
            this.Lecture_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lecture_Select.FormattingEnabled = true;
            this.Lecture_Select.Location = new System.Drawing.Point(47, 154);
            this.Lecture_Select.Margin = new System.Windows.Forms.Padding(2);
            this.Lecture_Select.Name = "Lecture_Select";
            this.Lecture_Select.Size = new System.Drawing.Size(92, 21);
            this.Lecture_Select.TabIndex = 12;
            this.Lecture_Select.SelectedIndexChanged += new System.EventHandler(this.Lecture_Select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Would you like to change the lecture or the practice?";
            // 
            // EndTime
            // 
            this.EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTime.Enabled = false;
            this.EndTime.FormattingEnabled = true;
            this.EndTime.Location = new System.Drawing.Point(167, 263);
            this.EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(92, 21);
            this.EndTime.TabIndex = 14;
            this.EndTime.SelectedIndexChanged += new System.EventHandler(this.EndTime_SelectedIndexChanged);
            // 
            // StartTime
            // 
            this.StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTime.Enabled = false;
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Location = new System.Drawing.Point(47, 263);
            this.StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(92, 21);
            this.StartTime.TabIndex = 15;
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged);
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.Enabled = false;
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(109, 217);
            this.Day.Margin = new System.Windows.Forms.Padding(2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(92, 21);
            this.Day.TabIndex = 16;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select the start time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Please select the day you would like to change to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Please select the lecture/practice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select the end time";
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(43, 337);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(215, 55);
            this.Search.TabIndex = 21;
            this.Search.Text = "Search for a teacher and a class";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Current class:";
            // 
            // Current_Class
            // 
            this.Current_Class.AutoSize = true;
            this.Current_Class.Location = new System.Drawing.Point(123, 307);
            this.Current_Class.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Current_Class.Name = "Current_Class";
            this.Current_Class.Size = new System.Drawing.Size(0, 13);
            this.Current_Class.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Old lessons data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "New Data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 352);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Classes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 352);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Teacher name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 352);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Teacher id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(807, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Teacher id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(725, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Days";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(621, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "End time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(526, 87);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Start time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 87);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Course name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(357, 87);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 413);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Select a teacher:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 450);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Select the class:";
            // 
            // Teacher
            // 
            this.Teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Teacher.Enabled = false;
            this.Teacher.FormattingEnabled = true;
            this.Teacher.Location = new System.Drawing.Point(149, 413);
            this.Teacher.Margin = new System.Windows.Forms.Padding(2);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(92, 21);
            this.Teacher.TabIndex = 37;
            // 
            // ClassCombobox
            // 
            this.ClassCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCombobox.Enabled = false;
            this.ClassCombobox.FormattingEnabled = true;
            this.ClassCombobox.Location = new System.Drawing.Point(149, 447);
            this.ClassCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassCombobox.Name = "ClassCombobox";
            this.ClassCombobox.Size = new System.Drawing.Size(92, 21);
            this.ClassCombobox.TabIndex = 38;
            // 
            // UpdateDB
            // 
            this.UpdateDB.Enabled = false;
            this.UpdateDB.Location = new System.Drawing.Point(149, 480);
            this.UpdateDB.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDB.Name = "UpdateDB";
            this.UpdateDB.Size = new System.Drawing.Size(110, 39);
            this.UpdateDB.TabIndex = 40;
            this.UpdateDB.Text = "Update";
            this.UpdateDB.UseVisualStyleBackColor = true;
            this.UpdateDB.Click += new System.EventHandler(this.Update_Click);
            // 
            // Secretary_Change_Lec_Pra_Time_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 537);
            this.Controls.Add(this.UpdateDB);
            this.Controls.Add(this.ClassCombobox);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Current_Class);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lecture_Select);
            this.Controls.Add(this.Teacher_ID);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.New_Teacher_Name);
            this.Controls.Add(this.New_Teacher_ID);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.End_Time);
            this.Controls.Add(this.Start_Time);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Practice);
            this.Controls.Add(this.Lecture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Secretary_Change_Lec_Pra_Time_Form";
            this.Resizable = false;
            this.Text = "Secretary Change Lectrue/Practice Time";
            this.Load += new System.EventHandler(this.Secretary_Change_Lec_Pra_Time_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Lecture;
        private System.Windows.Forms.CheckBox Practice;
        private System.Windows.Forms.ListBox ID;
        private System.Windows.Forms.ListBox Courses;
        private System.Windows.Forms.ListBox Start_Time;
        private System.Windows.Forms.ListBox End_Time;
        private System.Windows.Forms.ListBox Days;
        private System.Windows.Forms.ListBox New_Teacher_ID;
        private System.Windows.Forms.ListBox New_Teacher_Name;
        private System.Windows.Forms.ListBox Class;
        private System.Windows.Forms.ListBox Teacher_ID;
        private System.Windows.Forms.ComboBox Lecture_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EndTime;
        private System.Windows.Forms.ComboBox StartTime;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Current_Class;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox Teacher;
        private System.Windows.Forms.ComboBox ClassCombobox;
        private System.Windows.Forms.Button UpdateDB;
    }
}