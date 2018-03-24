using System.Windows.Forms;
namespace _2017_BS_project9
{
    partial class ScheduleWeekView
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.warpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schdeulerWeeklyGrid)).BeginInit();
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
            this.warpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warpper.HorizontalScrollbarBarColor = true;
            this.warpper.HorizontalScrollbarHighlightOnWheel = false;
            this.warpper.HorizontalScrollbarSize = 0;
            this.warpper.Location = new System.Drawing.Point(20, 60);
            this.warpper.Name = "warpper";
            this.warpper.Size = new System.Drawing.Size(945, 707);
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
            this.schdeulerWeeklyGrid.Size = new System.Drawing.Size(940, 707);
            this.schdeulerWeeklyGrid.TabIndex = 19;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(426, 11);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(161, 43);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 23;
            this.metroTile1.Text = "Print";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ScheduleWeekView
            // 
            this.ClientSize = new System.Drawing.Size(985, 787);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.warpper);
            this.Controls.Add(this.userNameLable);
            this.Name = "ScheduleWeekView";
            this.Text = "Scheduler: Weekly View";
            this.Load += new System.EventHandler(this.StudentScheduler_Load);
            this.warpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schdeulerWeeklyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userNameLable;
        private MetroFramework.Controls.MetroPanel warpper;
        private weekGrid schdeulerWeeklyGrid;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

