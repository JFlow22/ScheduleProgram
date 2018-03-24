using System.Windows.Forms;
namespace _2017_BS_project9
{
    partial class StudentControlPanelForm
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
            this.userNameLable = new System.Windows.Forms.Label();
            this.warpper = new MetroFramework.Controls.MetroPanel();
            this.facebook_login_btn = new _2017_BS_project9.FacebookButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.courseBT = new MetroFramework.Controls.MetroTile();
            this.scheduler_btn = new MetroFramework.Controls.MetroTile();
            this.day_view = new MetroFramework.Controls.MetroTile();
            this.set_constrains_btn = new MetroFramework.Controls.MetroTile();
            this.week_view = new MetroFramework.Controls.MetroTile();
            this.info_btn = new MetroFramework.Controls.MetroTile();
            this.warpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.userNameLable.Location = new System.Drawing.Point(282, 20);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameLable.Size = new System.Drawing.Size(179, 32);
            this.userNameLable.TabIndex = 1;
            this.userNameLable.Text = "Welcome name ";
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // warpper
            // 
            this.warpper.Controls.Add(this.facebook_login_btn);
            this.warpper.Controls.Add(this.metroTile1);
            this.warpper.Controls.Add(this.courseBT);
            this.warpper.Controls.Add(this.scheduler_btn);
            this.warpper.Controls.Add(this.day_view);
            this.warpper.Controls.Add(this.set_constrains_btn);
            this.warpper.Controls.Add(this.week_view);
            this.warpper.Controls.Add(this.info_btn);
            this.warpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warpper.HorizontalScrollbarBarColor = true;
            this.warpper.HorizontalScrollbarHighlightOnWheel = false;
            this.warpper.HorizontalScrollbarSize = 0;
            this.warpper.Location = new System.Drawing.Point(20, 60);
            this.warpper.Name = "warpper";
            this.warpper.Size = new System.Drawing.Size(582, 279);
            this.warpper.TabIndex = 3;
            this.warpper.VerticalScrollbarBarColor = true;
            this.warpper.VerticalScrollbarHighlightOnWheel = false;
            this.warpper.VerticalScrollbarSize = 0;
            // 
            // facebook_login_btn
            // 
            this.facebook_login_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook_login_btn.Location = new System.Drawing.Point(212, 209);
            this.facebook_login_btn.Name = "facebook_login_btn";
            this.facebook_login_btn.Size = new System.Drawing.Size(209, 65);
            this.facebook_login_btn.TabIndex = 12;
            this.facebook_login_btn.Text = "Facebook Login";
            this.facebook_login_btn.UseVisualStyleBackColor = true;
            this.facebook_login_btn.Click += new System.EventHandler(this.facebook_login_btn_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroTile1.Location = new System.Drawing.Point(290, 106);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(131, 97);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Course \r\nDetails";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // courseBT
            // 
            this.courseBT.ActiveControl = null;
            this.courseBT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.courseBT.Location = new System.Drawing.Point(290, 3);
            this.courseBT.Name = "courseBT";
            this.courseBT.Size = new System.Drawing.Size(131, 97);
            this.courseBT.Style = MetroFramework.MetroColorStyle.Blue;
            this.courseBT.TabIndex = 10;
            this.courseBT.Text = "Course \r\nDetails by lect";
            this.courseBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.courseBT.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.courseBT.UseSelectable = true;
            this.courseBT.Click += new System.EventHandler(this.courseBT_Click);
            // 
            // scheduler_btn
            // 
            this.scheduler_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.scheduler_btn.ActiveControl = null;
            this.scheduler_btn.Location = new System.Drawing.Point(3, 209);
            this.scheduler_btn.Name = "scheduler_btn";
            this.scheduler_btn.Size = new System.Drawing.Size(203, 65);
            this.scheduler_btn.Style = MetroFramework.MetroColorStyle.Orange;
            this.scheduler_btn.TabIndex = 9;
            this.scheduler_btn.Text = "Scheduler";
            this.scheduler_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.scheduler_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.scheduler_btn.UseSelectable = true;
            this.scheduler_btn.Click += new System.EventHandler(this.scheduler_btn_click);
            // 
            // day_view
            // 
            this.day_view.ActiveControl = null;
            this.day_view.Location = new System.Drawing.Point(134, 3);
            this.day_view.Name = "day_view";
            this.day_view.Size = new System.Drawing.Size(150, 57);
            this.day_view.Style = MetroFramework.MetroColorStyle.Purple;
            this.day_view.TabIndex = 7;
            this.day_view.Text = "Day View";
            this.day_view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.day_view.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.day_view.UseSelectable = true;
            this.day_view.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // set_constrains_btn
            // 
            this.set_constrains_btn.ActiveControl = null;
            this.set_constrains_btn.Location = new System.Drawing.Point(427, 3);
            this.set_constrains_btn.Name = "set_constrains_btn";
            this.set_constrains_btn.Size = new System.Drawing.Size(150, 271);
            this.set_constrains_btn.Style = MetroFramework.MetroColorStyle.Brown;
            this.set_constrains_btn.TabIndex = 6;
            this.set_constrains_btn.Text = "Constrains";
            this.set_constrains_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.set_constrains_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.set_constrains_btn.UseSelectable = true;
            this.set_constrains_btn.Click += new System.EventHandler(this.set_constrains_btn_Click);
            // 
            // week_view
            // 
            this.week_view.ActiveControl = null;
            this.week_view.Location = new System.Drawing.Point(134, 66);
            this.week_view.Name = "week_view";
            this.week_view.Size = new System.Drawing.Size(150, 137);
            this.week_view.Style = MetroFramework.MetroColorStyle.Lime;
            this.week_view.TabIndex = 5;
            this.week_view.Text = "Week View";
            this.week_view.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.week_view.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.week_view.UseSelectable = true;
            this.week_view.Click += new System.EventHandler(this.week_view_Click);
            // 
            // info_btn
            // 
            this.info_btn.ActiveControl = null;
            this.info_btn.Location = new System.Drawing.Point(3, 3);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(125, 200);
            this.info_btn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.info_btn.TabIndex = 2;
            this.info_btn.Text = "Personal Info";
            this.info_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.info_btn.UseSelectable = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // StudentControlPanelForm
            // 
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.warpper);
            this.Controls.Add(this.userNameLable);
            this.MaximizeBox = false;
            this.Name = "StudentControlPanelForm";
            this.Resizable = false;
            this.Text = "Scheduler: Control Panel";
            this.Load += new System.EventHandler(this.ControlPanelForm_Load);
            this.warpper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userNameLable;
        private MetroFramework.Controls.MetroPanel warpper;
        private MetroFramework.Controls.MetroTile info_btn;
        private MetroFramework.Controls.MetroTile week_view;
        private MetroFramework.Controls.MetroTile set_constrains_btn;
        private MetroFramework.Controls.MetroTile day_view;
        private MetroFramework.Controls.MetroTile scheduler_btn;
        private MetroFramework.Controls.MetroTile courseBT;
        private MetroFramework.Controls.MetroTile metroTile1;
        private FacebookButton facebook_login_btn;
    }
}

