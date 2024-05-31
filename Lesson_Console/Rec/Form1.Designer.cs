namespace Rec
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            With = new DataGridViewTextBoxColumn();
            lenght = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            Box1 = new GroupBox();
            add = new Bunifu.Framework.UI.BunifuFlatButton();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            width_txt = new Label();
            bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Box1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Active = false;
            bunifuFlatButton1.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 0;
            bunifuFlatButton1.ButtonText = "Refresh";
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.Iconcolor = Color.Transparent;
            bunifuFlatButton1.Iconimage = (Image)resources.GetObject("bunifuFlatButton1.Iconimage");
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(13, 14);
            bunifuFlatButton1.Margin = new Padding(4, 5, 4, 5);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(186, 60);
            bunifuFlatButton1.TabIndex = 0;
            bunifuFlatButton1.Text = "Refresh";
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DeepPink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, With, lenght, Area });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(13, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(586, 319);
            dataGridView1.TabIndex = 1;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            // 
            // With
            // 
            With.HeaderText = "With";
            With.MinimumWidth = 6;
            With.Name = "With";
            // 
            // lenght
            // 
            lenght.HeaderText = "Lenght";
            lenght.MinimumWidth = 6;
            lenght.Name = "lenght";
            // 
            // Area
            // 
            Area.HeaderText = "Area";
            Area.MinimumWidth = 6;
            Area.Name = "Area";
            // 
            // Box1
            // 
            Box1.Controls.Add(bunifuFlatButton2);
            Box1.Controls.Add(add);
            Box1.Controls.Add(textBox2);
            Box1.Controls.Add(label1);
            Box1.Controls.Add(textBox1);
            Box1.Controls.Add(width_txt);
            Box1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Box1.Location = new Point(626, 94);
            Box1.Name = "Box1";
            Box1.Size = new Size(313, 211);
            Box1.TabIndex = 2;
            Box1.TabStop = false;
            Box1.Text = "Create Form";
            // 
            // add
            // 
            add.Active = false;
            add.Activecolor = Color.FromArgb(46, 139, 87);
            add.BackColor = Color.FromArgb(46, 139, 87);
            add.BackgroundImageLayout = ImageLayout.Stretch;
            add.BorderRadius = 0;
            add.ButtonText = "Add";
            add.DisabledColor = Color.Gray;
            add.Iconcolor = Color.Transparent;
            add.Iconimage = (Image)resources.GetObject("add.Iconimage");
            add.Iconimage_right = null;
            add.Iconimage_right_Selected = null;
            add.Iconimage_Selected = null;
            add.IconMarginLeft = 0;
            add.IconMarginRight = 0;
            add.IconRightVisible = true;
            add.IconRightZoom = 0D;
            add.IconVisible = true;
            add.IconZoom = 90D;
            add.IsTab = false;
            add.Location = new Point(212, 211);
            add.Margin = new Padding(6, 7, 6, 7);
            add.Name = "add";
            add.Normalcolor = Color.FromArgb(46, 139, 87);
            add.OnHovercolor = Color.FromArgb(36, 129, 77);
            add.OnHoverTextColor = Color.White;
            add.selected = false;
            add.Size = new Size(155, 59);
            add.TabIndex = 4;
            add.Text = "Add";
            add.TextAlign = ContentAlignment.MiddleLeft;
            add.Textcolor = Color.White;
            add.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 91);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 34);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 91);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 2;
            label1.Text = "Length";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 34);
            textBox1.TabIndex = 1;
            // 
            // width_txt
            // 
            width_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            width_txt.Location = new Point(6, 33);
            width_txt.Name = "width_txt";
            width_txt.Size = new Size(79, 32);
            width_txt.TabIndex = 0;
            width_txt.Text = "Width";
            // 
            // bunifuFlatButton2
            // 
            bunifuFlatButton2.Active = false;
            bunifuFlatButton2.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton2.BorderRadius = 0;
            bunifuFlatButton2.ButtonText = "Add";
            bunifuFlatButton2.DisabledColor = Color.Gray;
            bunifuFlatButton2.ForeColor = Color.AliceBlue;
            bunifuFlatButton2.Iconcolor = Color.Transparent;
            bunifuFlatButton2.Iconimage = (Image)resources.GetObject("bunifuFlatButton2.Iconimage");
            bunifuFlatButton2.Iconimage_right = null;
            bunifuFlatButton2.Iconimage_right_Selected = null;
            bunifuFlatButton2.Iconimage_Selected = null;
            bunifuFlatButton2.IconMarginLeft = 0;
            bunifuFlatButton2.IconMarginRight = 0;
            bunifuFlatButton2.IconRightVisible = true;
            bunifuFlatButton2.IconRightZoom = 0D;
            bunifuFlatButton2.IconVisible = true;
            bunifuFlatButton2.IconZoom = 90D;
            bunifuFlatButton2.IsTab = false;
            bunifuFlatButton2.Location = new Point(138, 149);
            bunifuFlatButton2.Margin = new Padding(6, 7, 6, 7);
            bunifuFlatButton2.Name = "bunifuFlatButton2";
            bunifuFlatButton2.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton2.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton2.OnHoverTextColor = Color.White;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton2.Size = new Size(129, 48);
            bunifuFlatButton2.TabIndex = 5;
            bunifuFlatButton2.Text = "Add";
            bunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton2.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(966, 552);
            Controls.Add(Box1);
            Controls.Add(dataGridView1);
            Controls.Add(bunifuFlatButton1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Rectangle;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Box1.ResumeLayout(false);
            Box1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn With;
        private DataGridViewTextBoxColumn lenght;
        private DataGridViewTextBoxColumn Area;
        private GroupBox Box1;
        private Label width_txt;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton add;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
