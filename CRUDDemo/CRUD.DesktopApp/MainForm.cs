
using CRUD.DesktopApp;
using EnrollLibrary;

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
            MessageBox.Show("Please code to perform the \"Delete\" task", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DoClickEdit(object? sender, EventArgs e)
        {
            MessageBox.Show("Please code to perform the \"Edit\" task", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
