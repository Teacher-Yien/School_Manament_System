namespace CRUDDemo_DesktopApp
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
            dgvStu = new DataGridView();
            btnRefresh = new Button();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStu).BeginInit();
            SuspendLayout();
            // 
            // dgvStu
            // 
            dgvStu.AllowUserToAddRows = false;
            dgvStu.AllowUserToDeleteRows = false;
            dgvStu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStu.Location = new Point(18, 49);
            dgvStu.Name = "dgvStu";
            dgvStu.ReadOnly = true;
            dgvStu.RowHeadersWidth = 51;
            dgvStu.RowTemplate.Height = 29;
            dgvStu.Size = new Size(754, 457);
            dgvStu.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(18, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(451, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(564, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(678, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 513);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(btnRefresh);
            Controls.Add(dgvStu);
            Name = "MainForm";
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)dgvStu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStu;
        private Button btnRefresh;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
    }
}
