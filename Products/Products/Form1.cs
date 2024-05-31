using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Products
{
    public partial class Form1 : Form
    {
        private ArrayList list = new ArrayList();
        private int auto_id = 1;
        public Form1()
        {
            InitializeComponent();
            id_txt.Text = auto_id.ToString();
            id_txt.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_txt_Click(object sender, EventArgs e)
        {
            // get data form field
            int id = auto_id;
            string name = name_txt.Text;
            int qty = int.Parse(qty_txt.Text);
            float price = float.Parse(price_txt.Text);

            // Encaspsolution obj
            Product obj = new Product(id,name,qty,price);

            // add into list
            list.Add(obj);
            // get data form list show in table
            dataGridView1.Rows.Clear();
            for(int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add();
                Product temp = (Product)list[i];
                dataGridView1.Rows[i].Cells[0].Value = temp.Id;
                dataGridView1.Rows[i].Cells[1].Value = temp.Name;
                dataGridView1.Rows[i].Cells[2].Value = temp.Qty;
                dataGridView1.Rows[i].Cells[3].Value = temp.Price;
                dataGridView1.Rows[i].Cells[4].Value = temp.Qty*temp.Price;
            }
            auto_id ++;
            id_txt.Text = auto_id + "";
            name_txt.Text = "";
            qty_txt.Text = "";
            price_txt.Text = "";
        }

        private void edit_txt_Click(object sender, EventArgs e)
        {
            // get new data form textfeild
            int id = int.Parse(id_txt.Text);
            string name = name_txt.Text;
            int qty = int.Parse(qty_txt.Text);
            float price = float.Parse(price_txt.Text); 
            Product[] product = { new Product(id, name, qty, price) };

            for(int i=0; i<list.Count; i++)
            {
                Product pro = (Product)list[i];
                if(pro.Id == id)
                {
                    list.SetRange(i, product);
                }
            }
            // reset data int datagridview
            dataGridView1.Rows.Clear();
            for(int i= 0; i<list.Count;i++)
            {
                Product pro = (Product)list[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = pro.Id;
                dataGridView1.Rows[i].Cells[1].Value = pro.Name;
                dataGridView1.Rows[i].Cells[2].Value = pro.Qty;
                dataGridView1.Rows[i].Cells[3].Value = pro.Price;
                dataGridView1.Rows[i].Cells[4].Value = pro.Qty * pro.Price;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[rowSelected].Selected = true;
            
            // set data text field
            id_txt.Text = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            name_txt.Text = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            qty_txt.Text = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            price_txt.Text = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            // = dataGridView1.Rows[rowSelected].Cells[4].Value.ToString();
        }

        private void delete_txt_Click(object sender, EventArgs e)
        {
            // Delete new data form textfeild
            int id = int.Parse(id_txt.Text);
            for (int i = 0; i < list.Count; i++)
            {
                Product pro = (Product)list[i];
                if (pro.Id == id)
                {
                    list.Remove(list[i]);
                    MessageBox.Show("Deleted Success...","Success full",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            // reset data int datagridview
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Product pro = (Product)list[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = pro.Id;
                dataGridView1.Rows[i].Cells[1].Value = pro.Name;
                dataGridView1.Rows[i].Cells[2].Value = pro.Qty;
                dataGridView1.Rows[i].Cells[3].Value = pro.Price;
                dataGridView1.Rows[i].Cells[4].Value = pro.Qty * pro.Price;
            }
        }

        private void search_txt_Click(object sender, EventArgs e)
        {
            // get data they want to search
            string Search_name = search_product.Text;
            for(int i=0; i < list.Count; i++)
            {
                Product temp = (Product)list[i];
                if (Search_name.Equals(temp.Name)){
                    dataGridView1.Rows.Clear();
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells[0].Value = temp.Id;
                    dataGridView1.Rows[row].Cells[1].Value = temp.Name;
                    dataGridView1.Rows[row].Cells[2].Value = temp.Qty;
                    dataGridView1.Rows[row].Cells[3].Value = temp.Price;
                    dataGridView1.Rows[row].Cells[4].Value = temp.Qty * temp.Price;

                }
            }
        }

        private void search_product_TextChanged(object sender, EventArgs e)
        {

            // get data they want to search
            string Search_name = search_product.Text;
            dataGridView1.Rows.Clear();
            // find it inside list
            for (int i = 0; i < list.Count; i++)
            {
                Product temp = (Product)list[i];
                if (temp.Name.Contains(Search_name))
                {
                    
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells[0].Value = temp.Id;
                    dataGridView1.Rows[row].Cells[1].Value = temp.Name;
                    dataGridView1.Rows[row].Cells[2].Value = temp.Qty;
                    dataGridView1.Rows[row].Cells[3].Value = temp.Price;
                    dataGridView1.Rows[row].Cells[4].Value = temp.Qty * temp.Price;

                }
            }
        }
    }
}
