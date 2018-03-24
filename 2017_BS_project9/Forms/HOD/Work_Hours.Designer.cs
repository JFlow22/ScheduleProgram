namespace _2017_BS_project9
{
    partial class Work_Hours
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_type_combo = new System.Windows.Forms.ComboBox();
            this.chart_title = new System.Windows.Forms.Label();
            this.lecturer_most_button = new System.Windows.Forms.Button();
            this.practitioner_most_button = new System.Windows.Forms.Button();
            this.All_lectures_radio = new System.Windows.Forms.RadioButton();
            this.all_practitioner_radio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lecturer_radio = new System.Windows.Forms.RadioButton();
            this.practitioner_radio = new System.Windows.Forms.RadioButton();
            this.lecturers_combo = new System.Windows.Forms.ComboBox();
            this.practitioner_combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(11, 115);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Work Hours";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(611, 402);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // chart_type_combo
            // 
            this.chart_type_combo.FormattingEnabled = true;
            this.chart_type_combo.Items.AddRange(new object[] {
            "Column",
            "Doughnut"});
            this.chart_type_combo.Location = new System.Drawing.Point(681, 327);
            this.chart_type_combo.Name = "chart_type_combo";
            this.chart_type_combo.Size = new System.Drawing.Size(138, 21);
            this.chart_type_combo.TabIndex = 4;
            this.chart_type_combo.SelectedIndexChanged += new System.EventHandler(this.chart_type_combo_SelectedIndexChanged);
            // 
            // chart_title
            // 
            this.chart_title.BackColor = System.Drawing.Color.Transparent;
            this.chart_title.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.chart_title.Location = new System.Drawing.Point(11, 54);
            this.chart_title.Name = "chart_title";
            this.chart_title.Size = new System.Drawing.Size(860, 58);
            this.chart_title.TabIndex = 5;
            this.chart_title.Text = "Lecturers work hours";
            this.chart_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturer_most_button
            // 
            this.lecturer_most_button.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lecturer_most_button.Location = new System.Drawing.Point(634, 399);
            this.lecturer_most_button.Name = "lecturer_most_button";
            this.lecturer_most_button.Size = new System.Drawing.Size(237, 56);
            this.lecturer_most_button.TabIndex = 6;
            this.lecturer_most_button.Text = "Show lecturer that works the most";
            this.lecturer_most_button.UseVisualStyleBackColor = true;
            this.lecturer_most_button.Click += new System.EventHandler(this.lecturer_most_button_Click);
            // 
            // practitioner_most_button
            // 
            this.practitioner_most_button.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.practitioner_most_button.Location = new System.Drawing.Point(634, 461);
            this.practitioner_most_button.Name = "practitioner_most_button";
            this.practitioner_most_button.Size = new System.Drawing.Size(237, 56);
            this.practitioner_most_button.TabIndex = 7;
            this.practitioner_most_button.Text = "Show practitioner that works the most";
            this.practitioner_most_button.UseVisualStyleBackColor = true;
            this.practitioner_most_button.Click += new System.EventHandler(this.practitioner_most_button_Click);
            // 
            // All_lectures_radio
            // 
            this.All_lectures_radio.AutoSize = true;
            this.All_lectures_radio.Location = new System.Drawing.Point(637, 168);
            this.All_lectures_radio.Name = "All_lectures_radio";
            this.All_lectures_radio.Size = new System.Drawing.Size(83, 17);
            this.All_lectures_radio.TabIndex = 8;
            this.All_lectures_radio.Text = "All Lecturers";
            this.All_lectures_radio.UseVisualStyleBackColor = true;
            this.All_lectures_radio.CheckedChanged += new System.EventHandler(this.All_lectures_radio_CheckedChanged);
            // 
            // all_practitioner_radio
            // 
            this.all_practitioner_radio.AutoSize = true;
            this.all_practitioner_radio.Location = new System.Drawing.Point(766, 168);
            this.all_practitioner_radio.Name = "all_practitioner_radio";
            this.all_practitioner_radio.Size = new System.Drawing.Size(97, 17);
            this.all_practitioner_radio.TabIndex = 9;
            this.all_practitioner_radio.Text = "All Practitioners";
            this.all_practitioner_radio.UseVisualStyleBackColor = true;
            this.all_practitioner_radio.CheckedChanged += new System.EventHandler(this.all_practitioner_radio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.label3.Location = new System.Drawing.Point(630, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chart data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.label2.Location = new System.Drawing.Point(630, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chart Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lecturer_radio
            // 
            this.Lecturer_radio.AutoSize = true;
            this.Lecturer_radio.Location = new System.Drawing.Point(637, 191);
            this.Lecturer_radio.Name = "Lecturer_radio";
            this.Lecturer_radio.Size = new System.Drawing.Size(64, 17);
            this.Lecturer_radio.TabIndex = 12;
            this.Lecturer_radio.Text = "Lecturer";
            this.Lecturer_radio.UseVisualStyleBackColor = true;
            this.Lecturer_radio.CheckedChanged += new System.EventHandler(this.Lecturer_radio_CheckedChanged);
            // 
            // practitioner_radio
            // 
            this.practitioner_radio.AutoSize = true;
            this.practitioner_radio.Location = new System.Drawing.Point(766, 191);
            this.practitioner_radio.Name = "practitioner_radio";
            this.practitioner_radio.Size = new System.Drawing.Size(78, 17);
            this.practitioner_radio.TabIndex = 13;
            this.practitioner_radio.Text = "Practitioner";
            this.practitioner_radio.UseVisualStyleBackColor = true;
            this.practitioner_radio.CheckedChanged += new System.EventHandler(this.practitioner_radio_CheckedChanged);
            // 
            // lecturers_combo
            // 
            this.lecturers_combo.Enabled = false;
            this.lecturers_combo.FormattingEnabled = true;
            this.lecturers_combo.Items.AddRange(new object[] {
            "Column",
            "Doughnut",
            "Radar"});
            this.lecturers_combo.Location = new System.Drawing.Point(637, 214);
            this.lecturers_combo.Name = "lecturers_combo";
            this.lecturers_combo.Size = new System.Drawing.Size(103, 21);
            this.lecturers_combo.TabIndex = 14;
            this.lecturers_combo.SelectedIndexChanged += new System.EventHandler(this.lecturers_combo_SelectedIndexChanged);
            // 
            // practitioner_combo
            // 
            this.practitioner_combo.Enabled = false;
            this.practitioner_combo.FormattingEnabled = true;
            this.practitioner_combo.Items.AddRange(new object[] {
            "Column",
            "Doughnut",
            "Radar"});
            this.practitioner_combo.Location = new System.Drawing.Point(766, 214);
            this.practitioner_combo.Name = "practitioner_combo";
            this.practitioner_combo.Size = new System.Drawing.Size(103, 21);
            this.practitioner_combo.TabIndex = 15;
            this.practitioner_combo.SelectedIndexChanged += new System.EventHandler(this.practitioner_combo_SelectedIndexChanged);
            // 
            // Work_Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 525);
            this.Controls.Add(this.practitioner_combo);
            this.Controls.Add(this.lecturers_combo);
            this.Controls.Add(this.practitioner_radio);
            this.Controls.Add(this.Lecturer_radio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.all_practitioner_radio);
            this.Controls.Add(this.All_lectures_radio);
            this.Controls.Add(this.practitioner_most_button);
            this.Controls.Add(this.lecturer_most_button);
            this.Controls.Add(this.chart_title);
            this.Controls.Add(this.chart_type_combo);
            this.Controls.Add(this.chart);
            this.MaximizeBox = false;
            this.Name = "Work_Hours";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Work Hours";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox chart_type_combo;
        private System.Windows.Forms.Label chart_title;
        private System.Windows.Forms.Button lecturer_most_button;
        private System.Windows.Forms.Button practitioner_most_button;
        private System.Windows.Forms.RadioButton All_lectures_radio;
        private System.Windows.Forms.RadioButton all_practitioner_radio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Lecturer_radio;
        private System.Windows.Forms.RadioButton practitioner_radio;
        private System.Windows.Forms.ComboBox lecturers_combo;
        private System.Windows.Forms.ComboBox practitioner_combo;
    }
}