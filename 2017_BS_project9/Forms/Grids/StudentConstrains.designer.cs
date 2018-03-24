using System.Windows.Forms;
namespace _2017_BS_project9
{
    partial class StudentConstains
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
            this.userNameLable = new System.Windows.Forms.Label();
            this.warpper = new MetroFramework.Controls.MetroPanel();
            this.save_btn = new MetroFramework.Controls.MetroTile();
            this.constrainsWeekGrid = new _2017_BS_project9.weekGrid();
            this.warpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constrainsWeekGrid)).BeginInit();
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
            this.warpper.Controls.Add(this.save_btn);
            this.warpper.Controls.Add(this.constrainsWeekGrid);
            this.warpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warpper.HorizontalScrollbarBarColor = true;
            this.warpper.HorizontalScrollbarHighlightOnWheel = false;
            this.warpper.HorizontalScrollbarSize = 0;
            this.warpper.Location = new System.Drawing.Point(20, 60);
            this.warpper.Name = "warpper";
            this.warpper.Size = new System.Drawing.Size(1195, 778);
            this.warpper.TabIndex = 2;
            this.warpper.VerticalScrollbarBarColor = true;
            this.warpper.VerticalScrollbarHighlightOnWheel = false;
            this.warpper.VerticalScrollbarSize = 0;
            // 
            // save_btn
            // 
            this.save_btn.ActiveControl = null;
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save_btn.Location = new System.Drawing.Point(0, 724);
            this.save_btn.Name = "save_btn";
            this.save_btn.PaintTileCount = false;
            this.save_btn.Size = new System.Drawing.Size(1195, 54);
            this.save_btn.TabIndex = 20;
            this.save_btn.Text = "Save Constraints";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.save_btn.UseSelectable = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // constrainsWeekGrid
            // 
            this.constrainsWeekGrid.AllowUserToAddRows = false;
            this.constrainsWeekGrid.AllowUserToDeleteRows = false;
            this.constrainsWeekGrid.AllowUserToResizeColumns = false;
            this.constrainsWeekGrid.AllowUserToResizeRows = false;
            this.constrainsWeekGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.constrainsWeekGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.constrainsWeekGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.constrainsWeekGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.constrainsWeekGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.constrainsWeekGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.constrainsWeekGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.constrainsWeekGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.constrainsWeekGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.constrainsWeekGrid.Location = new System.Drawing.Point(0, 0);
            this.constrainsWeekGrid.Name = "constrainsWeekGrid";
            this.constrainsWeekGrid.ReadOnly = true;
            this.constrainsWeekGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.constrainsWeekGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.constrainsWeekGrid.RowHeadersVisible = false;
            this.constrainsWeekGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.constrainsWeekGrid.RowTemplate.DividerHeight = 5;
            this.constrainsWeekGrid.RowTemplate.Height = 45;
            this.constrainsWeekGrid.RowTemplate.ReadOnly = true;
            this.constrainsWeekGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.constrainsWeekGrid.Size = new System.Drawing.Size(1195, 712);
            this.constrainsWeekGrid.TabIndex = 19;
            this.constrainsWeekGrid.TabStop = false;
            // 
            // StudentConstains
            // 
            this.ClientSize = new System.Drawing.Size(1235, 858);
            this.Controls.Add(this.warpper);
            this.Controls.Add(this.userNameLable);
            this.MinimumSize = new System.Drawing.Size(1235, 726);
            this.Name = "StudentConstains";
            this.Text = "Scheduler: Weekly View";
            this.Load += new System.EventHandler(this.StudentConstains_Load);
            this.warpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.constrainsWeekGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userNameLable;
        private MetroFramework.Controls.MetroPanel warpper;
        private weekGrid constrainsWeekGrid;
        private MetroFramework.Controls.MetroTile save_btn;
    }
}

