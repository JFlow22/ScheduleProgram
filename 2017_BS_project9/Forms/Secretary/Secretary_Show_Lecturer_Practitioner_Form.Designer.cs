namespace _2017_BS_project9.Forms
{
    partial class Secretary_Show_Lecturer_Practitioner_Form
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
            this.LecturerCheck = new System.Windows.Forms.CheckBox();
            this.PractitionerCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDListBox = new System.Windows.Forms.ListBox();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.EndTime = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LecturerCheck
            // 
            this.LecturerCheck.AutoSize = true;
            this.LecturerCheck.Location = new System.Drawing.Point(105, 89);
            this.LecturerCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LecturerCheck.Name = "LecturerCheck";
            this.LecturerCheck.Size = new System.Drawing.Size(65, 17);
            this.LecturerCheck.TabIndex = 0;
            this.LecturerCheck.Text = "Lecturer";
            this.LecturerCheck.UseVisualStyleBackColor = true;
            this.LecturerCheck.CheckedChanged += new System.EventHandler(this.LecturerCheck_CheckedChanged);
            // 
            // PractitionerCheck
            // 
            this.PractitionerCheck.AutoSize = true;
            this.PractitionerCheck.Location = new System.Drawing.Point(207, 89);
            this.PractitionerCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PractitionerCheck.Name = "PractitionerCheck";
            this.PractitionerCheck.Size = new System.Drawing.Size(79, 17);
            this.PractitionerCheck.TabIndex = 1;
            this.PractitionerCheck.Text = "Practitioner";
            this.PractitionerCheck.UseVisualStyleBackColor = true;
            this.PractitionerCheck.CheckedChanged += new System.EventHandler(this.PractitionerCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you like to see a lecturer or a practitioner?";
            // 
            // IDListBox
            // 
            this.IDListBox.FormattingEnabled = true;
            this.IDListBox.Location = new System.Drawing.Point(336, 89);
            this.IDListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDListBox.Name = "IDListBox";
            this.IDListBox.Size = new System.Drawing.Size(92, 199);
            this.IDListBox.TabIndex = 3;
            // 
            // NameListBox
            // 
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.Location = new System.Drawing.Point(440, 89);
            this.NameListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(130, 199);
            this.NameListBox.TabIndex = 4;
            // 
            // EndTime
            // 
            this.EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTime.Enabled = false;
            this.EndTime.FormattingEnabled = true;
            this.EndTime.Location = new System.Drawing.Point(144, 234);
            this.EndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(92, 21);
            this.EndTime.TabIndex = 6;
            this.EndTime.SelectedIndexChanged += new System.EventHandler(this.EndTime_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(105, 288);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(178, 43);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // StartTime
            // 
            this.StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTime.Enabled = false;
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Location = new System.Drawing.Point(144, 186);
            this.StartTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(92, 21);
            this.StartTime.TabIndex = 10;
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged_1);
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.Enabled = false;
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(144, 138);
            this.Day.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(92, 21);
            this.Day.TabIndex = 11;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select end time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select start time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select a day:";
            // 
            // Secretary_Show_Lecturer_Practitioner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 343);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.NameListBox);
            this.Controls.Add(this.IDListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PractitionerCheck);
            this.Controls.Add(this.LecturerCheck);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Secretary_Show_Lecturer_Practitioner_Form";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.Text = "Show Lecturer/Practitioner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LecturerCheck;
        private System.Windows.Forms.CheckBox PractitionerCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IDListBox;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.ComboBox StartTime;
        private System.Windows.Forms.ComboBox EndTime;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}