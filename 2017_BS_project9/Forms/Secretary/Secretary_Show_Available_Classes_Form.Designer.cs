namespace _2017_BS_project9.Forms
{
    partial class Secretary_Show_Available_Classes_Form
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
            this.EndTime = new System.Windows.Forms.ComboBox();
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Classes = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndTime
            // 
            this.EndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTime.Enabled = false;
            this.EndTime.FormattingEnabled = true;
            this.EndTime.Location = new System.Drawing.Point(97, 234);
            this.EndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(121, 24);
            this.EndTime.TabIndex = 0;
            this.EndTime.SelectedIndexChanged += new System.EventHandler(this.EndTime_SelectedIndexChanged);
            // 
            // StartTime
            // 
            this.StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTime.Enabled = false;
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Location = new System.Drawing.Point(97, 170);
            this.StartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(121, 24);
            this.StartTime.TabIndex = 1;
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged);
            // 
            // Day
            // 
            this.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(97, 105);
            this.Day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(121, 24);
            this.Day.TabIndex = 2;
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // Classes
            // 
            this.Classes.FormattingEnabled = true;
            this.Classes.ItemHeight = 16;
            this.Classes.Location = new System.Drawing.Point(364, 98);
            this.Classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(169, 244);
            this.Classes.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(97, 295);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 43);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please select a day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please select a start time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please select an end time";
            // 
            // Secretary_Show_Available_Classes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Secretary_Show_Available_Classes_Form";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Show Available Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EndTime;
        private System.Windows.Forms.ComboBox StartTime;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ListBox Classes;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}