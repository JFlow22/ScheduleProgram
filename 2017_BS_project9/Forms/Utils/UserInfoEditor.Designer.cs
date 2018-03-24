namespace _2017_BS_project9
{
    partial class UserInfoEditor
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sem_sbox = new System.Windows.Forms.ComboBox();
            this.pwd_input = new System.Windows.Forms.TextBox();
            this.id_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(316, 279);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sem_sbox);
            this.panel2.Controls.Add(this.pwd_input);
            this.panel2.Controls.Add(this.id_input);
            this.panel2.Controls.Add(this.name_input);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 279);
            this.panel2.TabIndex = 18;
            // 
            // sem_sbox
            // 
            this.sem_sbox.Enabled = false;
            this.sem_sbox.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.sem_sbox.FormattingEnabled = true;
            this.sem_sbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.sem_sbox.Location = new System.Drawing.Point(0, 174);
            this.sem_sbox.Name = "sem_sbox";
            this.sem_sbox.Size = new System.Drawing.Size(194, 38);
            this.sem_sbox.TabIndex = 23;
            // 
            // pwd_input
            // 
            this.pwd_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd_input.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.pwd_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pwd_input.Location = new System.Drawing.Point(0, 120);
            this.pwd_input.Name = "pwd_input";
            this.pwd_input.Size = new System.Drawing.Size(194, 36);
            this.pwd_input.TabIndex = 21;
            this.pwd_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwd_input.UseSystemPasswordChar = true;
            // 
            // id_input
            // 
            this.id_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_input.Enabled = false;
            this.id_input.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.id_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.id_input.Location = new System.Drawing.Point(0, 65);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(194, 36);
            this.id_input.TabIndex = 20;
            this.id_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_input
            // 
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_input.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.name_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.name_input.Location = new System.Drawing.Point(0, 10);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(194, 36);
            this.name_input.TabIndex = 17;
            this.name_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 279);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label6.Location = new System.Drawing.Point(0, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 55);
            this.label6.TabIndex = 16;
            this.label6.Text = "SEMESTER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label3.Location = new System.Drawing.Point(0, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_btn
            // 
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.save_btn.Location = new System.Drawing.Point(20, 278);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(316, 61);
            this.save_btn.TabIndex = 16;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // UserInfoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 359);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "UserInfoEditor";
            this.Resizable = false;
            this.Text = "Personal Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VewUpdateUserInfo_FormClosed);
            this.Load += new System.EventHandler(this.crudUserInfo_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sem_sbox;
        private System.Windows.Forms.TextBox pwd_input;
        private System.Windows.Forms.Button save_btn;
    }
}
