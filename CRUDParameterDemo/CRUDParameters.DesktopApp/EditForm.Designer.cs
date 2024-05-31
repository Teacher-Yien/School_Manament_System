namespace CRUDParameters.DesktopApp
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            statusStrip1 = new StatusStrip();
            tsslInfo = new ToolStripStatusLabel();
            cboGender = new ComboBox();
            txtAge = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(95, 37);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(289, 23);
            txtId.TabIndex = 24;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslInfo });
            statusStrip1.Location = new Point(0, 184);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(482, 22);
            statusStrip1.TabIndex = 23;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            tsslInfo.Name = "tsslInfo";
            tsslInfo.Size = new Size(118, 17);
            tsslInfo.Text = "toolStripStatusLabel1";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(95, 124);
            cboGender.Margin = new Padding(3, 2, 3, 2);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(145, 23);
            cboGender.TabIndex = 20;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(95, 153);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(67, 23);
            txtAge.TabIndex = 22;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 153);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 21;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 124);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 19;
            label4.Text = "Gender";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(95, 95);
            txtLName.Margin = new Padding(3, 2, 3, 2);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(289, 23);
            txtLName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 95);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 17;
            label3.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(95, 66);
            txtFName.Margin = new Padding(3, 2, 3, 2);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(289, 23);
            txtFName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 15;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 27;
            label1.Text = "Id";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(302, 11);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 22);
            btnSubmit.TabIndex = 26;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(95, 11);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(390, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 206);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(txtId);
            Controls.Add(statusStrip1);
            Controls.Add(cboGender);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Name = "EditForm";
            Text = "Editing Students";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslInfo;
        private ComboBox cboGender;
        private TextBox txtAge;
        private Label label5;
        private Label label4;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtFName;
        private Label label2;
        private Label label1;
        private Button btnSubmit;
        private Button btnCancel;
        private Button btnSearch;
    }
}