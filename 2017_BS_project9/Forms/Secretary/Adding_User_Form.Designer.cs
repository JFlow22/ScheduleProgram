namespace _2017_BS_project9.Forms
{
    partial class Adding_User_Form
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
            this.name_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pwd_input = new System.Windows.Forms.TextBox();
            this.Adding = new System.Windows.Forms.Button();
            this.type_input = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.startTime_combo = new System.Windows.Forms.ComboBox();
            this.endTime_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.day_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(158, 76);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(176, 24);
            this.name_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(158, 122);
            this.id_input.Multiline = true;
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(176, 24);
            this.id_input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // pwd_input
            // 
            this.pwd_input.Location = new System.Drawing.Point(158, 164);
            this.pwd_input.Multiline = true;
            this.pwd_input.Name = "pwd_input";
            this.pwd_input.Size = new System.Drawing.Size(176, 24);
            this.pwd_input.TabIndex = 6;
            // 
            // Adding
            // 
            this.Adding.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adding.Location = new System.Drawing.Point(28, 394);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(137, 48);
            this.Adding.TabIndex = 7;
            this.Adding.Text = "Add";
            this.Adding.UseVisualStyleBackColor = true;
            this.Adding.Click += new System.EventHandler(this.Adding_Click);
            // 
            // type_input
            // 
            this.type_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_input.FormattingEnabled = true;
            this.type_input.Items.AddRange(new object[] {
            "Lecturer",
            "Practitioner"});
            this.type_input.Location = new System.Drawing.Point(158, 212);
            this.type_input.Name = "type_input";
            this.type_input.Size = new System.Drawing.Size(176, 21);
            this.type_input.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type:";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(194, 394);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 48);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Acc. Hours Start:";
            // 
            // startTime_combo
            // 
            this.startTime_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTime_combo.FormattingEnabled = true;
            this.startTime_combo.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.startTime_combo.Location = new System.Drawing.Point(172, 305);
            this.startTime_combo.Name = "startTime_combo";
            this.startTime_combo.Size = new System.Drawing.Size(162, 21);
            this.startTime_combo.TabIndex = 12;
            // 
            // endTime_combo
            // 
            this.endTime_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTime_combo.FormattingEnabled = true;
            this.endTime_combo.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.endTime_combo.Location = new System.Drawing.Point(172, 348);
            this.endTime_combo.Name = "endTime_combo";
            this.endTime_combo.Size = new System.Drawing.Size(161, 21);
            this.endTime_combo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Acc. Hours End:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Acc. Day:";
            // 
            // day_combo
            // 
            this.day_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_combo.FormattingEnabled = true;
            this.day_combo.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.day_combo.Location = new System.Drawing.Point(158, 262);
            this.day_combo.Name = "day_combo";
            this.day_combo.Size = new System.Drawing.Size(176, 21);
            this.day_combo.TabIndex = 17;
            // 
            // Adding_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.day_combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endTime_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTime_combo);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type_input);
            this.Controls.Add(this.Adding);
            this.Controls.Add(this.pwd_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_input);
            this.Name = "Adding_User_Form";
            this.Text = "Adding A User";
            this.Load += new System.EventHandler(this.AddPractitioner_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwd_input;
        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.ComboBox type_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox startTime_combo;
        private System.Windows.Forms.ComboBox endTime_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox day_combo;
    }
}