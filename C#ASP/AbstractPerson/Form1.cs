using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractPerson
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Text = "People";
            //ComboBox: cboType
            var entityTypes = Program.PersonTypeTexts.ToList();
            entityTypes.Insert(0, new() { Type = null, Text = "All" });
            cboType.DataSource = entityTypes;
            cboType.DisplayMember = nameof(TypeText.Text);
            cboType.ValueMember = nameof(TypeText.Type);
            cboType.SelectedValueChanged += DoSelectedTypeChanged;
            //DataGridView: dgvPers
            bs.DataSource = Program.mgr;
            dgvPers.DataSource = bs;
            dgvPers.DataMember = nameof(PersonManager.ActingEntities);
            ConfigGridView();
            //Subscripting on buttons' Clicks
            btnRefresh.Click += (_, _) => bs.ResetBindings(false);
            btnNew.Click += (_, _) => new CreateForm().Show();
            btnEdit.Click += DoClickEdit;
            btnDelete.Click += DoClickDelete;
            //Subscripting on PersonManager's events
            Program.mgr.EntityAdded += (sender, sh) => bs.ResetBindings(false);
            Program.mgr.EntityDataModified += (sender, sh) => bs.ResetBindings(false);
            Program.mgr.EntityRemoved += (sender, sh) => bs.ResetBindings(false);
        }
        #region Event Handlers
        private void DoClickDelete(object? sender, EventArgs e)
        {
            if (dgvPers.CurrentRow == null) return;
            int key = (int)dgvPers.CurrentRow.Cells[nameof(AbstractPerson.Key)].Value;
            AbstractPerson? found = Program.mgr[key];
            if (found == null)
            {
                MessageBox.Show($"No person with key {key}", "Deleting",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (chkConfirm.Checked == true)
            {
                DialogResult result = MessageBox.Show(
                $"R U sure to delete a person with key, {found.Key}?", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }
            if (Program.mgr.Remove(found))
            {
                MessageBox.Show($"Successfully deleted a person with key, {found.Key}", "Deleting",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DoClickEdit(object? sender, EventArgs e)
        {
            int key = -1;
            if (dgvPers.CurrentRow != null)
                key = (int)dgvPers.CurrentRow.Cells[nameof(AbstractPerson.Key)].Value;
            new EditForm(key).Show();
        }
        private void DoSelectedTypeChanged(object? sender, EventArgs e)
        {
            Program.mgr.ActingEntityType = cboType.SelectedValue as Type;
            bs.ResetBindings(false);
        }
        private void ConfigGridView()
        {
            dgvPers.AutoGenerateColumns = false;
            dgvPers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPers.Columns[nameof(AbstractPerson.Tag)].Visible = false;
            dgvPers.Columns[nameof(AbstractPerson.Key)].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            dgvPers.Columns[nameof(AbstractPerson.Info)].HeaderText = "Additional Information";
            dgvPers.AutoGenerateColumns = false;
            dgvPers.Columns[nameof(AbstractPerson.Type)].DisplayIndex = 0;
            dgvPers.Columns[nameof(AbstractPerson.Key)].DisplayIndex = 1;
            #endregion
        }
    }
}
