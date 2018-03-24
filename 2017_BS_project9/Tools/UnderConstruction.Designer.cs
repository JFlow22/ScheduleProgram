namespace _2017_BS_project9
{
    partial class Under_Construction
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
            this.login_btn = new System.Windows.Forms.Button();
            this.lab_lactur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Red;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.login_btn.Location = new System.Drawing.Point(33, 236);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(298, 61);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "close";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // lab_lactur
            // 
            this.lab_lactur.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_lactur.Location = new System.Drawing.Point(62, 95);
            this.lab_lactur.Name = "lab_lactur";
            this.lab_lactur.Size = new System.Drawing.Size(231, 86);
            this.lab_lactur.TabIndex = 30;
            this.lab_lactur.Text = "This option is under construction";
            this.lab_lactur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Under_Construction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 347);
            this.Controls.Add(this.lab_lactur);
            this.Controls.Add(this.login_btn);
            this.Name = "Under_Construction";
            this.Text = "Under_Construction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label lab_lactur;
    }
}