using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Connect_DB
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insert_text_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=product_infomation;USER=root;PASSWORD=123456789");
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM product_infomation.product;", con);
          //  con.Open();
             DataTable set = new DataTable();
            data.Fill(set);
            dataGridView1.DataSource = set;
            MessageBox.Show("Sucess full", "Show data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }

        private void insert_text_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
