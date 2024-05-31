using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public delegate void UpdatedHandler(EditForm sender, Person rec);
    public partial class EditForm : Form
    {
        public event UpdatedHandler? Updated;
        Person _rec = default!;
        public EditForm(Person rec)
        {
            InitializeComponent();
            _rec = rec;
            ViewCurRectangle();
            btnCancel.Click += (sender, e) => ViewCurRectangle();
            btnUpdate.Click += DoClickUpdate;
        }

        private void DoClickUpdate(object? sender, EventArgs e)
        {
            List<string> messages = new();
            
            
            Updated?.Invoke(this, _rec);
            MessageBox.Show($"A rectangle no, {_rec.No}, was successfully updated", "Updating",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewCurRectangle()
        {
            name_txt.Text = _rec.Name.ToString();
            gender_txt.Text = _rec.Gender.ToString();
            age_txt.Text = _rec.Age.ToString();
        }
    }
}
