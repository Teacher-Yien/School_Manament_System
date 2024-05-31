using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AbstractPerson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefresh = new Button();
            dgvPers = new DataGridView();
            label1 = new Label();
            cboType = new ComboBox();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            chkConfirm = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvPers).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(297, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvPers
            // 
            dgvPers.AccessibleRole = AccessibleRole.Grip;
            dgvPers.AllowUserToAddRows = false;
            dgvPers.AllowUserToDeleteRows = false;
            dgvPers.AllowUserToOrderColumns = true;
            dgvPers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPers.Location = new Point(22, 53);
            dgvPers.Name = "dgvPers";
            dgvPers.ReadOnly = true;
            dgvPers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPers.Size = new Size(847, 370);
            dgvPers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(82, 11);
            cboType.Name = "cboType";
            cboType.Size = new Size(194, 28);
            cboType.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(893, 115);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(893, 165);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(893, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkConfirm
            // 
            chkConfirm.AutoSize = true;
            chkConfirm.Location = new Point(896, 364);
            chkConfirm.Name = "chkConfirm";
            chkConfirm.Size = new Size(91, 24);
            chkConfirm.TabIndex = 7;
            chkConfirm.Text = "Confirm?";
            chkConfirm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 450);
            Controls.Add(chkConfirm);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(cboType);
            Controls.Add(label1);
            Controls.Add(dgvPers);
            Controls.Add(btnRefresh);
            Name = "Form1";
            Text = "People";
            ((System.ComponentModel.ISupportInitialize)dgvPers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvPers;
        private Label label1;
        private ComboBox cboType;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private CheckBox chkConfirm;
    }
}