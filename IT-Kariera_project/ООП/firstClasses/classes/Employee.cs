using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Employee
    {
        private string name, position, department, mail;
        private int age;
        private double salary;

        public Employee(string name, double salary, string position, string department, string mail, int age)
        {
            this.Name= name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Mail = mail;
            this.Age = age;
        }
        
        public Employee(string name, double salary, string position, string department, string mail)
            :this(name, salary, position, department, mail,-1)
        { }

        public Employee(string name, double salary, string position, string department, int age)
            : this(name, salary, position, department, "n/a", age)
        {}

        public Employee(string name, double salary, string position, string department)
          : this(name, salary, position, department, "n/a", -1)
        { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void Print()
        {

            //сортирани според заплатите им, в намаляващ ред. 
            Console.WriteLine($"{Name} {Salary:0.00} {Mail} {Age}");
        }
    }
}
