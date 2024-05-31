namespace Form1
{
    public partial class Form1 : Form
    {
        PersonList people = new PersonList();
        BindingSource bs = new();
        IDirectionComparer<Person> comparer = default!;
        TextAction textAction = default!;
        IDirectionComparer<Person> nameComparer = new PersonNameComparer() { Tag = nameof(Person.Name) };
        IDirectionComparer<Person> ageComparer = new PersonAgeComparer() { Tag = nameof(Person.Age) };
        IDirectionComparer<Person> heightComparer = new PersonHeightComparer() { Tag = nameof(Person.Height) };
        TextAction textAscAction = default!;
        TextAction textDescAction = default!;
        DataGridViewColumn curCol = default!;
        public Form1()
        {
            InitializeComponent();
            people.Load("data.txt");
            textAscAction = new TextAction() { Text = "Ascending", Action = people.Sort<Ascending> };
            textDescAction = new TextAction() { Text = "Descending", Action = people.Sort<Descending> };
            comparer = nameComparer;
            textAction = textAscAction;
            bs.DataSource = people;
            dgvPers.DataSource = bs;
            foreach (DataGridViewColumn col in dgvPers.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
                if (col.Name == nameof(Person.Name)) continue;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            curCol = dgvPers.Columns[nameof(Person.Name)];
            dgvPers.Columns[nameComparer.Tag?.ToString()].Tag = nameComparer;
            dgvPers.Columns[ageComparer.Tag?.ToString()].Tag = ageComparer;
            dgvPers.Columns[heightComparer.Tag?.ToString()].Tag = heightComparer;
            dgvPers.ColumnHeaderMouseClick += (sender, e) =>
            {
                DataGridViewColumn col = dgvPers.Columns[e.ColumnIndex];
                if (col == curCol)
                {
                    if (cboDir.SelectedItem?.Equals(textAscAction)??false)
                        cboDir.SelectedItem = textDescAction;
                    else
                        cboDir.SelectedItem = textAscAction;
                }
                curCol = col;
                comparer = (col.Tag as IDirectionComparer<Person>)!;
                cboBy.SelectedItem = comparer;
                DoClickApply(null, EventArgs.Empty);
            };
            cboBy.DataSource = new List<IDirectionComparer<Person>>()
{ nameComparer, ageComparer, heightComparer };
            cboBy.DisplayMember = nameof(IDirectionComparer<Person>.Text);
            cboDir.DataSource = new List<TextAction>() { textAscAction, textDescAction };
            cboDir.DisplayMember = nameof(TextAction.Text);
            btnApply.Click += DoClickApply;
            DoClickApply(null, EventArgs.Empty);
            this.Load += (sender, e) => { RefreshGridHeaders(); };
        }
        private void DoClickApply(object? sender, EventArgs e)
        {
            textAction = (cboDir.SelectedItem as TextAction)!;
            comparer = (cboBy.SelectedItem as IDirectionComparer<Person>)!;
            if (comparer == null || textAction == null) return;
            textAction.Action(comparer);
            bs.ResetBindings(false);
            RefreshGridHeaders();
        }
        void RefreshGridHeaders()
        {
            DataGridViewColumn col = dgvPers.Columns[comparer.Tag as string];
            SortOrder sortOrder = SortOrder.Ascending;
            if (comparer.Direction is Descending) sortOrder = SortOrder.Descending;
            col.HeaderCell.SortGlyphDirection = sortOrder;
        }
    
    }
    }

