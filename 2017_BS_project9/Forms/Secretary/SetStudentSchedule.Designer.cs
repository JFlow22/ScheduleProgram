namespace _2017_BS_project9
{
    partial class SetStudentSchedule
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
            this.student_list = new System.Windows.Forms.ListBox();
            this.set_schedule = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // student_list
            // 
            this.student_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.student_list.FormattingEnabled = true;
            this.student_list.ItemHeight = 30;
            this.student_list.Location = new System.Drawing.Point(23, 63);
            this.student_list.Name = "student_list";
            this.student_list.Size = new System.Drawing.Size(344, 334);
            this.student_list.TabIndex = 9;
            // 
            // set_schedule
            // 
            this.set_schedule.ActiveControl = null;
            this.set_schedule.Location = new System.Drawing.Point(23, 409);
            this.set_schedule.Name = "set_schedule";
            this.set_schedule.Size = new System.Drawing.Size(344, 43);
            this.set_schedule.Style = MetroFramework.MetroColorStyle.Green;
            this.set_schedule.TabIndex = 10;
            this.set_schedule.Text = "Set Schedule For Selected";
            this.set_schedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.set_schedule.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.set_schedule.UseSelectable = true;
            this.set_schedule.Click += new System.EventHandler(this.set_schedule_Click);
            // 
            // SetStudentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 474);
            this.Controls.Add(this.set_schedule);
            this.Controls.Add(this.student_list);
            this.Name = "SetStudentSchedule";
            this.Text = "Students List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox student_list;
        private MetroFramework.Controls.MetroTile set_schedule;
    }
}