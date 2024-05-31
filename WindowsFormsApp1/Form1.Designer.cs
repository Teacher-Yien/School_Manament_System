namespace WindowsFormsApp1
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
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Location = new System.Drawing.Point(241, 100);
            this.user_txt.Multiline = true;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(269, 45);
            this.user_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer SN Kampot", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(61, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "userName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(61, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Khmer SN Kampot", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(241, 180);
            this.pass_txt.Multiline = true;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(269, 45);
            this.pass_txt.TabIndex = 4;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightCoral;
            this.login.Font = new System.Drawing.Font("Khmer SN Kampot", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(333, 260);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(115, 48);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Salmon;
            this.clear.Font = new System.Drawing.Font("Khmer SN Kampot", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Transparent;
            this.clear.Location = new System.Drawing.Point(479, 260);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(115, 48);
            this.clear.TabIndex = 6;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_txt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button clear;
    }
}

