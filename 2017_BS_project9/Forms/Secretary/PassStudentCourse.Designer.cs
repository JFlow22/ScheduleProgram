namespace _2017_BS_project9
{
    partial class PassStudentCourse
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
            this.student_list = new MetroFramework.Controls.MetroComboBox();
            this.courses_list = new MetroFramework.Controls.MetroComboBox();
            this.pass_btn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // student_list
            // 
            this.student_list.DropDownHeight = 120;
            this.student_list.FormattingEnabled = true;
            this.student_list.IntegralHeight = false;
            this.student_list.ItemHeight = 23;
            this.student_list.Location = new System.Drawing.Point(23, 99);
            this.student_list.Name = "student_list";
            this.student_list.Size = new System.Drawing.Size(409, 29);
            this.student_list.TabIndex = 0;
            this.student_list.UseSelectable = true;
            this.student_list.SelectedIndexChanged += new System.EventHandler(this.student_list_SelectedIndexChanged);
            // 
            // courses_list
            // 
            this.courses_list.DropDownHeight = 120;
            this.courses_list.FormattingEnabled = true;
            this.courses_list.IntegralHeight = false;
            this.courses_list.ItemHeight = 23;
            this.courses_list.Location = new System.Drawing.Point(23, 153);
            this.courses_list.Name = "courses_list";
            this.courses_list.Size = new System.Drawing.Size(409, 29);
            this.courses_list.TabIndex = 1;
            this.courses_list.UseSelectable = true;
            // 
            // pass_btn
            // 
            this.pass_btn.ActiveControl = null;
            this.pass_btn.Location = new System.Drawing.Point(160, 206);
            this.pass_btn.Name = "pass_btn";
            this.pass_btn.Size = new System.Drawing.Size(134, 48);
            this.pass_btn.TabIndex = 2;
            this.pass_btn.Text = "Pass";
            this.pass_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pass_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.pass_btn.UseSelectable = true;
            this.pass_btn.Click += new System.EventHandler(this.pass_btn_Click);
            // 
            // PassStudentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 277);
            this.Controls.Add(this.pass_btn);
            this.Controls.Add(this.courses_list);
            this.Controls.Add(this.student_list);
            this.Name = "PassStudentCourse";
            this.Text = "PassStudentCourse";
            this.Load += new System.EventHandler(this.PassStudentCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox student_list;
        private MetroFramework.Controls.MetroComboBox courses_list;
        private MetroFramework.Controls.MetroTile pass_btn;
    }
}