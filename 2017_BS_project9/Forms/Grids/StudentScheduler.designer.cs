using System.Windows.Forms;
namespace _2017_BS_project9
{
    partial class StudentScheduler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userNameLable = new System.Windows.Forms.Label();
            this.warpper = new MetroFramework.Controls.MetroPanel();
            this.schdeulerWeeklyGrid = new _2017_BS_project9.weekGrid();
            this.right_panel = new System.Windows.Forms.Panel();
            this.practice_list = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_event_grp = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lectures_list = new System.Windows.Forms.ListBox();
            this.labs_list = new System.Windows.Forms.ListBox();
            this.active_courses_list = new System.Windows.Forms.ListBox();
            this.active_courses_lable = new System.Windows.Forms.Label();
            this.can_do_courses_list = new System.Windows.Forms.ListBox();
            this.can_do_courses_lable = new System.Windows.Forms.Label();
            this.must_do_courses_list = new System.Windows.Forms.ListBox();
            this.must_do_lable = new System.Windows.Forms.Label();
            this.warpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schdeulerWeeklyGrid)).BeginInit();
            this.right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLable.Location = new System.Drawing.Point(293, 25);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameLable.Size = new System.Drawing.Size(0, 22);
            this.userNameLable.TabIndex = 1;
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // warpper
            // 
            this.warpper.Controls.Add(this.schdeulerWeeklyGrid);
            this.warpper.Controls.Add(this.right_panel);
            this.warpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warpper.HorizontalScrollbarBarColor = true;
            this.warpper.HorizontalScrollbarHighlightOnWheel = false;
            this.warpper.HorizontalScrollbarSize = 0;
            this.warpper.Location = new System.Drawing.Point(20, 60);
            this.warpper.Name = "warpper";
            this.warpper.Size = new System.Drawing.Size(1324, 686);
            this.warpper.TabIndex = 2;
            this.warpper.VerticalScrollbarBarColor = true;
            this.warpper.VerticalScrollbarHighlightOnWheel = false;
            this.warpper.VerticalScrollbarSize = 0;
            // 
            // schdeulerWeeklyGrid
            // 
            this.schdeulerWeeklyGrid.AllowUserToAddRows = false;
            this.schdeulerWeeklyGrid.AllowUserToDeleteRows = false;
            this.schdeulerWeeklyGrid.AllowUserToResizeColumns = false;
            this.schdeulerWeeklyGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.schdeulerWeeklyGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.schdeulerWeeklyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schdeulerWeeklyGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.schdeulerWeeklyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schdeulerWeeklyGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schdeulerWeeklyGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.schdeulerWeeklyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schdeulerWeeklyGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.schdeulerWeeklyGrid.Enabled = false;
            this.schdeulerWeeklyGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.schdeulerWeeklyGrid.Location = new System.Drawing.Point(0, 0);
            this.schdeulerWeeklyGrid.Name = "schdeulerWeeklyGrid";
            this.schdeulerWeeklyGrid.ReadOnly = true;
            this.schdeulerWeeklyGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schdeulerWeeklyGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.schdeulerWeeklyGrid.RowHeadersVisible = false;
            this.schdeulerWeeklyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            this.schdeulerWeeklyGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.schdeulerWeeklyGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.schdeulerWeeklyGrid.RowTemplate.DividerHeight = 5;
            this.schdeulerWeeklyGrid.RowTemplate.Height = 45;
            this.schdeulerWeeklyGrid.RowTemplate.ReadOnly = true;
            this.schdeulerWeeklyGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.schdeulerWeeklyGrid.Size = new System.Drawing.Size(712, 707);
            this.schdeulerWeeklyGrid.TabIndex = 19;
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.practice_list);
            this.right_panel.Controls.Add(this.label3);
            this.right_panel.Controls.Add(this.save_event_grp);
            this.right_panel.Controls.Add(this.label2);
            this.right_panel.Controls.Add(this.label1);
            this.right_panel.Controls.Add(this.lectures_list);
            this.right_panel.Controls.Add(this.labs_list);
            this.right_panel.Controls.Add(this.active_courses_list);
            this.right_panel.Controls.Add(this.active_courses_lable);
            this.right_panel.Controls.Add(this.can_do_courses_list);
            this.right_panel.Controls.Add(this.can_do_courses_lable);
            this.right_panel.Controls.Add(this.must_do_courses_list);
            this.right_panel.Controls.Add(this.must_do_lable);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(725, 0);
            this.right_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(599, 686);
            this.right_panel.TabIndex = 18;
            // 
            // practice_list
            // 
            this.practice_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.practice_list.FormattingEnabled = true;
            this.practice_list.ItemHeight = 30;
            this.practice_list.Location = new System.Drawing.Point(203, 235);
            this.practice_list.Name = "practice_list";
            this.practice_list.Size = new System.Drawing.Size(197, 184);
            this.practice_list.TabIndex = 31;
            this.practice_list.Click += new System.EventHandler(this.practice_list_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Lectures";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_event_grp
            // 
            this.save_event_grp.ActiveControl = null;
            this.save_event_grp.Enabled = false;
            this.save_event_grp.Location = new System.Drawing.Point(2, 660);
            this.save_event_grp.Name = "save_event_grp";
            this.save_event_grp.Size = new System.Drawing.Size(597, 44);
            this.save_event_grp.Style = MetroFramework.MetroColorStyle.White;
            this.save_event_grp.TabIndex = 32;
            this.save_event_grp.Text = "Save Course";
            this.save_event_grp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_event_grp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.save_event_grp.UseSelectable = true;
            this.save_event_grp.Click += new System.EventHandler(this.save_event_grp_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.Location = new System.Drawing.Point(206, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Practice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.Location = new System.Drawing.Point(404, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Labs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lectures_list
            // 
            this.lectures_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lectures_list.FormattingEnabled = true;
            this.lectures_list.ItemHeight = 30;
            this.lectures_list.Location = new System.Drawing.Point(0, 235);
            this.lectures_list.Name = "lectures_list";
            this.lectures_list.Size = new System.Drawing.Size(197, 184);
            this.lectures_list.TabIndex = 27;
            this.lectures_list.Click += new System.EventHandler(this.lectures_list_Click);
            // 
            // labs_list
            // 
            this.labs_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.labs_list.FormattingEnabled = true;
            this.labs_list.ItemHeight = 30;
            this.labs_list.Location = new System.Drawing.Point(409, 235);
            this.labs_list.Name = "labs_list";
            this.labs_list.Size = new System.Drawing.Size(190, 184);
            this.labs_list.TabIndex = 25;
            this.labs_list.Click += new System.EventHandler(this.labs_list_Click);
            // 
            // active_courses_list
            // 
            this.active_courses_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.active_courses_list.FormattingEnabled = true;
            this.active_courses_list.ItemHeight = 30;
            this.active_courses_list.Location = new System.Drawing.Point(0, 461);
            this.active_courses_list.Name = "active_courses_list";
            this.active_courses_list.Size = new System.Drawing.Size(599, 184);
            this.active_courses_list.TabIndex = 7;
            this.active_courses_list.SelectedIndexChanged += new System.EventHandler(this.active_courses_list_SelectedIndexChanged);
            // 
            // active_courses_lable
            // 
            this.active_courses_lable.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.active_courses_lable.Location = new System.Drawing.Point(1, 423);
            this.active_courses_lable.Name = "active_courses_lable";
            this.active_courses_lable.Size = new System.Drawing.Size(599, 36);
            this.active_courses_lable.TabIndex = 24;
            this.active_courses_lable.Text = "Active Courses";
            this.active_courses_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // can_do_courses_list
            // 
            this.can_do_courses_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.can_do_courses_list.FormattingEnabled = true;
            this.can_do_courses_list.ItemHeight = 30;
            this.can_do_courses_list.Location = new System.Drawing.Point(293, 39);
            this.can_do_courses_list.Name = "can_do_courses_list";
            this.can_do_courses_list.Size = new System.Drawing.Size(306, 154);
            this.can_do_courses_list.TabIndex = 5;
            this.can_do_courses_list.Click += new System.EventHandler(this.can_do_courses_list_Click);
            // 
            // can_do_courses_lable
            // 
            this.can_do_courses_lable.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.can_do_courses_lable.Location = new System.Drawing.Point(288, 0);
            this.can_do_courses_lable.Name = "can_do_courses_lable";
            this.can_do_courses_lable.Size = new System.Drawing.Size(306, 36);
            this.can_do_courses_lable.TabIndex = 23;
            this.can_do_courses_lable.Text = "Can Do Courses";
            this.can_do_courses_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // must_do_courses_list
            // 
            this.must_do_courses_list.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.must_do_courses_list.FormattingEnabled = true;
            this.must_do_courses_list.ItemHeight = 30;
            this.must_do_courses_list.Location = new System.Drawing.Point(0, 39);
            this.must_do_courses_list.Name = "must_do_courses_list";
            this.must_do_courses_list.Size = new System.Drawing.Size(287, 154);
            this.must_do_courses_list.TabIndex = 3;
            this.must_do_courses_list.Click += new System.EventHandler(this.must_do_courses_list_Click);
            // 
            // must_do_lable
            // 
            this.must_do_lable.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.must_do_lable.Location = new System.Drawing.Point(3, 0);
            this.must_do_lable.Name = "must_do_lable";
            this.must_do_lable.Size = new System.Drawing.Size(287, 36);
            this.must_do_lable.TabIndex = 22;
            this.must_do_lable.Text = "Must Do Courses";
            this.must_do_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentScheduler
            // 
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.Controls.Add(this.warpper);
            this.Controls.Add(this.userNameLable);
            this.MinimumSize = new System.Drawing.Size(1235, 726);
            this.Name = "StudentScheduler";
            this.Text = "Scheduler: Weekly View";
            this.Shown += new System.EventHandler(this.StudentScheduler_Shown);
            this.warpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schdeulerWeeklyGrid)).EndInit();
            this.right_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userNameLable;
        private MetroFramework.Controls.MetroPanel warpper;
        private Panel right_panel;
        private ListBox must_do_courses_list;
        private ListBox can_do_courses_list;
        private weekGrid schdeulerWeeklyGrid;
        private ListBox active_courses_list;
        private Label active_courses_lable;
        private Label can_do_courses_lable;
        private Label must_do_lable;
        private ListBox labs_list;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lectures_list;
        private ListBox practice_list;
        private MetroFramework.Controls.MetroTile save_event_grp;
    }
}

