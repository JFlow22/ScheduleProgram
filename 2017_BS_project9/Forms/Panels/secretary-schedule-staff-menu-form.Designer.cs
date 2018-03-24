namespace _2017_BS_project9
{
    partial class SecretarySchduleStaffForm
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
            this.add_user_button = new MetroFramework.Controls.MetroTile();
            this.class_filter_by_type_button = new MetroFramework.Controls.MetroTile();
            this.practice_filter_button = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.lecture_filter_button = new MetroFramework.Controls.MetroTile();
            this.Change_Class = new MetroFramework.Controls.MetroTile();
            this.button1 = new MetroFramework.Controls.MetroTile();
            this.button2 = new MetroFramework.Controls.MetroTile();
            this.button3 = new MetroFramework.Controls.MetroTile();
            this.ShowPraLec = new MetroFramework.Controls.MetroTile();
            this.ChangeLecPracTime = new MetroFramework.Controls.MetroTile();
            this.AddLecture_button = new MetroFramework.Controls.MetroTile();
            this.button4 = new MetroFramework.Controls.MetroTile();
            this.AddPractice_button = new MetroFramework.Controls.MetroTile();
            this.facebook_login_btn = new _2017_BS_project9.FacebookButton();
            this.SuspendLayout();
            // 
            // add_user_button
            // 
            this.add_user_button.ActiveControl = null;
            this.add_user_button.Location = new System.Drawing.Point(762, 267);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(189, 90);
            this.add_user_button.Style = MetroFramework.MetroColorStyle.Teal;
            this.add_user_button.TabIndex = 0;
            this.add_user_button.Text = "Add staff member";
            this.add_user_button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.add_user_button.UseSelectable = true;
            this.add_user_button.Click += new System.EventHandler(this.Add_User_Click);
            // 
            // class_filter_by_type_button
            // 
            this.class_filter_by_type_button.ActiveControl = null;
            this.class_filter_by_type_button.Location = new System.Drawing.Point(860, 141);
            this.class_filter_by_type_button.Name = "class_filter_by_type_button";
            this.class_filter_by_type_button.Size = new System.Drawing.Size(91, 120);
            this.class_filter_by_type_button.Style = MetroFramework.MetroColorStyle.Green;
            this.class_filter_by_type_button.TabIndex = 2;
            this.class_filter_by_type_button.Text = "Class Filter";
            this.class_filter_by_type_button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.class_filter_by_type_button.UseSelectable = true;
            this.class_filter_by_type_button.Click += new System.EventHandler(this.class_filter_button_Click);
            // 
            // practice_filter_button
            // 
            this.practice_filter_button.ActiveControl = null;
            this.practice_filter_button.BackColor = System.Drawing.Color.White;
            this.practice_filter_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.practice_filter_button.Location = new System.Drawing.Point(186, 141);
            this.practice_filter_button.Name = "practice_filter_button";
            this.practice_filter_button.Size = new System.Drawing.Size(147, 120);
            this.practice_filter_button.Style = MetroFramework.MetroColorStyle.Orange;
            this.practice_filter_button.TabIndex = 3;
            this.practice_filter_button.Text = "Practice Filter";
            this.practice_filter_button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.practice_filter_button.UseSelectable = true;
            this.practice_filter_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.label2.Location = new System.Drawing.Point(651, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome, Your name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lecture_filter_button
            // 
            this.lecture_filter_button.ActiveControl = null;
            this.lecture_filter_button.Location = new System.Drawing.Point(498, 69);
            this.lecture_filter_button.Name = "lecture_filter_button";
            this.lecture_filter_button.Size = new System.Drawing.Size(147, 192);
            this.lecture_filter_button.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lecture_filter_button.TabIndex = 11;
            this.lecture_filter_button.Text = "Lecture Filter";
            this.lecture_filter_button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lecture_filter_button.UseSelectable = true;
            this.lecture_filter_button.Click += new System.EventHandler(this.lecture_filter_button_Click);
            // 
            // Change_Class
            // 
            this.Change_Class.ActiveControl = null;
            this.Change_Class.Location = new System.Drawing.Point(12, 141);
            this.Change_Class.Name = "Change_Class";
            this.Change_Class.Size = new System.Drawing.Size(168, 191);
            this.Change_Class.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Change_Class.TabIndex = 12;
            this.Change_Class.Text = "Change Class";
            this.Change_Class.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Change_Class.UseSelectable = true;
            this.Change_Class.Click += new System.EventHandler(this.Change_Class_Click);
            // 
            // button1
            // 
            this.button1.ActiveControl = null;
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 65);
            this.button1.Style = MetroFramework.MetroColorStyle.Red;
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete Lecturer/Practitioner";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.ActiveControl = null;
            this.button2.Location = new System.Drawing.Point(339, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 191);
            this.button2.Style = MetroFramework.MetroColorStyle.Silver;
            this.button2.TabIndex = 13;
            this.button2.Text = "View Constrainst";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_12);
            // 
            // button3
            // 
            this.button3.ActiveControl = null;
            this.button3.Location = new System.Drawing.Point(651, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 66);
            this.button3.Style = MetroFramework.MetroColorStyle.Lime;
            this.button3.TabIndex = 14;
            this.button3.Text = "substitute Lecturer\\ practitioner";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowPraLec
            // 
            this.ShowPraLec.ActiveControl = null;
            this.ShowPraLec.Location = new System.Drawing.Point(762, 363);
            this.ShowPraLec.Name = "ShowPraLec";
            this.ShowPraLec.Size = new System.Drawing.Size(189, 111);
            this.ShowPraLec.Style = MetroFramework.MetroColorStyle.Green;
            this.ShowPraLec.TabIndex = 13;
            this.ShowPraLec.Text = "Show Lecturer/   Practitioner";
            this.ShowPraLec.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ShowPraLec.UseSelectable = true;
            this.ShowPraLec.Click += new System.EventHandler(this.ShowPraLec_Click);
            // 
            // ChangeLecPracTime
            // 
            this.ChangeLecPracTime.ActiveControl = null;
            this.ChangeLecPracTime.Location = new System.Drawing.Point(12, 70);
            this.ChangeLecPracTime.Name = "ChangeLecPracTime";
            this.ChangeLecPracTime.Size = new System.Drawing.Size(321, 65);
            this.ChangeLecPracTime.Style = MetroFramework.MetroColorStyle.Teal;
            this.ChangeLecPracTime.TabIndex = 14;
            this.ChangeLecPracTime.Text = "Change Lecture/   Practice time";
            this.ChangeLecPracTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ChangeLecPracTime.UseSelectable = true;
            this.ChangeLecPracTime.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddLecture_button
            // 
            this.AddLecture_button.ActiveControl = null;
            this.AddLecture_button.Location = new System.Drawing.Point(12, 409);
            this.AddLecture_button.Name = "AddLecture_button";
            this.AddLecture_button.Size = new System.Drawing.Size(744, 65);
            this.AddLecture_button.Style = MetroFramework.MetroColorStyle.Lime;
            this.AddLecture_button.TabIndex = 15;
            this.AddLecture_button.Text = "Add Lecture";
            this.AddLecture_button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.AddLecture_button.UseSelectable = true;
            this.AddLecture_button.Click += new System.EventHandler(this.AddLecture_button_Click);
            // 
            // button4
            // 
            this.button4.ActiveControl = null;
            this.button4.Location = new System.Drawing.Point(186, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(337, 65);
            this.button4.TabIndex = 16;
            this.button4.Text = "Show classes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseSelectable = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddPractice_button
            // 
            this.AddPractice_button.ActiveControl = null;
            this.AddPractice_button.Location = new System.Drawing.Point(651, 141);
            this.AddPractice_button.Name = "AddPractice_button";
            this.AddPractice_button.Size = new System.Drawing.Size(203, 120);
            this.AddPractice_button.TabIndex = 17;
            this.AddPractice_button.Text = "Add Practice";
            this.AddPractice_button.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.AddPractice_button.UseSelectable = true;
            this.AddPractice_button.Click += new System.EventHandler(this.AddPractice_button_Click);
            // 
            // facebook_login_btn
            // 
            this.facebook_login_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook_login_btn.Location = new System.Drawing.Point(529, 267);
            this.facebook_login_btn.Name = "facebook_login_btn";
            this.facebook_login_btn.Size = new System.Drawing.Size(227, 136);
            this.facebook_login_btn.TabIndex = 18;
            this.facebook_login_btn.Text = "Facebook Login";
            this.facebook_login_btn.UseVisualStyleBackColor = true;
            this.facebook_login_btn.Click += new System.EventHandler(this.facebook_login_btn_Click);
            // 
            // SecretarySchduleStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(969, 486);
            this.Controls.Add(this.facebook_login_btn);
            this.Controls.Add(this.AddPractice_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddLecture_button);
            this.Controls.Add(this.ChangeLecPracTime);
            this.Controls.Add(this.ShowPraLec);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Change_Class);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lecture_filter_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.practice_filter_button);
            this.Controls.Add(this.class_filter_by_type_button);
            this.Controls.Add(this.add_user_button);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 402);
            this.Name = "SecretarySchduleStaffForm";
            this.Resizable = false;
            this.Text = "Secretary control panel";
            this.Load += new System.EventHandler(this.Secretary_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile add_user_button;
        private MetroFramework.Controls.MetroTile class_filter_by_type_button;
        private MetroFramework.Controls.MetroTile practice_filter_button;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile lecture_filter_button;
        private MetroFramework.Controls.MetroTile Change_Class;
        private MetroFramework.Controls.MetroTile button1;
        private MetroFramework.Controls.MetroTile button2;
        private MetroFramework.Controls.MetroTile button3;
        private MetroFramework.Controls.MetroTile ShowPraLec;
        private MetroFramework.Controls.MetroTile ChangeLecPracTime;
        private MetroFramework.Controls.MetroTile AddLecture_button;
        private MetroFramework.Controls.MetroTile button4;
        private MetroFramework.Controls.MetroTile AddPractice_button;
        private FacebookButton facebook_login_btn;
    }
}