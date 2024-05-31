namespace Product
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            id_txt = new TextBox();
            qty_txt = new TextBox();
            price_txt = new TextBox();
            total_txt = new TextBox();
            dataGridView1 = new DataGridView();
            inert_btn = new Button();
            Deleted = new Button();
            update_btn = new Button();
            dailog = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            Browser_btn = new Button();
            search_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 57);
            label1.TabIndex = 0;
            label1.Text = "Form Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(525, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 35);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(525, 191);
            label3.Name = "label3";
            label3.Size = new Size(70, 35);
            label3.TabIndex = 2;
            label3.Text = "price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(525, 133);
            label4.Name = "label4";
            label4.Size = new Size(50, 35);
            label4.TabIndex = 3;
            label4.Text = "qty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(527, 243);
            label5.Name = "label5";
            label5.Size = new Size(68, 35);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // id_txt
            // 
            id_txt.Location = new Point(608, 87);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(180, 27);
            id_txt.TabIndex = 6;
            // 
            // qty_txt
            // 
            qty_txt.Location = new Point(608, 141);
            qty_txt.Name = "qty_txt";
            qty_txt.Size = new Size(180, 27);
            qty_txt.TabIndex = 7;
            // 
            // price_txt
            // 
            price_txt.Location = new Point(608, 191);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(180, 27);
            price_txt.TabIndex = 8;
            // 
            // total_txt
            // 
            total_txt.Location = new Point(608, 251);
            total_txt.Name = "total_txt";
            total_txt.Size = new Size(180, 27);
            total_txt.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 318);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(727, 188);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // inert_btn
            // 
            inert_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            inert_btn.Location = new Point(344, 69);
            inert_btn.Name = "inert_btn";
            inert_btn.Size = new Size(125, 45);
            inert_btn.TabIndex = 11;
            inert_btn.Text = "Insert";
            inert_btn.UseVisualStyleBackColor = true;
            inert_btn.Click += inert_btn_Click;
            // 
            // Deleted
            // 
            Deleted.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Deleted.Location = new Point(344, 133);
            Deleted.Name = "Deleted";
            Deleted.Size = new Size(125, 42);
            Deleted.TabIndex = 12;
            Deleted.Text = "Deleted";
            Deleted.UseVisualStyleBackColor = true;
            Deleted.Click += Deleted_Click;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            update_btn.Location = new Point(344, 199);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(125, 46);
            update_btn.TabIndex = 13;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // dailog
            // 
            dailog.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.backgrond_page;
            pictureBox1.Location = new Point(66, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Browser_btn
            // 
            Browser_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Browser_btn.Location = new Point(103, 251);
            Browser_btn.Name = "Browser_btn";
            Browser_btn.Size = new Size(135, 46);
            Browser_btn.TabIndex = 17;
            Browser_btn.Text = "Browser_Btn";
            Browser_btn.UseVisualStyleBackColor = true;
            Browser_btn.Click += Browser_btn_Click;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search_txt.Location = new Point(294, 261);
            search_txt.Multiline = true;
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(212, 51);
            search_txt.TabIndex = 18;
            search_txt.KeyUp += search_txt_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 513);
            Controls.Add(search_txt);
            Controls.Add(Browser_btn);
            Controls.Add(pictureBox1);
            Controls.Add(update_btn);
            Controls.Add(Deleted);
            Controls.Add(inert_btn);
            Controls.Add(dataGridView1);
            Controls.Add(total_txt);
            Controls.Add(price_txt);
            Controls.Add(qty_txt);
            Controls.Add(id_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox id_txt;
        private TextBox qty_txt;
        private TextBox price_txt;
        private TextBox total_txt;
        private DataGridView dataGridView1;
        private Button inert_btn;
        private Button Deleted;
        private Button update_btn;
        private OpenFileDialog dailog;
        private PictureBox pictureBox1;
        private Button Browser_btn;
        private TextBox search_txt;
    }
}