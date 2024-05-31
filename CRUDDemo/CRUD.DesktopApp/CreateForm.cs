using CRUDDemo_DesktopApp;
using EnrollLibrary;

namespace CRUD.DesktopApp
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            cboGender.DataSource = Enum.GetValues<Genders>();
            btnClear.Click += DoClickClear;
            btnSubmit.Click += DoClickSubmit;
            Task.Run(()=> DoClickClear(null, EventArgs.Empty));

            tsslInfo.ForeColor = Color.Green;
            tsslInfo.Text = "";

            toolTip1.SetToolTip(txtId, "F2 for new Id");
            txtId.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.F2)
                    txtId.Text = Guid.NewGuid().ToString();
            };

            txtId.TextChanged += DoTextChanged;
            txtFName.TextChanged += DoTextChanged;
            txtLName.TextChanged += DoTextChanged;
            txtAge.TextChanged += DoTextChanged;
            cboGender.SelectedIndexChanged += DoTextChanged;
        }

        private void DoTextChanged(object? sender, EventArgs e)
        {
            tsslInfo.Text = "";
        }

        private void DoClickSubmit(object? sender, EventArgs e)
        {
            
            byte? age = null;
            if (string.IsNullOrEmpty(txtAge.Text.Trim()) == false)
            {
                if (byte.TryParse(txtAge.Text.Trim(), out byte result) == true)
                {
                    age = result;
                }
                else
                {
                    MessageBox.Show("Invalid age", "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
            var fname = txtFName.Text.Trim();
            var lname = txtLName.Text.Trim();

            Student newStu = new Student()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = string.IsNullOrEmpty(fname) ? null : fname,
                LastName = string.IsNullOrEmpty(lname) ? null : lname,
                Gender = (Genders?)cboGender.SelectedItem,
                Age = age,
            };
            try
            {
                Helper.AddStudent(Program.Connection, newStu);
                //MessageBox.Show("Successfully submitted", "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsslInfo.Text = "Successfully submitted";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void DoClickClear(object? sender, EventArgs e)
        {
            txtId.Text = Guid.NewGuid().ToString();
            txtFName.Clear();
            txtLName.Clear();
            cboGender.SelectedItem = null;
            txtAge.Clear();
            txtFName.Focus();
            tsslInfo.Text = "";
        }
    }
}
