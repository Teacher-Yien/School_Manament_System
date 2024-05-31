using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ViewDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void View_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=product_infomation;USER=root;PASSWORD=123456789;");
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM product_infomation.product;", con);
            con.Open();
            DataTable set = new DataTable();
            data.Fill(set);
            dataGridView1.DataSource = set;
            MessageBox.Show("Sucess full", "Show data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
