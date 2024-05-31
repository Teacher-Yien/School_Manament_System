using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_01
{
    internal class Account
    {
        private string name;
        private string password;
        private string password1;
        private string gender;
        public static ArrayList list = new ArrayList();
        public Account() { }
        public Account(string name, string password, string password1, string gender)
        {
            this.name = name;
            this.password = password;
            this.password1 = password1;
            this.gender = gender;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return password1; }
            set { password1 = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
