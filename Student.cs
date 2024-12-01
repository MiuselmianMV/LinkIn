using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkIn
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string School {  get; set; }

        public Student(string name, string surname, int age, string school)
        {
            Name = name;
            Surname = surname;
            Age = age;
            School = school;
        }

        public void Show()
        {
            Console.WriteLine($"{Name} {Surname}, {Age} y.o. - studies at {School}");
        }
    }
}
