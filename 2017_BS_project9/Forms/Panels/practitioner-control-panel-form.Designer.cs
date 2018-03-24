namespace _2017_BS_project9
{
    partial class Practitioner_Form
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
            this.UpdateDB = new MetroFramework.Controls.MetroTile();
            this.Constraines = new MetroFramework.Controls.MetroTile();
            this.Class_Request = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.facebook_login_btn = new _2017_BS_project9.FacebookButton();
            this.SuspendLayout();
            // 
            // UpdateDB
            // 
            this.UpdateDB.ActiveControl = null;
            this.UpdateDB.Location = new System.Drawing.Point(170, 152);
            this.UpdateDB.Name = "UpdateDB";
            this.UpdateDB.Size = new System.Drawing.Size(485, 112);
            this.UpdateDB.Style = MetroFramework.MetroColorStyle.Purple;
            this.UpdateDB.TabIndex = 2;
            this.UpdateDB.Text = "Update details";
            this.UpdateDB.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UpdateDB.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UpdateDB.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UpdateDB.UseSelectable = true;
            this.UpdateDB.Click += new System.EventHandler(this.Update_Click);
            // 
            // Constraines
            // 
            this.Constraines.ActiveControl = null;
            this.Constraines.Location = new System.Drawing.Point(11, 81);
            this.Constraines.Name = "Constraines";
            this.Constraines.Size = new System.Drawing.Size(153, 183);
            this.Constraines.Style = MetroFramework.MetroColorStyle.Green;
            this.Constraines.TabIndex = 3;
            this.Constraines.Text = "Constraines";
            this.Constraines.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Constraines.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Constraines.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Constraines.UseSelectable = true;
            this.Constraines.Click += new System.EventHandler(this.Constraines_Click);
            // 
            // Class_Request
            // 
            this.Class_Request.ActiveControl = null;
            this.Class_Request.Location = new System.Drawing.Point(385, 81);
            this.Class_Request.Name = "Class_Request";
            this.Class_Request.Size = new System.Drawing.Size(270, 65);
            this.Class_Request.Style = MetroFramework.MetroColorStyle.Blue;
            this.Class_Request.TabIndex = 4;
            this.Class_Request.Text = "Class Request";
            this.Class_Request.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Class_Request.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Class_Request.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Class_Request.UseSelectable = true;
            this.Class_Request.Click += new System.EventHandler(this.Class_Request_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome, Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // facebook_login_btn
            // 
            this.facebook_login_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook_login_btn.Location = new System.Drawing.Point(170, 81);
            this.facebook_login_btn.Name = "facebook_login_btn";
            this.facebook_login_btn.Size = new System.Drawing.Size(209, 65);
            this.facebook_login_btn.TabIndex = 13;
            this.facebook_login_btn.Text = "Facebook Login";
            this.facebook_login_btn.UseVisualStyleBackColor = true;
            this.facebook_login_btn.Click += new System.EventHandler(this.facebook_login_btn_Click);
            // 
            // Practitioner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 274);
            this.Controls.Add(this.facebook_login_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Class_Request);
            this.Controls.Add(this.Constraines);
            this.Controls.Add(this.UpdateDB);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Practitioner_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = " Practitioner control panel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile UpdateDB;
        private MetroFramework.Controls.MetroTile Constraines;
        private MetroFramework.Controls.MetroTile Class_Request;
        private FacebookButton facebook_login_btn;
    }
}