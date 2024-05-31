using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;
using EntityCollection;

namespace AbstractPerson
{
    public abstract class AbstractPerson : Entity<int>
    {
        private static int count = 0;
        public AbstractPerson() { Key = ++count; }
        protected string _name = "";
        protected string _gender = "";
        protected byte _age;
        public string Name { get => _name; set { _name = value; Notify(); } }
        public string Gender { get => _gender; set { _gender = value; Notify(); } }
        public byte Age { get => _age; set { _age = value; Notify(); } }
        public sealed override string ToString()
        => this.Info; /*Performing polymorphism process */
    }
}
