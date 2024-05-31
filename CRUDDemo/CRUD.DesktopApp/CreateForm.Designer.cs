namespace CRUD.DesktopApp
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
            components = new System.ComponentModel.Container();
            btnClear = new Button();
            txtFName = new TextBox();
            label2 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            cboGender = new ComboBox();
            btnSubmit = new Button();
            statusStrip1 = new StatusStrip();
            tsslInfo = new ToolStripStatusLabel();
            txtId = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(109, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(109, 87);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(330, 27);
            txtFName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(109, 126);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(330, 27);
            txtLName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(109, 203);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(76, 27);
            txtAge.TabIndex = 10;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 9;
            label5.Text = "Age";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(109, 164);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(165, 28);
            cboGender.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(345, 10);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslInfo });
            statusStrip1.Location = new Point(0, 238);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(451, 26);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            tsslInfo.Name = "tsslInfo";
            tsslInfo.Size = new Size(151, 20);
            tsslInfo.Text = "toolStripStatusLabel1";
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(330, 27);
            txtId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 13;
            label1.Text = "Id";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 264);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(btnSubmit);
            Controls.Add(cboGender);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(btnClear);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Text = "Creating Students";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private TextBox txtFName;
        private Label label2;
        private TextBox txtLName;
        private Label label3;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private ComboBox cboGender;
        private Button btnSubmit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslInfo;
        private TextBox txtId;
        private Label label1;
        private ToolTip toolTip1;
    }
}