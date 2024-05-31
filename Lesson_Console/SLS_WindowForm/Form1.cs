namespace SLS_WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // btn_txt.Click += btn_txt_Click;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Sreynoeng Jaa","Test",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
        }
    }
}
