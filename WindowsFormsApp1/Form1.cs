using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T1JML11;Initial Catalog=Sa;Integrated Security=True;Encrypt=False");

        private void login_Click(object sender, EventArgs e)
        {

            String userid = user_txt.Text;
            String password = pass_txt.Text;
            try
            {
                String query = "SELECT * FROM Login1 WHERE username= '"+userid+"' AND  password='"+password+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    userid = user_txt.Text;
                    password = pass_txt.Text;
                    MessageBox.Show("login success ", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid login Detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_txt.Clear();
                    pass_txt.Clear();

                }


            }
            catch
            {
                MessageBox.Show("Invalid login Detail", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            user_txt.Clear();
            pass_txt.Clear();

        }
    }
}
