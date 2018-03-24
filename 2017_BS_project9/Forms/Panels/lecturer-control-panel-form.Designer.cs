namespace _2017_BS_project9
{
    partial class Lecturer_Form
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
            this.Constraines = new MetroFramework.Controls.MetroTile();
            this.UpdateDB = new MetroFramework.Controls.MetroTile();
            this.Class_Request = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new MetroFramework.Controls.MetroTile();
            this.button2 = new MetroFramework.Controls.MetroTile();
            this.facebook_login_btn = new _2017_BS_project9.FacebookButton();
            this.SuspendLayout();
            // 
            // Constraines
            // 
            this.Constraines.ActiveControl = null;
            this.Constraines.Location = new System.Drawing.Point(509, 158);
            this.Constraines.Name = "Constraines";
            this.Constraines.Size = new System.Drawing.Size(264, 61);
            this.Constraines.Style = MetroFramework.MetroColorStyle.Purple;
            this.Constraines.TabIndex = 4;
            this.Constraines.Text = "Constraines";
            this.Constraines.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Constraines.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Constraines.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Constraines.UseSelectable = true;
            this.Constraines.Click += new System.EventHandler(this.Constraines_Click);
            // 
            // UpdateDB
            // 
            this.UpdateDB.ActiveControl = null;
            this.UpdateDB.Location = new System.Drawing.Point(12, 87);
            this.UpdateDB.Name = "UpdateDB";
            this.UpdateDB.Size = new System.Drawing.Size(316, 174);
            this.UpdateDB.Style = MetroFramework.MetroColorStyle.Green;
            this.UpdateDB.TabIndex = 6;
            this.UpdateDB.Text = "Update";
            this.UpdateDB.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UpdateDB.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UpdateDB.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UpdateDB.UseSelectable = true;
            this.UpdateDB.Click += new System.EventHandler(this.Update_Click);
            // 
            // Class_Request
            // 
            this.Class_Request.ActiveControl = null;
            this.Class_Request.Location = new System.Drawing.Point(509, 225);
            this.Class_Request.Name = "Class_Request";
            this.Class_Request.Size = new System.Drawing.Size(264, 107);
            this.Class_Request.Style = MetroFramework.MetroColorStyle.Red;
            this.Class_Request.TabIndex = 7;
            this.Class_Request.Text = "Class Request";
            this.Class_Request.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Class_Request.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Class_Request.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Class_Request.UseSelectable = true;
            this.Class_Request.Click += new System.EventHandler(this.Class_Request_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(504, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welocme, Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.ActiveControl = null;
            this.button1.Location = new System.Drawing.Point(12, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 65);
            this.button1.Style = MetroFramework.MetroColorStyle.Orange;
            this.button1.TabIndex = 10;
            this.button1.Text = "Limit student in lecture";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ActiveControl = null;
            this.button2.Location = new System.Drawing.Point(334, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 245);
            this.button2.Style = MetroFramework.MetroColorStyle.Blue;
            this.button2.TabIndex = 11;
            this.button2.Text = "request practitioner";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // facebook_login_btn
            // 
            this.facebook_login_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook_login_btn.Location = new System.Drawing.Point(509, 87);
            this.facebook_login_btn.Name = "facebook_login_btn";
            this.facebook_login_btn.Size = new System.Drawing.Size(264, 65);
            this.facebook_login_btn.TabIndex = 13;
            this.facebook_login_btn.Text = "Facebook Login";
            this.facebook_login_btn.UseVisualStyleBackColor = true;
            this.facebook_login_btn.Click += new System.EventHandler(this.facebook_login_btn_Click);
            // 
            // Lecturer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 345);
            this.Controls.Add(this.facebook_login_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Class_Request);
            this.Controls.Add(this.UpdateDB);
            this.Controls.Add(this.Constraines);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Lecturer_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Lecturer control panel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile Constraines;
        private MetroFramework.Controls.MetroTile UpdateDB;
        private MetroFramework.Controls.MetroTile Class_Request;
        private MetroFramework.Controls.MetroTile button1;
        private MetroFramework.Controls.MetroTile button2;
        private FacebookButton facebook_login_btn;
    }
}