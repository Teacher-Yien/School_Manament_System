namespace PeopleExtension
{
    partial class MainForm
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
            dgvRecs = new DataGridView();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnNew = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecs).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(23, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvRecs
            // 
            dgvRecs.AllowUserToAddRows = false;
            dgvRecs.AllowUserToDeleteRows = false;
            dgvRecs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecs.Location = new Point(26, 61);
            dgvRecs.Name = "dgvRecs";
            dgvRecs.ReadOnly = true;
            dgvRecs.RowHeadersWidth = 51;
            dgvRecs.RowTemplate.Height = 29;
            dgvRecs.Size = new Size(551, 381);
            dgvRecs.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(592, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(593, 413);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(94, 29);
            btnDeleteAll.TabIndex = 3;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(601, 95);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 31);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(604, 143);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(83, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 499);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(dgvRecs);
            Controls.Add(btnRefresh);
            Name = "MainForm";
            Text = "Persons";
            ((System.ComponentModel.ISupportInitialize)dgvRecs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvRecs;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnNew;
        private Button btnEdit;
    }
}
