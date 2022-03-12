using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string getname() { return name; }
        public int getage() { return age; }

        public int Age()
        {
            return DateTime.Now.Year - age;
        }

        public static int Static_Age(Student s)
        {
            return DateTime.Now.Year - s.age;
        }
    }
}
