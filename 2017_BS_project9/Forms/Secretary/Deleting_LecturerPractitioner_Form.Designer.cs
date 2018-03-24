namespace _2017_BS_project9.Forms
{
    partial class Deleting_LecturerPractitioner_Form
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
            this.delete_button = new System.Windows.Forms.Button();
            this.id_list = new System.Windows.Forms.ListBox();
            this.lecpra_combo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.delete_button.Location = new System.Drawing.Point(262, 271);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(139, 43);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.practice_filter_button_Click);
            // 
            // id_list
            // 
            this.id_list.Cursor = System.Windows.Forms.Cursors.Default;
            this.id_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_list.FormattingEnabled = true;
            this.id_list.ItemHeight = 18;
            this.id_list.Location = new System.Drawing.Point(23, 63);
            this.id_list.Name = "id_list";
            this.id_list.Size = new System.Drawing.Size(208, 310);
            this.id_list.TabIndex = 29;
            this.id_list.SelectedIndexChanged += new System.EventHandler(this.id_list_SelectedIndexChanged);
            // 
            // lecpra_combo
            // 
            this.lecpra_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lecpra_combo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecpra_combo.FormattingEnabled = true;
            this.lecpra_combo.Items.AddRange(new object[] {
            "Lecturer",
            "Practitioner"});
            this.lecpra_combo.Location = new System.Drawing.Point(262, 88);
            this.lecpra_combo.Name = "lecpra_combo";
            this.lecpra_combo.Size = new System.Drawing.Size(139, 29);
            this.lecpra_combo.TabIndex = 30;
            this.lecpra_combo.SelectedIndexChanged += new System.EventHandler(this.lecpra_combo_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lecturer",
            "Practitioner"});
            this.comboBox1.Location = new System.Drawing.Point(262, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 29);
            this.comboBox1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.button1.Location = new System.Drawing.Point(262, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Replacement :";
            // 
            // Deleting_LecturerPractitioner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lecpra_combo);
            this.Controls.Add(this.id_list);
            this.Controls.Add(this.delete_button);
            this.MaximizeBox = false;
            this.Name = "Deleting_LecturerPractitioner_Form";
            this.Resizable = false;
            this.Text = "Delete Lecturer/Practitioner";
            this.Load += new System.EventHandler(this.Deleting_LecturerPractitioner_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListBox id_list;
        private System.Windows.Forms.ComboBox lecpra_combo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}