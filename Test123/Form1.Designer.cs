namespace Test123
{
    partial class Form1
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
            this.Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(397, 20);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(92, 57);
            this.Login.TabIndex = 0;
            this.Login.Text = "login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "password:";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(179, 90);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(175, 57);
            this.la.TabIndex = 2;
            this.la.Text = "Username:";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(379, 90);
            this.user_txt.Multiline = true;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(196, 40);
            this.user_txt.TabIndex = 3;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(379, 168);
            this.pass_txt.Multiline = true;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(196, 40);
            this.pass_txt.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(453, 242);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(137, 58);
            this.btn.TabIndex = 5;
            this.btn.Text = "Login";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 547);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.la);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button btn;
    }
}

