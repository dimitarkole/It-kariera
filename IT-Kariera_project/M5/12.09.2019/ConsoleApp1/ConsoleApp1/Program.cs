using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1:");
            Task1();
            Console.WriteLine("");

            Console.WriteLine("Task2:");
            Task2();
            Console.WriteLine("");

            Console.WriteLine("Task3:");
            Task3();
        }

        static void Task1()
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
        }

        static void Task2()
        {
            Puppy myPuppy = new Puppy();
            myPuppy.Eat();
            myPuppy.Bark();
            myPuppy.Weep();
        }

        static void Task3()
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();

            Cat myCat = new Cat();
            myCat.Eat();
            myCat.Meow();
        }
    }
}
