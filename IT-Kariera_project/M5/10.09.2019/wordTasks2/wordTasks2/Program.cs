using System;

namespace wordTasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Task1()
        {
            RacionalNumber racionalNumber = new RacionalNumber();
            for (int i = 0; i < 3; i++)
            {
                racionalNumber.Numerator = int.Parse(Console.ReadLine());
                racionalNumber.Denumerator = int.Parse(Console.ReadLine());

                Console.WriteLine(racionalNumber.ToString());
            }
        }
    }
}
