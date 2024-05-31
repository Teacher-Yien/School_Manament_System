namespace Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.add_txt = new System.Windows.Forms.Button();
            this.edit_txt = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.Button();
            this.delete_txt = new System.Windows.Forms.Button();
            this.sort_txt = new System.Windows.Forms.Button();
            this.search_product = new System.Windows.Forms.TextBox();
            this.sort_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Battambang", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "ហាងលក់ទំនិញ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Battambang", 20.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "ទម្រង់ព័ត៌មាន";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Battambang", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "លេខសំគាល់:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "ឈ្មោះ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "ចំនួន :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "តម្លៃ :";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Battambang", 10F);
            this.id_txt.Location = new System.Drawing.Point(144, 128);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(183, 38);
            this.id_txt.TabIndex = 6;
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(144, 172);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(183, 38);
            this.name_txt.TabIndex = 7;
            // 
            // qty_txt
            // 
            this.qty_txt.Font = new System.Drawing.Font("Battambang", 10F);
            this.qty_txt.Location = new System.Drawing.Point(144, 216);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(183, 38);
            this.qty_txt.TabIndex = 8;
            // 
            // price_txt
            // 
            this.price_txt.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.Location = new System.Drawing.Point(144, 260);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(183, 38);
            this.price_txt.TabIndex = 9;
            // 
            // add_txt
            // 
            this.add_txt.BackColor = System.Drawing.Color.Red;
            this.add_txt.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_txt.ForeColor = System.Drawing.Color.White;
            this.add_txt.Location = new System.Drawing.Point(18, 327);
            this.add_txt.Name = "add_txt";
            this.add_txt.Size = new System.Drawing.Size(83, 47);
            this.add_txt.TabIndex = 10;
            this.add_txt.Text = "បន្ថែម";
            this.add_txt.UseVisualStyleBackColor = false;
            this.add_txt.Click += new System.EventHandler(this.add_txt_Click);
            // 
            // edit_txt
            // 
            this.edit_txt.BackColor = System.Drawing.Color.Red;
            this.edit_txt.Font = new System.Drawing.Font("Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_txt.ForeColor = System.Drawing.Color.White;
            this.edit_txt.Location = new System.Drawing.Point(123, 327);
            this.edit_txt.Name = "edit_txt";
            this.edit_txt.Size = new System.Drawing.Size(83, 47);
            this.edit_txt.TabIndex = 11;
            this.edit_txt.Text = "កែប្រែ";
            this.edit_txt.UseVisualStyleBackColor = false;
            this.edit_txt.Click += new System.EventHandler(this.edit_txt_Click);
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.Red;
            this.search_txt.Font = new System.Drawing.Font("Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.White;
            this.search_txt.Location = new System.Drawing.Point(18, 380);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(99, 47);
            this.search_txt.TabIndex = 12;
            this.search_txt.Text = "ស្វែងរក";
            this.search_txt.UseVisualStyleBackColor = false;
            this.search_txt.Click += new System.EventHandler(this.search_txt_Click);
            // 
            // delete_txt
            // 
            this.delete_txt.BackColor = System.Drawing.Color.Red;
            this.delete_txt.Font = new System.Drawing.Font("Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_txt.ForeColor = System.Drawing.Color.White;
            this.delete_txt.Location = new System.Drawing.Point(231, 327);
            this.delete_txt.Name = "delete_txt";
            this.delete_txt.Size = new System.Drawing.Size(83, 47);
            this.delete_txt.TabIndex = 13;
            this.delete_txt.Text = "លុប";
            this.delete_txt.UseVisualStyleBackColor = false;
            this.delete_txt.Click += new System.EventHandler(this.delete_txt_Click);
            // 
            // sort_txt
            // 
            this.sort_txt.BackColor = System.Drawing.Color.Red;
            this.sort_txt.Font = new System.Drawing.Font("Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_txt.ForeColor = System.Drawing.Color.White;
            this.sort_txt.Location = new System.Drawing.Point(18, 433);
            this.sort_txt.Name = "sort_txt";
            this.sort_txt.Size = new System.Drawing.Size(147, 47);
            this.sort_txt.TabIndex = 14;
            this.sort_txt.Text = "តម្រៀបទិន្ន័យ";
            this.sort_txt.UseVisualStyleBackColor = false;
            // 
            // search_product
            // 
            this.search_product.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_product.Location = new System.Drawing.Point(123, 380);
            this.search_product.Name = "search_product";
            this.search_product.Size = new System.Drawing.Size(204, 38);
            this.search_product.TabIndex = 15;
            this.search_product.TextChanged += new System.EventHandler(this.search_product_TextChanged);
            // 
            // sort_combo
            // 
            this.sort_combo.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_combo.FormattingEnabled = true;
            this.sort_combo.Items.AddRange(new object[] {
            "តាមរយ:ឈ្មោះ",
            "តាមរយ:លេខសំគាល់",
            "តាមរយ:ចំនួន",
            "តាមរយ:តម្លៃ"});
            this.sort_combo.Location = new System.Drawing.Point(187, 438);
            this.sort_combo.Name = "sort_combo";
            this.sort_combo.Size = new System.Drawing.Size(200, 39);
            this.sort_combo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Battambang", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(641, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 59);
            this.label7.TabIndex = 18;
            this.label7.Text = "តារាងព័ត៌មាន";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(424, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 349);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Products.Properties.Resources.shop1;
            this.ClientSize = new System.Drawing.Size(1082, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sort_combo);
            this.Controls.Add(this.search_product);
            this.Controls.Add(this.sort_txt);
            this.Controls.Add(this.delete_txt);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.edit_txt);
            this.Controls.Add(this.add_txt);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Shopping";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Button add_txt;
        private System.Windows.Forms.Button edit_txt;
        private System.Windows.Forms.Button search_txt;
        private System.Windows.Forms.Button delete_txt;
        private System.Windows.Forms.Button sort_txt;
        private System.Windows.Forms.TextBox search_product;
        private System.Windows.Forms.ComboBox sort_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

