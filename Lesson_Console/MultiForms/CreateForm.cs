using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            btnClear.Click += (sender, e) => { name_txt.Clear(); };
            btnCreate.Click += DoClickCreate;
        }

        private void DoClickCreate(object? sender, EventArgs e)
        {

           string Name= name_txt.Text.ToString();
           
        }
    }
}
