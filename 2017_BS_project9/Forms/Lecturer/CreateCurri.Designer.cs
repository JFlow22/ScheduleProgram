namespace _2017_BS_project9
{
    partial class CreateCurri
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
            this.select_semester = new System.Windows.Forms.NumericUpDown();
            this.lab_lactur = new System.Windows.Forms.Label();
            this.semester_list_box = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.rem_btn = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.select_semester)).BeginInit();
            this.SuspendLayout();
            // 
            // courses_list_box
            // 
            this.courses_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.courses_list_box.FormattingEnabled = true;
            this.courses_list_box.ItemHeight = 30;
            this.courses_list_box.Location = new System.Drawing.Point(46, 93);
            this.courses_list_box.Name = "courses_list_box";
            this.courses_list_box.Size = new System.Drawing.Size(179, 454);
            this.courses_list_box.TabIndex = 7;
            this.courses_list_box.SelectedIndexChanged += new System.EventHandler(this.courses_list_box_SelectedIndexChanged);
            // 
            // select_semester
            // 
            this.select_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.select_semester.Location = new System.Drawing.Point(292, 93);
            this.select_semester.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.select_semester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_semester.Name = "select_semester";
            this.select_semester.Size = new System.Drawing.Size(175, 29);
            this.select_semester.TabIndex = 8;
            this.select_semester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.select_semester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_semester.ValueChanged += new System.EventHandler(this.select_semester_ValueChanged);
            // 
            // lab_lactur
            // 
            this.lab_lactur.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lab_lactur.Location = new System.Drawing.Point(264, 30);
            this.lab_lactur.Name = "lab_lactur";
            this.lab_lactur.Size = new System.Drawing.Size(223, 60);
            this.lab_lactur.TabIndex = 30;
            this.lab_lactur.Text = "Select a semester";
            this.lab_lactur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester_list_box
            // 
            this.semester_list_box.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.semester_list_box.FormattingEnabled = true;
            this.semester_list_box.ItemHeight = 30;
            this.semester_list_box.Location = new System.Drawing.Point(532, 93);
            this.semester_list_box.Name = "semester_list_box";
            this.semester_list_box.Size = new System.Drawing.Size(179, 454);
            this.semester_list_box.TabIndex = 31;
            this.semester_list_box.SelectedIndexChanged += new System.EventHandler(this.semester_list_box_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Green;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.add_btn.Location = new System.Drawing.Point(259, 260);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(250, 61);
            this.add_btn.TabIndex = 32;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // rem_btn
            // 
            this.rem_btn.BackColor = System.Drawing.Color.Red;
            this.rem_btn.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.rem_btn.Location = new System.Drawing.Point(259, 410);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(250, 61);
            this.rem_btn.TabIndex = 33;
            this.rem_btn.Text = "Remove";
            this.rem_btn.UseVisualStyleBackColor = false;
            this.rem_btn.Click += new System.EventHandler(this.rem_btn_Click);
            // 
            // saveBT
            // 
            this.saveBT.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBT.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.saveBT.Location = new System.Drawing.Point(198, 567);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(378, 49);
            this.saveBT.TabIndex = 34;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = false;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // CreateCurri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 639);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.rem_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.semester_list_box);
            this.Controls.Add(this.lab_lactur);
            this.Controls.Add(this.select_semester);
            this.Controls.Add(this.courses_list_box);
            this.Name = "CreateCurri";
            this.Text = "CreateCurri";
            ((System.ComponentModel.ISupportInitialize)(this.select_semester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox courses_list_box;
        private System.Windows.Forms.NumericUpDown select_semester;
        private System.Windows.Forms.Label lab_lactur;
        private System.Windows.Forms.ListBox semester_list_box;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button saveBT;
    }
}