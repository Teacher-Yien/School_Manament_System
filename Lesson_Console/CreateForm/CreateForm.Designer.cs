namespace CreateForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnCreate = new Button();
            label3 = new Label();
            cboGender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(85, 136);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(57, 27);
            txtAge.TabIndex = 3;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 136);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(85, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(211, 171);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(85, 93);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(126, 28);
            cboGender.TabIndex = 7;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 226);
            Controls.Add(cboGender);
            Controls.Add(label3);
            Controls.Add(btnCreate);
            Controls.Add(btnClear);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Text = "Creating Persons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label2;
        private Button btnClear;
        private Button btnCreate;
        private Label label3;
        private ComboBox cboGender;
    }
}
