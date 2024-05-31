using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractPerson
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            Text = "Creating Person";
            //ComboBox: binding genders for selection
            cboGender.DataSource = Program.Genders;
            //ComboBox: binding person types for selection
            cboType.DataSource = Program.PersonTypeTexts;
            cboType.DisplayMember = nameof(TypeText.Text);
            cboType.ValueMember = nameof(TypeText.Type);
            //Subscripting controls' events
            btnClear.Click += DoClickClear;
            cboType.SelectedValueChanged += DoTypeChanged;
            btnCreate.Click += DoClickCreate;
            //Calling an event handler method
            DoClickClear(null, EventArgs.Empty);
        }
        #region Event Handlers
        private void DoClickCreate(object? sender, EventArgs e)
        {
            Type? entityType = cboType.SelectedValue as Type;
            if (entityType == null)
            {
                MessageBox.Show("Type is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Gender is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string gender = cboGender.SelectedItem.ToString() ?? "";
            if (byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show($"Invalid age, {txtAge.Text.Trim()}", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string additionalData = txtData.Text.Trim();
            if (string.IsNullOrEmpty(additionalData) == true)
            {
                MessageBox.Show("Data is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            PropertyInfo? separatorPi = entityType.GetProperty(
            nameof(AbstractPerson.DataSeparator), BindingFlags.Static | BindingFlags.Public);
            string separator = separatorPi?.GetValue(null)?.ToString() ?? "/";
            string data = $"{name}{separator}{gender}{separator}{age}{separator}{additionalData}";
            if (Program.mgr.Add(entityType.Name, data) == true)
            {
                MessageBox.Show($"Successfully create a new {entityType.Name}", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DoTypeChanged(object? sender, EventArgs e)
        {
            Type? entityType = cboType.SelectedValue as Type;
            if (entityType == null)
            { lblData.Text = "Additional Data*"; }
            else
            {
                //Getting a value from a public static property named: TextDataSample
                PropertyInfo? samplePi = entityType.GetProperty(nameof(AbstractPerson.TextDataSample),
                BindingFlags.Static | BindingFlags.Public);
                lblData.Text = $"Additional Data* ({samplePi?.GetValue(null)?.ToString()})";
            }
        }
        private void DoClickClear(object? sender, EventArgs e)
        {
            cboType.SelectedItem = null;
            txtName.Clear();
            txtAge.Clear();
            cboGender.SelectedItem = null;
            txtData.Clear();
            cboType.Focus();
        }
        #endregion
    
}
}
