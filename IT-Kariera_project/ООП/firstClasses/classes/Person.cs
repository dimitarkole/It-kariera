using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Family
    {
        private List<Person> oneFamily = new List<Person>();

        public List<Person> OneFamily
        {
            get { return oneFamily; }
            set{ oneFamily = value; }
        }

        public void PrintFamily()
        {
            //oneFamily = oneFamily.OrderBy(o => o.Name).Reverse().ToList();
            oneFamily = oneFamily.Where(o => o.Age > 30).Reverse().ToList();

            for (int i = 0; i < oneFamily.Count; i++)
            {
                oneFamily[i].IntroduceYourself();
            }
        }

    }

    class Person
    {
        private string name;
        private int age;
        //private List<BankAccount> accounts = new List<BankAccount>();

        public String Data
        {
            set
            {
                string[] info = value.Split(' ');
                name = info[0];
                age = int.Parse(info[1]);
            }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

       /* public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);


        }*/

        public void IntroduceYourself()
        {
            Console.WriteLine("{0} - {1}", name, age);



            //double allMoney = GetBalance();
            // Console.WriteLine("Здравей! Аз съм {0} и съм на {1}", name, age);//, allMoney);
        }
    }
}
