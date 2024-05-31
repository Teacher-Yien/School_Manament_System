namespace MultiForms
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
            name_txt = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnCreate = new Button();
            gender_txt = new ComboBox();
            label3 = new Label();
            age_txt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(148, 19);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(151, 27);
            name_txt.TabIndex = 0;
            name_txt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(196, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(317, 169);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // gender_txt
            // 
            gender_txt.FormattingEnabled = true;
            gender_txt.Items.AddRange(new object[] { "Male", "Female" });
            gender_txt.Location = new Point(148, 72);
            gender_txt.Name = "gender_txt";
            gender_txt.Size = new Size(151, 28);
            gender_txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 125);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // age_txt
            // 
            age_txt.Location = new Point(148, 122);
            age_txt.Name = "age_txt";
            age_txt.Size = new Size(125, 27);
            age_txt.TabIndex = 2;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 221);
            Controls.Add(age_txt);
            Controls.Add(label3);
            Controls.Add(gender_txt);
            Controls.Add(btnCreate);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(name_txt);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Text = "Creating Rectangles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name_txt;
        private Label label2;
        private Button btnClear;
        private Button btnCreate;
        private ComboBox gender_txt;
        private Label label3;
        private TextBox age_txt;
    }
    
}