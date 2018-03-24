using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class weekGrid : DataGridView
    {
        private bool multiselect;
        private static string[] weekDays = { "", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        public weekGrid(bool multiselect) : base()
        {
            InitializeComponent();
            this.AutoGenerateColumns = false;
            this.multiselect = multiselect;
        }

        public weekGrid() : base()
        {
            this.AutoGenerateColumns = false;
            InitializeComponent();
            this.multiselect = true;
        }

        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
        {
            if (multiselect)
                this[e.ColumnIndex, e.RowIndex].Selected = !this[e.ColumnIndex, e.RowIndex].Selected;
            else
                base.OnCellMouseClick(e);
        }

        protected override void OnCellMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (!multiselect)
            {
                base.OnCellMouseClick(e);

            }
        }

        public void buildGrid()
        {
            foreach (string title in weekDays)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = title;
                col.Name = title.ToLower();
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                this.Columns.Add(col);
            }

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
