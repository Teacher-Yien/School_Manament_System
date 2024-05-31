namespace Form1
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
            groupBox1 = new GroupBox();
            cboDir = new ComboBox();
            label2 = new Label();
            cboBy = new ComboBox();
            label1 = new Label();
            dgvPers = new DataGridView();
            btnApply = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnApply);
            groupBox1.Controls.Add(cboDir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboBy);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 96);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sorting";
            // 
            // cboDir
            // 
            cboDir.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDir.FormattingEnabled = true;
            cboDir.Location = new Point(186, 50);
            cboDir.Name = "cboDir";
            cboDir.Size = new Size(112, 28);
            cboDir.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 23);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Direction";
            // 
            // cboBy
            // 
            cboBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBy.FormattingEnabled = true;
            cboBy.Location = new Point(16, 50);
            cboBy.Name = "cboBy";
            cboBy.Size = new Size(143, 28);
            cboBy.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 1;
            label1.Text = "By";
            // 
            // dgvPers
            // 
            dgvPers.AllowUserToAddRows = false;
            dgvPers.AllowUserToDeleteRows = false;
            dgvPers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPers.Location = new Point(29, 134);
            dgvPers.Name = "dgvPers";
            dgvPers.ReadOnly = true;
            dgvPers.RowHeadersWidth = 51;
            dgvPers.RowTemplate.Height = 29;
            dgvPers.Size = new Size(448, 304);
            dgvPers.TabIndex = 2;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(328, 49);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(94, 29);
            btnApply.TabIndex = 5;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 466);
            Controls.Add(dgvPers);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Sorting People";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboDir;
        private Label label2;
        private ComboBox cboBy;
        private Label label1;
        private DataGridView dgvPers;
        private Button btnApply;
    }

        
    }

