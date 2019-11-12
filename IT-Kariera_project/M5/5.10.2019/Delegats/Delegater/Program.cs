using System;

namespace Delegater
{
    class Program
    {
        public delegate void Print(string msg);
        static void Main(string[] args)
        {
            Print del = new Print(Print1);
            del += Print2;
            del += Print3;
            del("Hello!");

            del -= Print2;
            del += (msg1) => Console.WriteLine("Lamda!"+ msg1);

            del("Hello");
        }

        static  void Print1(string msg)
        {
            Console.WriteLine("1: "+msg);
        }

        static void Print2(string msg)
        {
            Console.WriteLine("2: " + msg);
        }

        static void Print3(string msg)
        {
            Console.WriteLine("3: " + msg);
        }
    }
}
