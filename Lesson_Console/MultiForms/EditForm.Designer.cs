namespace MultiForms
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
            btnUpdate = new Button();
            btnCancel = new Button();
            label2 = new Label();
            name_txt = new TextBox();
            label1 = new Label();
            txtNo = new TextBox();
            label3 = new Label();
            gender_txt = new ComboBox();
            label4 = new Label();
            age_txt = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(182, 214);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(45, 214);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "Gender";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(93, 58);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(230, 27);
            name_txt.TabIndex = 1;
            name_txt.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 61);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(93, 17);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(94, 27);
            txtNo.TabIndex = 0;
            txtNo.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 12;
            label3.Text = "No";
            // 
            // gender_txt
            // 
            gender_txt.FormattingEnabled = true;
            gender_txt.Items.AddRange(new object[] { "Male", "Female" });
            gender_txt.Location = new Point(93, 114);
            gender_txt.Name = "gender_txt";
            gender_txt.Size = new Size(151, 28);
            gender_txt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 161);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 15;
            label4.Text = "Age";
            // 
            // age_txt
            // 
            age_txt.Location = new Point(93, 165);
            age_txt.Name = "age_txt";
            age_txt.Size = new Size(125, 27);
            age_txt.TabIndex = 3;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 275);
            Controls.Add(age_txt);
            Controls.Add(label4);
            Controls.Add(gender_txt);
            Controls.Add(txtNo);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(name_txt);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            Text = "Editing Rectangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnCancel;
        private Label label2;
        private TextBox name_txt;
        private Label label1;
        private TextBox txtNo;
        private Label label3;
        private ComboBox gender_txt;
        private Label label4;
        private TextBox age_txt;
    }
}