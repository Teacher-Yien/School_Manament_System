namespace AbstractPerson
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
            btnCancel = new Button();
            label1 = new Label();
            txtKey = new TextBox();
            txtData = new TextBox();
            lblData = new Label();
            btnUpdate = new Button();
            txtType = new TextBox();
            label2 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            cboGender = new ComboBox();
            label3 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(73, 16);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 103);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Key*";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(74, 101);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(93, 27);
            txtKey.TabIndex = 2;
            txtKey.TextAlign = HorizontalAlignment.Right;
            // 
            // txtData
            // 
            txtData.Location = new Point(73, 297);
            txtData.Name = "txtData";
            txtData.Size = new Size(388, 27);
            txtData.TabIndex = 6;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(16, 274);
            lblData.Name = "lblData";
            lblData.Size = new Size(121, 20);
            lblData.TabIndex = 3;
            lblData.Text = "Additional Data*";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(367, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            txtType.Location = new Point(74, 58);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(163, 27);
            txtType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 6;
            label2.Text = "Type";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(73, 228);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(84, 27);
            txtAge.TabIndex = 5;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 232);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 18;
            label4.Text = "Age*";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(73, 187);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 191);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 17;
            label3.Text = "Gender*";
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 144);
            txtName.Name = "txtName";
            txtName.Size = new Size(385, 27);
            txtName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 144);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 16;
            label5.Text = "Name*";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 372);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(cboGender);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtType);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(txtKey);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            Text = "Editing Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Label label1;
        private TextBox txtKey;
        private TextBox txtData;
        private Label lblData;
        private Button btnUpdate;
        private TextBox txtType;
        private Label label2;
        private TextBox txtAge;
        private Label label4;
        private ComboBox cboGender;
        private Label label3;
        private TextBox txtName;
        private Label label5;
    }
}