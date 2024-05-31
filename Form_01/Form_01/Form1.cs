using Form_01.Resources;

namespace Form_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void exit_Click(object sender, EventArgs e)
        {
            // Close();
           // this.Close();
           // Dispose();
            this.Dispose();
            //Visible = false;
        }

        private void logintxt_Click(object sender, EventArgs e)
        {
            string emaile = emailtxt.Text;
            string password = pass.Text;
            bool b = true;
            for(int i = 0; i < Account.list.Count; i++)
            {
                Account temp = (Account)Account.list[i];
                if(emaile == temp.Email && password == temp.Password)
                {
                    b = false;
                    MessageBox.Show("login success!", "Homepage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (b)
                {
                    MessageBox.Show("Wrong Email or Password!","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Hand);
                }

            }
            MessageBox.Show("Sucess..", "Homepage", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpass.Checked)
            {
                pass.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }
        private void registertxt_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Visible = false;
            MessageBox.Show("Hello Boy");
        }
    }
}