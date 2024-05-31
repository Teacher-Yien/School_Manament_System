namespace SLS_WindowForm
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
            btn_txt = new Button();
            SuspendLayout();
            // 
            // btn_txt
            // 
            btn_txt.Location = new Point(92, 70);
            btn_txt.Name = "btn_txt";
            btn_txt.Size = new Size(130, 51);
            btn_txt.TabIndex = 0;
            btn_txt.Text = "Refrece";
            btn_txt.UseVisualStyleBackColor = true;
            btn_txt.Click += btn_txt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_txt);
            Name = "Form1";
            Text = "SlS";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_txt;
    }
}
