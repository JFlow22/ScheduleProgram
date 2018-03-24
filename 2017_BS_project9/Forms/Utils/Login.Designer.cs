namespace _2017_BS_project9
{
    partial class Login
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
            this.user_Id_label = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.pwd_label = new System.Windows.Forms.Label();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.facebook_login_btn = new FacebookButton();
            this.SuspendLayout();
            // 
            // user_Id_label
            // 
            this.user_Id_label.Location = new System.Drawing.Point(14, 76);
            this.user_Id_label.Name = "user_Id_label";
            this.user_Id_label.Size = new System.Drawing.Size(251, 48);
            this.user_Id_label.TabIndex = 0;
            this.user_Id_label.Text = "User ID";
            this.user_Id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(20, 127);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(245, 39);
            this.id_textbox.TabIndex = 1;
            this.id_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pwd_label
            // 
            this.pwd_label.Location = new System.Drawing.Point(14, 172);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(251, 48);
            this.pwd_label.TabIndex = 2;
            this.pwd_label.Text = "Password";
            this.pwd_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Location = new System.Drawing.Point(20, 223);
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.PasswordChar = '*';
            this.pwd_textbox.Size = new System.Drawing.Size(245, 39);
            this.pwd_textbox.TabIndex = 3;
            this.pwd_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(20, 268);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(245, 50);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // facebook_login_btn
            // 
            this.facebook_login_btn.Location = new System.Drawing.Point(20, 324);
            this.facebook_login_btn.Name = "facebook_login_btn";
            this.facebook_login_btn.Size = new System.Drawing.Size(245, 52);
            this.facebook_login_btn.TabIndex = 5;
            this.facebook_login_btn.Text = "Facebook Login";
            this.facebook_login_btn.UseVisualStyleBackColor = true;
            this.facebook_login_btn.Click += new System.EventHandler(this.facebook_login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 385);
            this.Controls.Add(this.facebook_login_btn);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pwd_textbox);
            this.Controls.Add(this.pwd_label);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.user_Id_label);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(44, 147, 44, 49);
            this.Resizable = false;
            this.Text = "Schduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_Id_label;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.TextBox pwd_textbox;
        private System.Windows.Forms.Button login_button;
        private FacebookButton facebook_login_btn;
    }
}