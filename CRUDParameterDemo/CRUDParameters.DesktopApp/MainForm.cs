
using CRUD.DesktopApp;
using CRUDParameters.DesktopApp;
using EnrollLibrary;
using System.Windows.Forms;

namespace CRUDDemo_DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            ConfigView();
            btnRefresh.Click += DoClickRefresh;
            Task.Run(() => { DoClickRefresh(null, EventArgs.Empty); });
            
            btnCreate.Click += (sender, e) =>
            {
                Helper.Added += DoOnStudentAdded;
                (new CreateForm()).Show();
            };

            btnDelete.Click += DoClickDelete;
            btnEdit.Click += DoClickEdit;
        }

        private void DoClickDelete(object? sender, EventArgs e)
        {
            //MessageBox.Show("Please code to perform the \"Delete\" task", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dgvStu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select rows to be deleted", "Deleting", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<string> selectedIds = new();
            foreach(DataGridViewRow row in dgvStu.SelectedRows)
            {
                selectedIds.Add(row.Cells[0].Value.ToString()!);
            }
            if (selectedIds.Count == 1)
            {
                try
                {
                    var result = Helper.DeleteStudent(Program.Connection, selectedIds[0]);
                    if (result == true)
                    {
                        MessageBox.Show("Successfully deleted a selected student", "Deleting",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error>{ex.Message}", "Deleting",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var result = Helper.DeleteStudents(Program.Connection, selectedIds);
                    if (result >0 )
                    {
                        MessageBox.Show($"Successfully deleted {result} student", "Deleting",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error>{ex.Message}", "Deleting",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DoClickEdit(object? sender, EventArgs e)
        {
            //MessageBox.Show("Please code to perform the \"Edit\" task", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string? id = null;
            if (dgvStu.CurrentRow != null) id = dgvStu.CurrentRow.Cells["colId"].Value.ToString();
            Helper.Updated += DoOnStudentUpdated;
            new EditForm(id).Show();
        }

        private void DoOnStudentUpdated(object? sender, EntityEventArgs e)
        {
            var id = e.Id?.Trim();
            //get student from db
            var found = Helper.GetStudentById(Program.Connection, id);
            if (found == null) return;
            // get a row in datagridview with the given id
            //Update a row with found student
            if (dgvStu.Rows.Count == 0) return;
            foreach(DataGridViewRow row in dgvStu.Rows)
            {
                if (row.Cells["colId"].Value.Equals(id))
                {
                    row.SetValues(found.Id, found.FirstName, found.LastName, found.Gender, found.Age);
                    break;
                }
            }
        }

        private void DoOnStudentAdded(object? sender, EntityEventArgs e)
         {
            if (e.Id == null) return;
            Task.Run(() => 
            {
                try
                {
                    var result = Helper.GetStudentById(Program.Connection, e.Id);
                    if (result!=null) AddToView(result);
                }
                catch (Exception) { }
            });
         }

        private void ConfigView()
        {
            dgvStu.Columns.Clear();
            dgvStu.Columns.Add("colId", "Id");
            dgvStu.Columns.Add("colFName", "First Name");
            dgvStu.Columns.Add("colLName", "Last Name");
            dgvStu.Columns.Add("colGender", "Gender");
            dgvStu.Columns.Add("colAge", "Age");
            dgvStu.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStu.MultiSelect = true;
        }
        private void DoClickRefresh(object? sender, EventArgs e)
        {
            try
            {
                var result = Helper.GetAllStudents(Program.Connection);
                dgvStu.Rows.Clear();
                foreach(var student in result)
                {
                    AddToView(student);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Retriving students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddToView(Student student)
        {
            dgvStu.Rows.Add(student.Id, student.FirstName, student.LastName, student.Gender, student.Age);
        }
    }
}
