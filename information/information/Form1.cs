
using System.Data;
using MySql.Data.MySqlClient;
namespace information
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=information;USER=root;PASSWORd=;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM `students` WHERE 1", conn);
            DataSet set = new DataSet();
            data.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_txt.Text);
            string name = name_txt.Text;
            string gender = gender_txt.Text;
            string School = school_txt.Text;
            MySqlDataAdapter data = new MySqlDataAdapter("INSERT INTO `students` (`id`, `name`, `gender`, `school`) VALUES ('" + id + "', '" + name + "', '" + gender + "', '" + School + "')", conn);
            DataSet set = new DataSet();
            data.Fill(set);
            MessageBox.Show("Insert Success..");
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_txt.Text);
            string name = name_txt.Text;
            string gender = gender_txt.Text;
            string School = school_txt.Text;
            MySqlDataAdapter data = new MySqlDataAdapter("UPDATE `students` SET `id` = '" + id + "', `name` = '" + name + "', `gender` = '" + gender + "', `school` = '" + School + "' WHERE `students`.`id` = " + id + ";", conn);
            DataSet set = new DataSet();
            data.Fill(set);
            MessageBox.Show("Update Success..");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_txt.Text);
            MySqlDataAdapter data = new MySqlDataAdapter("DELETE FROM `students` WHERE `students`.`id` = "+id+"", conn);
            DataSet set = new DataSet();
            data.Fill(set);
            MessageBox.Show("Deleted Success..");
        }
    }
}