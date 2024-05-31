namespace information
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            id_txt = new TextBox();
            name_txt = new TextBox();
            gender_txt = new TextBox();
            school_txt = new TextBox();
            view_btn = new Button();
            insert_btn = new Button();
            Update_btn = new Button();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 283);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 303);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 303);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(410, 303);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(611, 303);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 4;
            label4.Text = "School";
            // 
            // id_txt
            // 
            id_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id_txt.Location = new Point(46, 343);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(125, 34);
            id_txt.TabIndex = 5;
            // 
            // name_txt
            // 
            name_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_txt.Location = new Point(229, 343);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(125, 34);
            name_txt.TabIndex = 6;
            // 
            // gender_txt
            // 
            gender_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gender_txt.Location = new Point(410, 343);
            gender_txt.Name = "gender_txt";
            gender_txt.Size = new Size(125, 34);
            gender_txt.TabIndex = 7;
            // 
            // school_txt
            // 
            school_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            school_txt.Location = new Point(611, 343);
            school_txt.Name = "school_txt";
            school_txt.Size = new Size(125, 34);
            school_txt.TabIndex = 8;
            // 
            // view_btn
            // 
            view_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            view_btn.Location = new Point(46, 400);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(125, 43);
            view_btn.TabIndex = 9;
            view_btn.Text = "View";
            view_btn.UseVisualStyleBackColor = true;
            view_btn.Click += view_btn_Click;
            // 
            // insert_btn
            // 
            insert_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insert_btn.Location = new Point(229, 400);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(125, 43);
            insert_btn.TabIndex = 10;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Update_btn.Location = new Point(410, 400);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(109, 43);
            Update_btn.TabIndex = 11;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = true;
            Update_btn.Click += Update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.Location = new Point(611, 400);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(104, 43);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Deleted";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_btn);
            Controls.Add(Update_btn);
            Controls.Add(insert_btn);
            Controls.Add(view_btn);
            Controls.Add(school_txt);
            Controls.Add(gender_txt);
            Controls.Add(name_txt);
            Controls.Add(id_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox id_txt;
        private TextBox name_txt;
        private TextBox gender_txt;
        private TextBox school_txt;
        private Button view_btn;
        private Button insert_btn;
        private Button Update_btn;
        private Button delete_btn;
    }
}