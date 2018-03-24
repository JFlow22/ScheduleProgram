namespace _2017_BS_project9
{
    partial class CourseDetails
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
            this.course_name = new System.Windows.Forms.Label();
            this.course_ID = new System.Windows.Forms.Label();
            this.course_type = new System.Windows.Forms.Label();
            this.course_Lecturer = new System.Windows.Forms.Label();
            this.lecturers_list_box = new System.Windows.Forms.ListBox();
            this.courses_list_box = new System.Windows.Forms.ListBox();
            this.have_pract = new System.Windows.Forms.Label();
            this.have_lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // course_name
            // 
            this.course_name.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.course_name.Location = new System.Drawing.Point(377, 60);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(183, 58);
            this.course_name.TabIndex = 34;
            this.course_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_ID
            // 
            this.course_ID.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.course_ID.Location = new System.Drawing.Point(377, 118);
            this.course_ID.Name = "course_ID";
            this.course_ID.Size = new System.Drawing.Size(183, 59);
            this.course_ID.TabIndex = 35;
            this.course_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_type
            // 
            this.course_type.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.course_type.Location = new System.Drawing.Point(382, 177);
            this.course_type.Name = "course_type";
            this.course_type.Size = new System.Drawing.Size(178, 59);
            this.course_type.TabIndex = 36;
            this.course_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_Lecturer
            // 
            this.course_Lecturer.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.course_Lecturer.Location = new System.Drawing.Point(387, 248);
            this.course_Lecturer.Name = "course_Lecturer";
            this.course_Lecturer.Size = new System.Drawing.Size(173, 59);
            this.course_Lecturer.TabIndex = 37;
            this.course_Lecturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturers_list_box
            // 
            this.lecturers_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lecturers_list_box.FormattingEnabled = true;
            this.lecturers_list_box.ItemHeight = 30;
            this.lecturers_list_box.Location = new System.Drawing.Point(23, 113);
            this.lecturers_list_box.Name = "lecturers_list_box";
            this.lecturers_list_box.Size = new System.Drawing.Size(150, 334);
            this.lecturers_list_box.TabIndex = 39;
            this.lecturers_list_box.SelectedIndexChanged += new System.EventHandler(this.lecturers_list_box_SelectedIndexChanged);
            // 
            // courses_list_box
            // 
            this.courses_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.courses_list_box.FormattingEnabled = true;
            this.courses_list_box.ItemHeight = 30;
            this.courses_list_box.Location = new System.Drawing.Point(190, 113);
            this.courses_list_box.Name = "courses_list_box";
            this.courses_list_box.Size = new System.Drawing.Size(160, 334);
            this.courses_list_box.TabIndex = 40;
            this.courses_list_box.SelectedIndexChanged += new System.EventHandler(this.courses_list_box_SelectedIndexChanged);
            // 
            // have_pract
            // 
            this.have_pract.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.have_pract.Location = new System.Drawing.Point(377, 307);
            this.have_pract.Name = "have_pract";
            this.have_pract.Size = new System.Drawing.Size(183, 58);
            this.have_pract.TabIndex = 41;
            this.have_pract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // have_lab
            // 
            this.have_lab.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.have_lab.Location = new System.Drawing.Point(377, 376);
            this.have_lab.Name = "have_lab";
            this.have_lab.Size = new System.Drawing.Size(183, 58);
            this.have_lab.TabIndex = 42;
            this.have_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 58);
            this.label1.TabIndex = 43;
            this.label1.Text = "lecturers:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label2.Location = new System.Drawing.Point(185, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 58);
            this.label2.TabIndex = 44;
            this.label2.Text = "courses:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.have_lab);
            this.Controls.Add(this.have_pract);
            this.Controls.Add(this.courses_list_box);
            this.Controls.Add(this.lecturers_list_box);
            this.Controls.Add(this.course_Lecturer);
            this.Controls.Add(this.course_type);
            this.Controls.Add(this.course_ID);
            this.Controls.Add(this.course_name);
            this.Name = "CourseDetails";
            this.Text = "CourseDetails";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label course_name;
        private System.Windows.Forms.Label course_ID;
        private System.Windows.Forms.Label course_type;
        private System.Windows.Forms.Label course_Lecturer;
        private System.Windows.Forms.ListBox lecturers_list_box;
        private System.Windows.Forms.ListBox courses_list_box;
        private System.Windows.Forms.Label have_pract;
        private System.Windows.Forms.Label have_lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}