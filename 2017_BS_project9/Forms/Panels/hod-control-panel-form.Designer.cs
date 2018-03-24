namespace _2017_BS_project9
{
    partial class HODControlPanelForm
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
            this.info_btn = new MetroFramework.Controls.MetroTile();
            this.course_info_btn = new MetroFramework.Controls.MetroTile();
            this.button4 = new MetroFramework.Controls.MetroTile();
            this.button3 = new MetroFramework.Controls.MetroTile();
            this.userNameLable = new System.Windows.Forms.Label();
            this.facebook_login_btn = new _2017_BS_project9.FacebookButton();
            this.SuspendLayout();
            // 
            // info_btn
            // 
            this.info_btn.ActiveControl = null;
            this.info_btn.Location = new System.Drawing.Point(12, 76);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(153, 293);
            this.info_btn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.info_btn.TabIndex = 4;
            this.info_btn.Text = "Personal Info";
            this.info_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.info_btn.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.info_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.info_btn.UseSelectable = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // course_info_btn
            // 
            this.course_info_btn.ActiveControl = null;
            this.course_info_btn.Location = new System.Drawing.Point(386, 76);
            this.course_info_btn.Name = "course_info_btn";
            this.course_info_btn.Size = new System.Drawing.Size(426, 69);
            this.course_info_btn.Style = MetroFramework.MetroColorStyle.Teal;
            this.course_info_btn.TabIndex = 6;
            this.course_info_btn.Text = "Build_curriculum";
            this.course_info_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.course_info_btn.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.course_info_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.course_info_btn.UseSelectable = true;
            this.course_info_btn.Click += new System.EventHandler(this.course_info_btn_Click);
            // 
            // button4
            // 
            this.button4.ActiveControl = null;
            this.button4.Location = new System.Drawing.Point(532, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 218);
            this.button4.TabIndex = 6;
            this.button4.Text = "View Work Houres";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.button4.UseSelectable = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ActiveControl = null;
            this.button3.Location = new System.Drawing.Point(171, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 218);
            this.button3.Style = MetroFramework.MetroColorStyle.Green;
            this.button3.TabIndex = 9;
            this.button3.Text = "Enter Courses";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLable.Location = new System.Drawing.Point(578, 43);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameLable.Size = new System.Drawing.Size(155, 30);
            this.userNameLable.TabIndex = 11;
            this.userNameLable.Text = "Welcome, name";
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // facebook_login_btn
            // 
            this.facebook_login_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook_login_btn.Location = new System.Drawing.Point(171, 76);
            this.facebook_login_btn.Name = "facebook_login_btn";
            this.facebook_login_btn.Size = new System.Drawing.Size(209, 69);
            this.facebook_login_btn.TabIndex = 13;
            this.facebook_login_btn.Text = "Facebook Login";
            this.facebook_login_btn.UseVisualStyleBackColor = true;
            this.facebook_login_btn.Click += new System.EventHandler(this.facebook_login_btn_Click);
            // 
            // HODControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 382);
            this.Controls.Add(this.facebook_login_btn);
            this.Controls.Add(this.userNameLable);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.course_info_btn);
            this.Controls.Add(this.info_btn);
            this.MaximizeBox = false;
            this.Name = "HODControlPanelForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Head of Department control panel";
            this.Load += new System.EventHandler(this.HODControlPanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile info_btn;
        private MetroFramework.Controls.MetroTile course_info_btn;
        private MetroFramework.Controls.MetroTile button4;
        private MetroFramework.Controls.MetroTile button3;
        private System.Windows.Forms.Label userNameLable;
        private FacebookButton facebook_login_btn;
    }
}