using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Student
    {
            private string Name;
            private string sex;
            private float score;
            public Student() { }
            public Student( string name, string sex, float score)
        {
            Name = name;
            this.sex = sex;
            this.score = score;
        }

        public void input()
            {
                Console.Write("Input Name=");
                Name = Console.ReadLine();
                Console.Write("Input Sex=");
                sex = Console.ReadLine();
                Console.Write("Input Score=");
                score = float.Parse(Console.ReadLine());
            }
            public void output()
            {
                Console.WriteLine( "\t\t" + "Name=" + Name + "\t\t" + "sex=" + sex + "\t\t" + "Score=" + score);
            }
            public override string ToString() {
            return "\t"+"Name: " + this.Name +"\t"+ "Gender: " +"\t"+ this.sex +"\t"+ "Score: " + score;
                ;   
           }
        }
    }
