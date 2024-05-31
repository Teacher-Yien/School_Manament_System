
namespace MultiForms;

public partial class MainForm : Form
{
    public static List<Person> People = new();
    List<Person> _editing = new();
    public MainForm()
    {
        InitializeComponent();
        Person.Created += (p) =>
        {
            People.Add(p);
            AddRecToView(p);
        };
        LoadRectangles();
        

        btnNew.Click += (sender, e) => new CreateForm().Show();
        btnEdit.Click += DoClickEdit;
        btnDelete.Click += DoClickDelete;
    }

    private void DoClickDelete(object? sender, EventArgs e)
    {
        if (dgvRecs.CurrentRow == null) return;
        Person? rec = People.FirstOrDefault(r => r.No == (int)dgvRecs.CurrentRow.Cells[0].Value);
        if (rec == null) return;
        if (_editing.Contains(rec))
        {
            MessageBox.Show($"The rectangle no, {rec.No}, is currently being edited?", "Deleting",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        var result = MessageBox.Show($"Are you sure to delete a rectangle no, {rec.No}?", "Deleting",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No) return;
        if (People.Remove(rec))
        {
            dgvRecs.Rows.Remove(dgvRecs.CurrentRow);
            
        }
    }

    private void DoClickEdit(object? sender, EventArgs e)
    {
        if (dgvRecs.CurrentRow == null) return;
        Person? rec =People.FirstOrDefault(r => r.No == (int)dgvRecs.CurrentRow.Cells[0].Value);
        if (rec == null) return;
        EditForm frm = new EditForm(rec);
        frm.Updated += DoOnRecUpdated;
        frm.Show();
        _editing.Add(rec);
        frm.FormClosed += (sender, e) => _editing.Remove(rec);
    }

    private void DoOnRecUpdated(EditForm sender, Person rec)
    {
        foreach(DataGridViewRow row in dgvRecs.Rows)
        {
            if ( rec.No==(int)row.Cells[0].Value)
            {
                row.SetValues(rec.No, rec.Name, rec.Gender, rec.Age);
               
                break;
            }
        }
        
    }

   
    private void LoadRectangles()
    {
        People.Clear();
        string[] lines = File.ReadAllLines("recs.txt");
        foreach(string line in lines)
        {
            List<double>? sides = line.ToValues();
            if (sides == null) continue;
            if (sides.Count < 2) continue;
           
        }
    }
    private void AddRecToView(Person rec)
    {
        dgvRecs.Rows.Add(rec.No, rec.Name, rec.Gender, rec.Age);
        
       
    }
}
