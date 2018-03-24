using System;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class dayGrid : DataGridView
    {

        public dayGrid() : base()
        {
            this.AutoGenerateColumns = false;
            InitializeComponent();
        }
        public void buildGrid()
        {
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "";
            col.Name = "Hourse";
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.Width = (int)Math.Floor(this.Width * 0.20);
            this.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "";
            col.Name = "Events";
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.Width = (int)Math.Floor(this.Width * 0.80);
            this.Columns.Add(col);

            for (int time = Globals.StartHour; time <= Globals.EndHour; time++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 45;
                this.Rows.Add(row);
            }

            for (int row = 0; row <= Globals.EndHour - Globals.StartHour; row++)
            {
                this.Rows[row].SetValues((Globals.StartHour + row).ToString() + ":00");
                this.Rows[row].Cells[0].Style.SelectionBackColor = System.Drawing.Color.White;

            }
            this[0, 0].Selected = false;
        }
    }
}
