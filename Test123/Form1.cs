using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Test123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection conn= new SqlConnection("Data Source=DESKTOP-T1JML11;Initial Catalog=Sa;Integrated Security=True;Encrypt=False");
        private void btn_Click(object sender, EventArgs e)
        {
            String user= user_txt.Text;
            String password = pass_txt.Text;
            String query = "SELECT * FROM Test WHERE username='"+user+"' AND pass='"+password+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            try
            {
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("SuccessFull");
                }
                else
                {
                    MessageBox.Show("Connecting Error  ");
                }

            }catch (Exception ex)
            {

            }
                 
            


        }
    }
}
