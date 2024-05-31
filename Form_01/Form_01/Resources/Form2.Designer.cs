namespace Form_01.Resources
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            user = new TextBox();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            female = new CheckBox();
            male = new CheckBox();
            label4 = new Label();
            passwordf2 = new TextBox();
            label5 = new Label();
            cpass = new TextBox();
            create = new Button();
            back = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 75);
            label2.Name = "label2";
            label2.Size = new Size(170, 45);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // user
            // 
            user.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(292, 68);
            user.Name = "user";
            user.Size = new Size(393, 52);
            user.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(146, 140);
            label3.Name = "label3";
            label3.Size = new Size(137, 46);
            label3.TabIndex = 4;
            label3.Text = "Gender:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(female);
            groupBox1.Controls.Add(male);
            groupBox1.Location = new Point(292, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 66);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            female.ForeColor = Color.White;
            female.Location = new Point(159, 11);
            female.Name = "female";
            female.Size = new Size(144, 49);
            female.TabIndex = 1;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            male.ForeColor = Color.White;
            male.Location = new Point(50, 9);
            male.Name = "male";
            male.Size = new Size(112, 49);
            male.TabIndex = 0;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(116, 201);
            label4.Name = "label4";
            label4.Size = new Size(106, 46);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // passwordf2
            // 
            passwordf2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            passwordf2.Location = new Point(292, 195);
            passwordf2.Name = "passwordf2";
            passwordf2.Size = new Size(393, 52);
            passwordf2.TabIndex = 7;
            passwordf2.TextChanged += passwordf2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(116, 272);
            label5.Name = "label5";
            label5.Size = new Size(167, 46);
            label5.TabIndex = 8;
            label5.Text = "Password:";
            // 
            // cpass
            // 
            cpass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cpass.Location = new Point(292, 266);
            cpass.Name = "cpass";
            cpass.Size = new Size(393, 52);
            cpass.TabIndex = 9;
            // 
            // create
            // 
            create.BackColor = Color.Yellow;
            create.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            create.ForeColor = Color.White;
            create.Location = new Point(292, 348);
            create.Name = "create";
            create.Size = new Size(145, 61);
            create.TabIndex = 10;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // back
            // 
            back.BackColor = Color.Crimson;
            back.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            back.ForeColor = Color.White;
            back.Location = new Point(524, 348);
            back.Name = "back";
            back.Size = new Size(143, 61);
            back.TabIndex = 11;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(create);
            Controls.Add(cpass);
            Controls.Add(label5);
            Controls.Add(passwordf2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(user);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox user;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private CheckBox male;
        private CheckBox female;
        private Label label4;
        private TextBox passwordf2;
        private Label label5;
        private TextBox cpass;
        private Button create;
        private Button back;
    }
}