namespace Form_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            exittxt = new Button();
            logintxt = new Button();
            label1 = new Label();
            pass = new TextBox();
            emailtxt = new TextBox();
            email = new Label();
            label3 = new Label();
            Showpass = new CheckBox();
            pictureBox1 = new PictureBox();
            registertxt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exittxt
            // 
            exittxt.BackColor = Color.FromArgb(192, 0, 0);
            exittxt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            exittxt.ForeColor = Color.Transparent;
            exittxt.Location = new Point(526, 364);
            exittxt.Name = "exittxt";
            exittxt.Size = new Size(151, 65);
            exittxt.TabIndex = 0;
            exittxt.Text = "exit";
            exittxt.UseVisualStyleBackColor = false;
            exittxt.Click += exit_Click;
            // 
            // logintxt
            // 
            logintxt.BackColor = Color.Blue;
            logintxt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            logintxt.ForeColor = Color.White;
            logintxt.Location = new Point(331, 364);
            logintxt.Name = "logintxt";
            logintxt.Size = new Size(135, 65);
            logintxt.TabIndex = 1;
            logintxt.Text = "Login";
            logintxt.UseVisualStyleBackColor = false;
            logintxt.Click += logintxt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(276, 10);
            label1.Name = "label1";
            label1.Size = new Size(190, 46);
            label1.TabIndex = 3;
            label1.Text = "Form Login";
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(217, 276);
            pass.Name = "pass";
            pass.Size = new Size(362, 52);
            pass.TabIndex = 4;
            pass.TextChanged += pass_TextChanged;
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.Location = new Point(217, 210);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(362, 52);
            emailtxt.TabIndex = 5;
            emailtxt.TextChanged += emailtxt_TextChanged;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = SystemColors.ButtonHighlight;
            email.Location = new Point(116, 216);
            email.Name = "email";
            email.Size = new Size(95, 41);
            email.TabIndex = 6;
            email.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(61, 287);
            label3.Name = "label3";
            label3.Size = new Size(150, 41);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // Showpass
            // 
            Showpass.AutoSize = true;
            Showpass.ForeColor = SystemColors.HighlightText;
            Showpass.Location = new Point(281, 334);
            Showpass.Name = "Showpass";
            Showpass.Size = new Size(132, 24);
            Showpass.TabIndex = 8;
            Showpass.Text = "Show Password";
            Showpass.UseVisualStyleBackColor = true;
            Showpass.CheckedChanged += Showpass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 131);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // registertxt
            // 
            registertxt.BackColor = Color.Lime;
            registertxt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            registertxt.ForeColor = Color.White;
            registertxt.Location = new Point(90, 364);
            registertxt.Name = "registertxt";
            registertxt.Size = new Size(163, 65);
            registertxt.TabIndex = 10;
            registertxt.Text = "Register";
            registertxt.UseVisualStyleBackColor = false;
            registertxt.Click += registertxt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(registertxt);
            Controls.Add(pictureBox1);
            Controls.Add(Showpass);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(emailtxt);
            Controls.Add(pass);
            Controls.Add(label1);
            Controls.Add(logintxt);
            Controls.Add(exittxt);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Red;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exittxt;
        private Button logintxt;
        private Label label1;
        private TextBox pass;
        private TextBox emailtxt;
        private Label email;
        private Label label3;
        private CheckBox Showpass;
        private PictureBox pictureBox1;
        private Button registertxt;
    }
}