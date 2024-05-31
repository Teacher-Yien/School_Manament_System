using MySql.Data.MySqlClient;
using System.Data;

namespace Product
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=information;USER=root;PASSWORD=;");


        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "SELECT * FROM `products` WHERE 1;";
            MySqlDataAdapter scoure = new MySqlDataAdapter(query, conn);
            DataSet set = new DataSet();
            scoure.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }
        private void inert_btn_Click(object sender, EventArgs e)
        {

            string id = id_txt.Text;
            string qty = qty_txt.Text;
            string price = price_txt.Text;
            string total = total_txt.Text;
            string img = dailog.FileName;
            img = img.Replace("\\", "\\\\");

            conn.Open();
            string query = "INSERT INTO `products` (`id`, `qty`, `price`, `total`, `img`) VALUES ('" + id + "', '" + qty + "', '" + price + "', '" + total + "', '" + img + "');";
            MySqlDataAdapter data = new MySqlDataAdapter(query, conn);
            DataSet set = new DataSet();
            data.Fill(set);

            MessageBox.Show("Data has been Inserted!");
            getData();
        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_txt.Text);
            MySqlDataAdapter data = new MySqlDataAdapter("DELETE FROM products WHERE `products`.`id` = " + id + "", conn);
            DataSet set = new DataSet();
            data.Fill(set);
            MessageBox.Show("Deleted Is Success...");
            getData();
        }
        private void Browser_btn_Click(object sender, EventArgs e)
        {
            dailog.Filter = "Select img(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";
            if (dailog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dailog.FileName);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[row].Selected = true;
            id_txt.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            qty_txt.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            price_txt.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            total_txt.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=information;USER=root;PASSWORD=;");
            string query = "SELECT `img` FROM `products` WHERE `id`='" + int.Parse(id_txt.Text) + "';";
            MySqlDataAdapter data = new MySqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            foreach (DataRow rows in dataTable.Rows)
            {
                string item = rows[0].ToString();
                pictureBox1.Image = Image.FromFile(item);
            }

        }

        private void search_txt_KeyUp(object sender, KeyEventArgs e)
        {
            string sid = search_txt.Text;
            string qurey = "SELECT * FROM `products` WHERE `id`='" + sid + "';";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(qurey, conn);
            DataSet set = new DataSet();
            dataAdapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string id = id_txt.Text;
            string qty = qty_txt.Text;
            string price = price_txt.Text;
            string total = total_txt.Text;
            string img = dailog.FileName;
            img = img.Replace("\\", "\\\\");

            conn.Open();
            string query = "UPDATE `products` SET `id` = '"+id+"', `qty` = '"+qty+"', `price` = '"+price+"', `total` = '"+total+ "', `img` = '"+img+"' WHERE `products`.`id` = '" + id+"';";
            MySqlDataAdapter data = new MySqlDataAdapter(query, conn);
            DataSet set = new DataSet();
            data.Fill(set);

            MessageBox.Show("Data has been Update!","Update",MessageBoxButtons.OKCancel);
            getData();
        }
    }
}