using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class Form1 : Form
    {
        private ArrayList list = new ArrayList();
        private int id_cout = 1;

        public Form1()
        {
            InitializeComponent();
            id_txt.Text = id_cout.ToString();
            id_txt.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_txt_Click(object sender, EventArgs e)
        {
            // get data form textfeild
            String name = name_txt.Text;
            String gender = gender_cm.Text;
            String rank = rank_txt.Text;
            float salary = float.Parse(salary_txt.Text);

            // collect data into one object
            information obj = new information(id_cout,name,gender,rank,salary);

            // add into list
            list.Add(obj);
            // get data form list to show on table
            dataGridView1.Rows.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add();
                information info = (information)list[i];
                dataGridView1.Rows[i].Cells[0].Value = info.ID;
                dataGridView1.Rows[i].Cells[1].Value = info.Name;
                dataGridView1.Rows[i].Cells[2].Value = info.Gender;
                dataGridView1.Rows[i].Cells[3].Value = info.Rank;
                dataGridView1.Rows[i].Cells[4].Value = info.Salary;
            }
            id_cout++;
            id_txt.Text = id_cout.ToString();
        }

        private void deleted_txt_Click(object sender, EventArgs e)
        {
            // Deleted work list
           // MessageBox.Show("Deleted Success...!");
           int id = int.Parse(id_txt.Text);
            for(int i=0; i < list.Count; i++)
            {
                information info = (information)list[i];
                if(id == info.ID)
                {
                    // find data stay at index?
                    list.Remove(list[i]);
                    MessageBox.Show("Deleted Success...!");
                }
            }
            // reset data in table Grid
            dataGridView1.Rows.Clear();
            for(int i=0 ; i < list.Count ; i++)
            {
                dataGridView1.Rows.Add();
                information info = (information)list[i];
                dataGridView1.Rows[i].Cells[0].Value = info.ID;
                dataGridView1.Rows[i].Cells[1].Value = info.Name;
                dataGridView1.Rows[i].Cells[2].Value = info.Gender;
                dataGridView1.Rows[i].Cells[3].Value = info.Rank;
                dataGridView1.Rows[i].Cells[4].Value = info.Salary;
            }
            id_txt.Text = id_cout.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[rowSelected].Selected = true;
            id_txt.Text = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            name_txt.Text = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            gender_cm.Text = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            rank_txt.Text = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            salary_txt.Text = dataGridView1.Rows[rowSelected].Cells[4].Value.ToString();
        }

        private void update_txt_Click(object sender, EventArgs e)
        {
            // get new Data form textfeild
            int id = int.Parse(id_txt.Text);
            string name = name_txt.Text;
            string gender = gender_cm.Text;
            string rank = rank_txt.Text;
            float salary =float.Parse( salary_txt.Text);
            information[] infoma = { new information(id,name,gender,rank,salary) };
            for(int i = 0; i < list.Count; i++)
            {
                information info = (information)list[i];
                if (id == info.ID)
                {
                    list.SetRange(i, infoma);
                    MessageBox.Show("Update Success...!");
                }
                
            }
            // reset data in table Grid
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add();
                information info = (information)list[i];
                dataGridView1.Rows[i].Cells[0].Value = info.ID;
                dataGridView1.Rows[i].Cells[1].Value = info.Name;
                dataGridView1.Rows[i].Cells[2].Value = info.Gender;
                dataGridView1.Rows[i].Cells[3].Value = info.Rank;
                dataGridView1.Rows[i].Cells[4].Value = info.Salary;
            }
            id_txt.Text = id_cout.ToString();

        }
    }
}
