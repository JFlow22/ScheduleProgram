namespace _2017_BS_project9
{
    partial class StaffInfoView
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
            this.name_lable = new System.Windows.Forms.Label();
            this.teaching_lable = new System.Windows.Forms.Label();
            this.reception_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lable
            // 
            this.name_lable.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.name_lable.Location = new System.Drawing.Point(23, 69);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(379, 36);
            this.name_lable.TabIndex = 23;
            this.name_lable.Text = "Name";
            this.name_lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teaching_lable
            // 
            this.teaching_lable.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.teaching_lable.Location = new System.Drawing.Point(23, 128);
            this.teaching_lable.Name = "teaching_lable";
            this.teaching_lable.Size = new System.Drawing.Size(379, 44);
            this.teaching_lable.TabIndex = 24;
            this.teaching_lable.Text = "Teaching Course";
            // 
            // reception_lable
            // 
            this.reception_lable.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.reception_lable.Location = new System.Drawing.Point(23, 192);
            this.reception_lable.Name = "reception_lable";
            this.reception_lable.Size = new System.Drawing.Size(379, 53);
            this.reception_lable.TabIndex = 25;
            this.reception_lable.Text = "Reception Hours\r\n";
            // 
            // ViewStaffInfo
            // 
            this.ClientSize = new System.Drawing.Size(425, 265);
            this.Controls.Add(this.reception_lable);
            this.Controls.Add(this.teaching_lable);
            this.Controls.Add(this.name_lable);
            this.Name = "ViewStaffInfo";
            this.Resizable = false;
            this.Text = "View Staff Info";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label teaching_lable;
        private System.Windows.Forms.Label reception_lable;
        #endregion
    }
}