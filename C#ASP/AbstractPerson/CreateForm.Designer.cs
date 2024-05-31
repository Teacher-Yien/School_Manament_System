namespace AbstractPerson
{
    partial class CreateForm
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
            cboType = new ComboBox();
            label1 = new Label();
            btnClear = new Button();
            lblData = new Label();
            txtData = new TextBox();
            btnCreate = new Button();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            cboGender = new ComboBox();
            label4 = new Label();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(81, 44);
            cboType.Name = "cboType";
            cboType.Size = new Size(194, 28);
            cboType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Type*";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(81, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(23, 215);
            lblData.Name = "lblData";
            lblData.Size = new Size(121, 20);
            lblData.TabIndex = 5;
            lblData.Text = "Additional Data*";
            // 
            // txtData
            // 
            txtData.Location = new Point(81, 238);
            txtData.Name = "txtData";
            txtData.Size = new Size(361, 27);
            txtData.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(348, 271);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 88);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "Name*";
            // 
            // txtName
            // 
            txtName.Location = new Point(81, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 135);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 10;
            label3.Text = "Gender*";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(81, 131);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 176);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 12;
            label4.Text = "Age*";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(81, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(84, 27);
            txtAge.TabIndex = 4;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 312);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(cboGender);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(btnClear);
            Controls.Add(cboType);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Text = "Creating Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboType;
        private Label label1;
        private Button btnClear;
        private Label lblData;
        private TextBox txtData;
        private Button btnCreate;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private ComboBox cboGender;
        private Label label4;
        private TextBox txtAge;
    }
}