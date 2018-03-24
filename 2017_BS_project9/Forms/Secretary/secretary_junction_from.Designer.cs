namespace _2017_BS_project9
{
    partial class secretary_junction_from
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.userNameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose desired option";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Schedule students menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.button2.Location = new System.Drawing.Point(230, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Scheudle staff menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // info_btn
            // 
            this.info_btn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.info_btn.Location = new System.Drawing.Point(7, 171);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(440, 59);
            this.info_btn.TabIndex = 3;
            this.info_btn.Text = "View details";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // userNameLable
            // 
            this.userNameLable.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLable.Location = new System.Drawing.Point(7, 23);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(440, 37);
            this.userNameLable.TabIndex = 4;
            this.userNameLable.Text = "Welcome, name";
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secretary_junction_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 241);
            this.Controls.Add(this.userNameLable);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "secretary_junction_from";
            this.Resizable = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Label userNameLable;
    }
}