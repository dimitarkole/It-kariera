using System;
using System.Linq;

namespace WordTasks1
{
    class Program
    {
        static void Main(string[] args)
        {

            Task3();

        }

        static void Task2()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Person newPerson = new Person();
                newPerson.Name = input[1];
                newPerson.Age= int.Parse(input[0]);
                family.People.Add(newPerson);
            }
            Console.WriteLine();
            Console.WriteLine("Sort Family:");
            family.Print();
        }

        static void Task3()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Person newPerson = new Person();
                newPerson.Name = input[0];
                newPerson.Age = int.Parse(input[1]);
                family.People.Add(newPerson);
            }
            family.Print2();
        }
    }
}
