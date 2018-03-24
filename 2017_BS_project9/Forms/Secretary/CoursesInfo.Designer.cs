namespace _2017_BS_project9
{
    partial class CoursesInfo
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
            this.courses_list_box = new System.Windows.Forms.ListBox();
            this.lectures_list_box = new System.Windows.Forms.ListBox();
            this.practices_list_box = new System.Windows.Forms.ListBox();
            this.lab_list_box = new System.Windows.Forms.ListBox();
            this.lab_lactur = new System.Windows.Forms.Label();
            this.lab_day = new System.Windows.Forms.Label();
            this.lab_start = new System.Windows.Forms.Label();
            this.lab_end = new System.Windows.Forms.Label();
            this.lab_room = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courses_list_box
            // 
            this.courses_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.courses_list_box.FormattingEnabled = true;
            this.courses_list_box.ItemHeight = 30;
            this.courses_list_box.Location = new System.Drawing.Point(23, 73);
            this.courses_list_box.Name = "courses_list_box";
            this.courses_list_box.Size = new System.Drawing.Size(179, 454);
            this.courses_list_box.TabIndex = 6;
            this.courses_list_box.SelectedIndexChanged += new System.EventHandler(this.courses_list_box_SelectedIndexChanged);
            // 
            // lectures_list_box
            // 
            this.lectures_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lectures_list_box.FormattingEnabled = true;
            this.lectures_list_box.ItemHeight = 30;
            this.lectures_list_box.Location = new System.Drawing.Point(286, 109);
            this.lectures_list_box.Name = "lectures_list_box";
            this.lectures_list_box.Size = new System.Drawing.Size(190, 94);
            this.lectures_list_box.TabIndex = 26;
            this.lectures_list_box.SelectedIndexChanged += new System.EventHandler(this.lectures_list_SelectedIndexChanged);
            // 
            // practices_list_box
            // 
            this.practices_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.practices_list_box.FormattingEnabled = true;
            this.practices_list_box.ItemHeight = 30;
            this.practices_list_box.Location = new System.Drawing.Point(285, 269);
            this.practices_list_box.Name = "practices_list_box";
            this.practices_list_box.Size = new System.Drawing.Size(190, 124);
            this.practices_list_box.TabIndex = 27;
            this.practices_list_box.SelectedIndexChanged += new System.EventHandler(this.practices_list_SelectedIndexChanged);
            // 
            // lab_list_box
            // 
            this.lab_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_list_box.FormattingEnabled = true;
            this.lab_list_box.ItemHeight = 30;
            this.lab_list_box.Location = new System.Drawing.Point(285, 433);
            this.lab_list_box.Name = "lab_list_box";
            this.lab_list_box.Size = new System.Drawing.Size(190, 94);
            this.lab_list_box.TabIndex = 28;
            this.lab_list_box.SelectedIndexChanged += new System.EventHandler(this.lab_list_SelectedIndexChanged);
            // 
            // lab_lactur
            // 
            this.lab_lactur.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_lactur.Location = new System.Drawing.Point(492, 165);
            this.lab_lactur.Name = "lab_lactur";
            this.lab_lactur.Size = new System.Drawing.Size(291, 60);
            this.lab_lactur.TabIndex = 29;
            this.lab_lactur.Text = "Lecture";
            this.lab_lactur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_day
            // 
            this.lab_day.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_day.Location = new System.Drawing.Point(487, 235);
            this.lab_day.Name = "lab_day";
            this.lab_day.Size = new System.Drawing.Size(296, 60);
            this.lab_day.TabIndex = 30;
            this.lab_day.Text = "day";
            this.lab_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_start
            // 
            this.lab_start.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_start.Location = new System.Drawing.Point(487, 302);
            this.lab_start.Name = "lab_start";
            this.lab_start.Size = new System.Drawing.Size(152, 56);
            this.lab_start.TabIndex = 31;
            this.lab_start.Text = "start";
            this.lab_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_end
            // 
            this.lab_end.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_end.Location = new System.Drawing.Point(673, 298);
            this.lab_end.Name = "lab_end";
            this.lab_end.Size = new System.Drawing.Size(131, 60);
            this.lab_end.TabIndex = 32;
            this.lab_end.Text = "end";
            this.lab_end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_room
            // 
            this.lab_room.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_room.Location = new System.Drawing.Point(497, 371);
            this.lab_room.Name = "lab_room";
            this.lab_room.Size = new System.Drawing.Size(286, 60);
            this.lab_room.TabIndex = 33;
            this.lab_room.Text = "room";
            this.lab_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(286, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "lecture:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label2.Location = new System.Drawing.Point(286, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 60);
            this.label2.TabIndex = 36;
            this.label2.Text = "Practice: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label3.Location = new System.Drawing.Point(286, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 37);
            this.label3.TabIndex = 37;
            this.label3.Text = "Lab:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoursesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_room);
            this.Controls.Add(this.lab_end);
            this.Controls.Add(this.lab_start);
            this.Controls.Add(this.lab_day);
            this.Controls.Add(this.lab_lactur);
            this.Controls.Add(this.lab_list_box);
            this.Controls.Add(this.practices_list_box);
            this.Controls.Add(this.lectures_list_box);
            this.Controls.Add(this.courses_list_box);
            this.Name = "CoursesInfo";
            this.Text = "Courses_Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox courses_list_box;
        private System.Windows.Forms.ListBox lectures_list_box;
        private System.Windows.Forms.ListBox practices_list_box;
        private System.Windows.Forms.ListBox lab_list_box;
        private System.Windows.Forms.Label lab_lactur;
        private System.Windows.Forms.Label lab_day;
        private System.Windows.Forms.Label lab_start;
        private System.Windows.Forms.Label lab_end;
        private System.Windows.Forms.Label lab_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}