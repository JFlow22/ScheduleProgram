namespace _2017_BS_project9.Forms
{
    partial class Constraines_Form
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
            this.Label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Day1 = new System.Windows.Forms.CheckBox();
            this.Day2 = new System.Windows.Forms.CheckBox();
            this.Day3 = new System.Windows.Forms.CheckBox();
            this.Day4 = new System.Windows.Forms.CheckBox();
            this.Day5 = new System.Windows.Forms.CheckBox();
            this.Day6 = new System.Windows.Forms.CheckBox();
            this.Day5_EndTime = new System.Windows.Forms.ComboBox();
            this.Day5_StartTime = new System.Windows.Forms.ComboBox();
            this.Day4_EndTime = new System.Windows.Forms.ComboBox();
            this.Day4_StartTime = new System.Windows.Forms.ComboBox();
            this.Day3_EndTime = new System.Windows.Forms.ComboBox();
            this.Day3_StartTime = new System.Windows.Forms.ComboBox();
            this.Day2_EndTime = new System.Windows.Forms.ComboBox();
            this.Day2_StartTime = new System.Windows.Forms.ComboBox();
            this.Day1_EndTime = new System.Windows.Forms.ComboBox();
            this.Day1_StartTime = new System.Windows.Forms.ComboBox();
            this.Day6_EndTime = new System.Windows.Forms.ComboBox();
            this.Day6_StartTime = new System.Windows.Forms.ComboBox();
            this.Insert_constraines = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(272, 64);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(119, 21);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Practitioner ID:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(400, 64);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 21);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please mark the available days";
            // 
            // Day1
            // 
            this.Day1.AutoSize = true;
            this.Day1.Location = new System.Drawing.Point(25, 128);
            this.Day1.Margin = new System.Windows.Forms.Padding(2);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(62, 17);
            this.Day1.TabIndex = 3;
            this.Day1.Text = "Sunday";
            this.Day1.UseVisualStyleBackColor = true;
            this.Day1.CheckedChanged += new System.EventHandler(this.Day1_CheckedChanged);
            // 
            // Day2
            // 
            this.Day2.AutoSize = true;
            this.Day2.Location = new System.Drawing.Point(136, 128);
            this.Day2.Margin = new System.Windows.Forms.Padding(2);
            this.Day2.Name = "Day2";
            this.Day2.Size = new System.Drawing.Size(64, 17);
            this.Day2.TabIndex = 4;
            this.Day2.Text = "Monday";
            this.Day2.UseVisualStyleBackColor = true;
            this.Day2.CheckedChanged += new System.EventHandler(this.Day2_CheckedChanged);
            // 
            // Day3
            // 
            this.Day3.AutoSize = true;
            this.Day3.Location = new System.Drawing.Point(258, 128);
            this.Day3.Margin = new System.Windows.Forms.Padding(2);
            this.Day3.Name = "Day3";
            this.Day3.Size = new System.Drawing.Size(67, 17);
            this.Day3.TabIndex = 5;
            this.Day3.Text = "Tuesday";
            this.Day3.UseVisualStyleBackColor = true;
            this.Day3.CheckedChanged += new System.EventHandler(this.Day3_CheckedChanged);
            // 
            // Day4
            // 
            this.Day4.AutoSize = true;
            this.Day4.Location = new System.Drawing.Point(367, 128);
            this.Day4.Margin = new System.Windows.Forms.Padding(2);
            this.Day4.Name = "Day4";
            this.Day4.Size = new System.Drawing.Size(83, 17);
            this.Day4.TabIndex = 6;
            this.Day4.Text = "Wednesday";
            this.Day4.UseVisualStyleBackColor = true;
            this.Day4.CheckedChanged += new System.EventHandler(this.Day4_CheckedChanged);
            // 
            // Day5
            // 
            this.Day5.AutoSize = true;
            this.Day5.Location = new System.Drawing.Point(494, 128);
            this.Day5.Margin = new System.Windows.Forms.Padding(2);
            this.Day5.Name = "Day5";
            this.Day5.Size = new System.Drawing.Size(70, 17);
            this.Day5.TabIndex = 7;
            this.Day5.Text = "Thursday";
            this.Day5.UseVisualStyleBackColor = true;
            this.Day5.CheckedChanged += new System.EventHandler(this.Day5_CheckedChanged);
            // 
            // Day6
            // 
            this.Day6.AutoSize = true;
            this.Day6.Location = new System.Drawing.Point(625, 128);
            this.Day6.Margin = new System.Windows.Forms.Padding(2);
            this.Day6.Name = "Day6";
            this.Day6.Size = new System.Drawing.Size(54, 17);
            this.Day6.TabIndex = 8;
            this.Day6.Text = "Friday";
            this.Day6.UseVisualStyleBackColor = true;
            this.Day6.CheckedChanged += new System.EventHandler(this.Day6_CheckedChanged);
            // 
            // Day5_EndTime
            // 
            this.Day5_EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day5_EndTime.Enabled = false;
            this.Day5_EndTime.FormattingEnabled = true;
            this.Day5_EndTime.Location = new System.Drawing.Point(482, 225);
            this.Day5_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day5_EndTime.Name = "Day5_EndTime";
            this.Day5_EndTime.Size = new System.Drawing.Size(92, 21);
            this.Day5_EndTime.TabIndex = 9;
            // 
            // Day5_StartTime
            // 
            this.Day5_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day5_StartTime.Enabled = false;
            this.Day5_StartTime.FormattingEnabled = true;
            this.Day5_StartTime.Location = new System.Drawing.Point(482, 174);
            this.Day5_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day5_StartTime.Name = "Day5_StartTime";
            this.Day5_StartTime.Size = new System.Drawing.Size(92, 21);
            this.Day5_StartTime.TabIndex = 10;
            this.Day5_StartTime.SelectedIndexChanged += new System.EventHandler(this.Day5_StartTime_SelectedIndexChanged);
            // 
            // Day4_EndTime
            // 
            this.Day4_EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day4_EndTime.Enabled = false;
            this.Day4_EndTime.FormattingEnabled = true;
            this.Day4_EndTime.Location = new System.Drawing.Point(361, 225);
            this.Day4_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day4_EndTime.Name = "Day4_EndTime";
            this.Day4_EndTime.Size = new System.Drawing.Size(92, 21);
            this.Day4_EndTime.TabIndex = 11;
            // 
            // Day4_StartTime
            // 
            this.Day4_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day4_StartTime.Enabled = false;
            this.Day4_StartTime.FormattingEnabled = true;
            this.Day4_StartTime.Location = new System.Drawing.Point(361, 174);
            this.Day4_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day4_StartTime.Name = "Day4_StartTime";
            this.Day4_StartTime.Size = new System.Drawing.Size(92, 21);
            this.Day4_StartTime.TabIndex = 12;
            this.Day4_StartTime.SelectedIndexChanged += new System.EventHandler(this.Day4_StartTime_SelectedIndexChanged);
            // 
            // Day3_EndTime
            // 
            this.Day3_EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day3_EndTime.Enabled = false;
            this.Day3_EndTime.FormattingEnabled = true;
            this.Day3_EndTime.Location = new System.Drawing.Point(243, 225);
            this.Day3_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day3_EndTime.Name = "Day3_EndTime";
            this.Day3_EndTime.Size = new System.Drawing.Size(92, 21);
            this.Day3_EndTime.TabIndex = 13;
            // 
            // Day3_StartTime
            // 
            this.Day3_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day3_StartTime.Enabled = false;
            this.Day3_StartTime.FormattingEnabled = true;
            this.Day3_StartTime.Location = new System.Drawing.Point(243, 174);
            this.Day3_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day3_StartTime.Name = "Day3_StartTime";
            this.Day3_StartTime.Size = new System.Drawing.Size(92, 21);
            this.Day3_StartTime.TabIndex = 14;
            this.Day3_StartTime.SelectedIndexChanged += new System.EventHandler(this.Day3_StartTime_SelectedIndexChanged);
            // 
            // Day2_EndTime
            // 
            this.Day2_EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day2_EndTime.Enabled = false;
            this.Day2_EndTime.FormattingEnabled = true;
            this.Day2_EndTime.Location = new System.Drawing.Point(122, 225);
            this.Day2_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day2_EndTime.Name = "Day2_EndTime";
            this.Day2_EndTime.Size = new System.Drawing.Size(92, 21);
            this.Day2_EndTime.TabIndex = 15;
            // 
            // Day2_StartTime
            // 
            this.Day2_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day2_StartTime.Enabled = false;
            this.Day2_StartTime.FormattingEnabled = true;
            this.Day2_StartTime.Location = new System.Drawing.Point(122, 174);
            this.Day2_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day2_StartTime.Name = "Day2_StartTime";
            this.Day2_StartTime.Size = new System.Drawing.Size(92, 21);
            this.Day2_StartTime.TabIndex = 16;
            this.Day2_StartTime.SelectedIndexChanged += new System.EventHandler(this.Day2_StartTime_SelectedIndexChanged);
            // 
            // Day1_EndTime
            // 
            this.Day1_EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day1_EndTime.Enabled = false;
            this.Day1_EndTime.FormattingEnabled = true;
            this.Day1_EndTime.Location = new System.Drawing.Point(6, 225);
            this.Day1_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day1_EndTime.Name = "Day1_EndTime";
            this.Day1_EndTime.Size = new System.Drawing.Size(92, 21);
            this.Day1_EndTime.TabIndex = 17;
            // 
            // Day1_StartTime
            // 
            this.Day1_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day1_StartTime.Enabled = false;
            this.Day1_StartTime.FormattingEnabled = true;
            this.Day1_StartTime.Location = new System.Drawing.Point(6, 174);
            this.Day1_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day1_StartTime.Name = "Day1_StartTime";
            this.Day1_StartTime.Size = new System.Drawing.Size(92, 21);
            this.Day1_StartTime.TabIndex = 18;
            this.Day1_StartTime.SelectedIndexChanged += new System.EventHandler(this.Day1_StartTime_SelectedIndexChanged);
            // 
            // Day6_EndTime
            // 
            this.Day6_EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day6_EndTime.Enabled = false;
            this.Day6_EndTime.FormattingEnabled = true;
            this.Day6_EndTime.Location = new System.Drawing.Point(605, 225);
            this.Day6_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day6_EndTime.Name = "Day6_EndTime";
            this.Day6_EndTime.Size = new System.Drawing.Size(92, 21);
            this.Day6_EndTime.TabIndex = 19;
            // 
            // Day6_StartTime
            // 
            this.Day6_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day6_StartTime.Enabled = false;
            this.Day6_StartTime.FormattingEnabled = true;
            this.Day6_StartTime.Location = new System.Drawing.Point(606, 174);
            this.Day6_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.Day6_StartTime.Name = "Day6_StartTime";
            this.Day6_StartTime.Size = new System.Drawing.Size(92, 21);
            this.Day6_StartTime.TabIndex = 20;
            this.Day6_StartTime.SelectedIndexChanged += new System.EventHandler(this.Day6_StartTime_SelectedIndexChanged);
            // 
            // Insert_constraines
            // 
            this.Insert_constraines.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_constraines.Location = new System.Drawing.Point(531, 285);
            this.Insert_constraines.Margin = new System.Windows.Forms.Padding(2);
            this.Insert_constraines.Name = "Insert_constraines";
            this.Insert_constraines.Size = new System.Drawing.Size(166, 49);
            this.Insert_constraines.TabIndex = 21;
            this.Insert_constraines.Text = "Insert constraines";
            this.Insert_constraines.UseVisualStyleBackColor = true;
            this.Insert_constraines.Click += new System.EventHandler(this.Insert_constraines_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "End time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "End time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Start time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "End time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "End time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Start time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Start time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(622, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "End time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 159);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Start time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 210);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "End time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 159);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Start time:";
            // 
            // Constraines_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 347);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insert_constraines);
            this.Controls.Add(this.Day6_StartTime);
            this.Controls.Add(this.Day6_EndTime);
            this.Controls.Add(this.Day1_StartTime);
            this.Controls.Add(this.Day1_EndTime);
            this.Controls.Add(this.Day2_StartTime);
            this.Controls.Add(this.Day2_EndTime);
            this.Controls.Add(this.Day3_StartTime);
            this.Controls.Add(this.Day3_EndTime);
            this.Controls.Add(this.Day4_StartTime);
            this.Controls.Add(this.Day4_EndTime);
            this.Controls.Add(this.Day5_StartTime);
            this.Controls.Add(this.Day5_EndTime);
            this.Controls.Add(this.Day6);
            this.Controls.Add(this.Day5);
            this.Controls.Add(this.Day4);
            this.Controls.Add(this.Day3);
            this.Controls.Add(this.Day2);
            this.Controls.Add(this.Day1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Constraines_Form";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Constrains";
            this.Load += new System.EventHandler(this.Practitioner_Constraines_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Day1;
        private System.Windows.Forms.CheckBox Day2;
        private System.Windows.Forms.CheckBox Day3;
        private System.Windows.Forms.CheckBox Day4;
        private System.Windows.Forms.CheckBox Day5;
        private System.Windows.Forms.CheckBox Day6;
        private System.Windows.Forms.ComboBox Day5_EndTime;
        private System.Windows.Forms.ComboBox Day5_StartTime;
        private System.Windows.Forms.ComboBox Day4_EndTime;
        private System.Windows.Forms.ComboBox Day4_StartTime;
        private System.Windows.Forms.ComboBox Day3_EndTime;
        private System.Windows.Forms.ComboBox Day3_StartTime;
        private System.Windows.Forms.ComboBox Day2_EndTime;
        private System.Windows.Forms.ComboBox Day2_StartTime;
        private System.Windows.Forms.ComboBox Day1_EndTime;
        private System.Windows.Forms.ComboBox Day1_StartTime;
        private System.Windows.Forms.ComboBox Day6_EndTime;
        private System.Windows.Forms.ComboBox Day6_StartTime;
        private System.Windows.Forms.Button Insert_constraines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}