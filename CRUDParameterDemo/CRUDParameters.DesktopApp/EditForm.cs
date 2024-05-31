using CRUDDemo_DesktopApp;
using EnrollLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDParameters.DesktopApp
{
    public partial class EditForm : Form
    {
        Student? stu;
        public EditForm(string? id)
        {
            InitializeComponent();
            cboGender.DataSource = Enum.GetValues<Genders>();
            txtId.Text = id;
            btnSearch.Click += DoClickSearch;
            DoClickSearch(null, EventArgs.Empty);
            tsslInfo.Text = "";
            btnCancel.Click += (sender, e) => { ViewStudent(stu); };
            btnSubmit.Click += DoClickSubmit;
        }

        private void DoClickSubmit(object? sender, EventArgs e)
        {
            if (stu == null) return;
            stu.FirstName = txtFName.Text.Trim();
            stu.LastName = txtLName.Text.Trim();
            stu.Age = byte.Parse(txtAge.Text);
            stu.Gender = (Genders?)Convert.ToInt32(cboGender.SelectedItem);
            try
            {
                var result=Helper.UpdateStudent(Program.Connection, stu);
                if (result == true) tsslInfo.Text = "Successfully updated";
            }
            catch(Exception ex)
            {
                tsslInfo.Text = "";
                MessageBox.Show($"Error> {ex.Message}", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoClickSearch(object? sender, EventArgs e)
        {
            var id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {

                return;
            }
            try
            {
                this.stu=Helper.GetStudentById(Program.Connection, id);
                ViewStudent(stu);
            }
            catch(Exception)
            {
                ViewStudent(null);
            }
        }
        private void ViewStudent(Student? stu)
        {
            txtId.Text = stu?.Id;
            txtFName.Text = stu?.FirstName;
            txtLName.Text = stu?.LastName;
            txtAge.Text = stu?.Age.ToString();
            cboGender.SelectedItem = stu?.Gender;
        }
    }
}
