namespace _2017_BS_project9.Forms
{
    partial class Search_Class_By_Type_Form
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
            this.class_list = new System.Windows.Forms.ListBox();
            this.search_button = new System.Windows.Forms.Button();
            this.flag_is_lab = new System.Windows.Forms.CheckBox();
            this.flag_has_projector = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.projector_check = new System.Windows.Forms.CheckBox();
            this.lab_check = new System.Windows.Forms.CheckBox();
            this.update_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // class_list
            // 
            this.class_list.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_list.FormattingEnabled = true;
            this.class_list.ItemHeight = 21;
            this.class_list.Location = new System.Drawing.Point(257, 111);
            this.class_list.Name = "class_list";
            this.class_list.Size = new System.Drawing.Size(151, 193);
            this.class_list.TabIndex = 1;
            this.class_list.SelectedIndexChanged += new System.EventHandler(this.class_list_SelectedIndexChanged);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(50, 149);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(112, 35);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // flag_is_lab
            // 
            this.flag_is_lab.AutoSize = true;
            this.flag_is_lab.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag_is_lab.Location = new System.Drawing.Point(41, 45);
            this.flag_is_lab.Name = "flag_is_lab";
            this.flag_is_lab.Size = new System.Drawing.Size(70, 36);
            this.flag_is_lab.TabIndex = 3;
            this.flag_is_lab.Text = "Lab";
            this.flag_is_lab.UseVisualStyleBackColor = true;
            // 
            // flag_has_projector
            // 
            this.flag_has_projector.AutoSize = true;
            this.flag_has_projector.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag_has_projector.Location = new System.Drawing.Point(41, 88);
            this.flag_has_projector.Name = "flag_has_projector";
            this.flag_has_projector.Size = new System.Drawing.Size(124, 36);
            this.flag_has_projector.TabIndex = 4;
            this.flag_has_projector.Text = "Projector";
            this.flag_has_projector.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search And Change Type Of A Class";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flag_is_lab);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Controls.Add(this.flag_has_projector);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.projector_check);
            this.groupBox2.Controls.Add(this.lab_check);
            this.groupBox2.Controls.Add(this.update_button);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox2.Location = new System.Drawing.Point(435, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number Of Computers:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 29);
            this.textBox1.TabIndex = 6;
            // 
            // projector_check
            // 
            this.projector_check.AutoSize = true;
            this.projector_check.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projector_check.Location = new System.Drawing.Point(56, 66);
            this.projector_check.Name = "projector_check";
            this.projector_check.Size = new System.Drawing.Size(103, 29);
            this.projector_check.TabIndex = 5;
            this.projector_check.Text = "Projector";
            this.projector_check.UseVisualStyleBackColor = true;
            // 
            // lab_check
            // 
            this.lab_check.AutoSize = true;
            this.lab_check.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_check.Location = new System.Drawing.Point(56, 32);
            this.lab_check.Name = "lab_check";
            this.lab_check.Size = new System.Drawing.Size(60, 29);
            this.lab_check.TabIndex = 5;
            this.lab_check.Text = "Lab";
            this.lab_check.UseVisualStyleBackColor = true;
            this.lab_check.CheckedChanged += new System.EventHandler(this.lab_check_CheckedChanged);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(56, 149);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(112, 35);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(277, 333);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(112, 35);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Search_Class_By_Type_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 382);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class_list);
            this.MaximizeBox = false;
            this.Name = "Search_Class_By_Type_Form";
            this.Resizable = false;
            this.Text = "Search Class By Type";
            this.Load += new System.EventHandler(this.Search_Class_By_Type_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox class_list;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.CheckBox flag_is_lab;
        private System.Windows.Forms.CheckBox flag_has_projector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox projector_check;
        private System.Windows.Forms.CheckBox lab_check;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exit_button;
    }
}