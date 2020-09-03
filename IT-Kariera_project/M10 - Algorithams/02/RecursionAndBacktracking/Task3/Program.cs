using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var n = 3;
            var m = 3;
            var labyrinth = new Labyrinth(n, m);
            labyrinth.Run();
        }
    }
}
