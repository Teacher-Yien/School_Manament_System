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
    public partial class EditForm : Form
    {
        private int _key = -1;
        public EditForm(int key)
        {
            InitializeComponent();
            cboGender.DataSource = Program.Genders;
            this._key = key;
            Text = "Editing Person";
            ViewEditEntity(this._key);
            //Subscripting controls' events
            btnCancel.Click += (_, _) =>
            {
                AbstractPerson? edit = ViewEditEntity(this._key);
                txtData.Text = edit?.GetTextData();
            };
            btnUpdate.Click += DoClickUpdate;
            txtKey.Leave += DoNoLeave;
        }
        #region Event Handlers
        private void DoNoLeave(object? sender, EventArgs e)
        {
            if (int.TryParse(txtKey.Text, out int no))
            {
                ViewEditEntity(no);
            }
        }
        private void DoClickUpdate(object? sender, EventArgs e)
        {
            if (int.TryParse(txtKey.Text, out int key) == false)
            {
                MessageBox.Show($"Invalid key, {txtKey.Text}", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Gender is required", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string gender = cboGender.SelectedItem.ToString() ?? "";
            if (byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show($"Invalid age, {txtAge.Text.Trim()}", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string additionalData = txtData.Text.Trim();
            if (string.IsNullOrEmpty(additionalData) == true)
            {
                MessageBox.Show("Additional data is required", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            AbstractPerson? edit = Program.mgr[key];
            if (edit == null)
            {
                MessageBox.Show($"No person with key, {key}", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            PropertyInfo? separatorPi = edit.GetType().GetProperty(
            nameof(AbstractPerson.DataSeparator), BindingFlags.Static | BindingFlags.Public);
            string separator = separatorPi?.GetValue(null)?.ToString() ?? "/";
            string data = $"{name}{separator}{gender}{separator}{age}{separator}{additionalData}";
            if (edit.SetTextData(data))
            {
                MessageBox.Show($"Successfully updated a person with key, {edit.Key}", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this._key = key;
            }
        }
        #endregion

        private AbstractPerson? ViewEditEntity(int no)
        {
            AbstractPerson? edit = Program.mgr[no];
            Type? shapeType = edit?.GetType();
            if (shapeType == null)
                lblData.Text = "Additional Data*";
            else
            {
                //Getting a value from a public static property named: TextDataSample
                PropertyInfo? samplePi = shapeType.GetProperty(nameof(AbstractPerson.TextDataSample),
                BindingFlags.Static | BindingFlags.Public);
                lblData.Text = $"Additional Data* ({samplePi?.GetValue(null)?.ToString()})";
            }
            txtKey.Text = edit?.Key.ToString();
            txtType.Text = edit?.Type;
            txtName.Text = edit?.Name;
            cboGender.Text = edit?.Gender;
            txtAge.Text = edit?.Age.ToString();
            txtData.Text = edit?.GetTextData();
            return edit;
        }
    }
}
