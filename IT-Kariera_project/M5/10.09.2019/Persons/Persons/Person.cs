using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();
        //TODO: добавете свойства за име и възраст
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public string Name { get => name; set => name = value; }
            
        public int Age
        {
            get { return age; }
            set { age = value; }
        }



        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }

        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);
        }
    }
}
