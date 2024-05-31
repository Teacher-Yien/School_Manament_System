namespace employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.rank_txt = new System.Windows.Forms.TextBox();
            this.salary_txt = new System.Windows.Forms.TextBox();
            this.gender_cm = new System.Windows.Forms.ComboBox();
            this.insert_txt = new System.Windows.Forms.Button();
            this.update_txt = new System.Windows.Forms.Button();
            this.deleted_txt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = " Employee Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(149, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Infomation Inputting";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(80, 171);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(37, 29);
            this.txt.TabIndex = 4;
            this.txt.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rank";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Salary";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_txt.Location = new System.Drawing.Point(133, 178);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(220, 36);
            this.id_txt.TabIndex = 9;
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_txt.Location = new System.Drawing.Point(133, 231);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(220, 36);
            this.name_txt.TabIndex = 10;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // rank_txt
            // 
            this.rank_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rank_txt.Location = new System.Drawing.Point(133, 335);
            this.rank_txt.Name = "rank_txt";
            this.rank_txt.Size = new System.Drawing.Size(220, 36);
            this.rank_txt.TabIndex = 12;
            // 
            // salary_txt
            // 
            this.salary_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.salary_txt.Location = new System.Drawing.Point(133, 391);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(220, 36);
            this.salary_txt.TabIndex = 13;
            // 
            // gender_cm
            // 
            this.gender_cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gender_cm.FormattingEnabled = true;
            this.gender_cm.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_cm.Location = new System.Drawing.Point(133, 282);
            this.gender_cm.Name = "gender_cm";
            this.gender_cm.Size = new System.Drawing.Size(220, 37);
            this.gender_cm.TabIndex = 14;
            // 
            // insert_txt
            // 
            this.insert_txt.BackColor = System.Drawing.Color.Lime;
            this.insert_txt.ForeColor = System.Drawing.Color.White;
            this.insert_txt.Location = new System.Drawing.Point(37, 446);
            this.insert_txt.Name = "insert_txt";
            this.insert_txt.Size = new System.Drawing.Size(97, 36);
            this.insert_txt.TabIndex = 15;
            this.insert_txt.Text = "Insert";
            this.insert_txt.UseVisualStyleBackColor = false;
            this.insert_txt.Click += new System.EventHandler(this.insert_txt_Click);
            // 
            // update_txt
            // 
            this.update_txt.BackColor = System.Drawing.Color.Lime;
            this.update_txt.ForeColor = System.Drawing.Color.White;
            this.update_txt.Location = new System.Drawing.Point(140, 446);
            this.update_txt.Name = "update_txt";
            this.update_txt.Size = new System.Drawing.Size(104, 36);
            this.update_txt.TabIndex = 16;
            this.update_txt.Text = "Update";
            this.update_txt.UseVisualStyleBackColor = false;
            this.update_txt.Click += new System.EventHandler(this.update_txt_Click);
            // 
            // deleted_txt
            // 
            this.deleted_txt.BackColor = System.Drawing.Color.Lime;
            this.deleted_txt.ForeColor = System.Drawing.Color.White;
            this.deleted_txt.Location = new System.Drawing.Point(252, 446);
            this.deleted_txt.Name = "deleted_txt";
            this.deleted_txt.Size = new System.Drawing.Size(101, 36);
            this.deleted_txt.TabIndex = 17;
            this.deleted_txt.Text = "Deleted";
            this.deleted_txt.UseVisualStyleBackColor = false;
            this.deleted_txt.Click += new System.EventHandler(this.deleted_txt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(548, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Display Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(370, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 356);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
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
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "Gender";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "Rank";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Salary";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1082, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleted_txt);
            this.Controls.Add(this.update_txt);
            this.Controls.Add(this.insert_txt);
            this.Controls.Add(this.gender_cm);
            this.Controls.Add(this.salary_txt);
            this.Controls.Add(this.rank_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox rank_txt;
        private System.Windows.Forms.TextBox salary_txt;
        private System.Windows.Forms.ComboBox gender_cm;
        private System.Windows.Forms.Button insert_txt;
        private System.Windows.Forms.Button update_txt;
        private System.Windows.Forms.Button deleted_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

