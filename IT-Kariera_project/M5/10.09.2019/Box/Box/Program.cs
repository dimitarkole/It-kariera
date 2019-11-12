using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> boxInt = new Box<int>();
            Box<char> boxChar = new Box<char>();

            int n = 5;
            for (int i = 0; i < n; i++)
            {
                boxChar.Add((char)(i + 65));

                boxInt.Add(i);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(boxInt.Remove());
            }
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(boxChar.Remove());
            }
        }
    }
}
