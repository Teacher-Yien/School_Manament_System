using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01.Resources
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Visible = false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            string name = user.Text;
            string gender = "";
            if (male.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            string password = passwordf2.Text;
            string password1 = cpass.Text;
            Account obj = new Account(name, gender, password, password1);
            MessageBox.Show("Create sucess!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void passwordf2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
