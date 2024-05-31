namespace Connect_DB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.qty_text = new System.Windows.Forms.TextBox();
            this.price_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insert_text = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conection DataBase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name:";
            // 
            // id_text
            // 
            this.id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_text.Location = new System.Drawing.Point(145, 86);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(258, 36);
            this.id_text.TabIndex = 5;
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_text.Location = new System.Drawing.Point(145, 137);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(258, 36);
            this.name_text.TabIndex = 6;
            // 
            // qty_text
            // 
            this.qty_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.qty_text.Location = new System.Drawing.Point(145, 195);
            this.qty_text.Name = "qty_text";
            this.qty_text.Size = new System.Drawing.Size(258, 36);
            this.qty_text.TabIndex = 7;
            // 
            // price_text
            // 
            this.price_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.price_text.Location = new System.Drawing.Point(145, 261);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(258, 36);
            this.price_text.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(306, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "CRUD Display Table";
            // 
            // insert_text
            // 
            this.insert_text.BackColor = System.Drawing.Color.Teal;
            this.insert_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.insert_text.ForeColor = System.Drawing.Color.Red;
            this.insert_text.Location = new System.Drawing.Point(454, 86);
            this.insert_text.Name = "insert_text";
            this.insert_text.Size = new System.Drawing.Size(104, 45);
            this.insert_text.TabIndex = 11;
            this.insert_text.Text = "Insert";
            this.insert_text.UseVisualStyleBackColor = false;
            this.insert_text.AutoSizeChanged += new System.EventHandler(this.insert_text_AutoSizeChanged);
            this.insert_text.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.insert_text.Click += new System.EventHandler(this.insert_text_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView1_CancelRowEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SystemColorsChanged += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insert_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.qty_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox qty_text;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insert_text;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

