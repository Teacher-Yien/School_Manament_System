using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class information
    {
        private int id;
        private string name;
        private string gender;
        private string rank;
        private float salary;
        public information() { }
        public information(int id, string name, string gender, string rank, float salary)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.rank = rank;
            this.salary = salary;
        }   
        public int ID
        {
            get { return id; }
            set { id = ID; }
        }
        public string Name
        {
            get { return name; }
            set { name = Name; }
        }
        public String Gender
        {
            get { return gender; }
            set { gender = Gender; }
        }
        public String Rank
        {
            get { return rank; }
            set { rank = Rank; }
        }
        public float Salary
        {
            get { return salary; }
            set { salary = Salary; }
        }
    }
}
