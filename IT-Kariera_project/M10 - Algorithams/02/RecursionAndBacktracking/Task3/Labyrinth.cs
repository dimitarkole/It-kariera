using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class Labyrinth
    {
        public Labyrinth(int n, int m)
        {
            this.Map = new char[n,m];
            this.N = n;
            this.M = m;
        }

        public char[,] Map { get; set; }

        public int N { get; set; }

        public int M { get; set; }

        public void Run()
        {
            this.GeneratiMap();
            Recurtion(0, 0);
        }


        public void GeneratiMap()
        {
            List<string> rows = new List<string>();
            rows.Add("---");
            rows.Add("-*-");
            rows.Add("--e");         
            for (int i = 0; i < this.N; i++)
            {
                for (int j = 0; j < this.M; j++)
                {
                    this.Map[i, j] = rows[i][j];
                }
            }
        }

        public void Recurtion(int x, int y, string result = "")
        {
            if (Map[x,y] == 'e')
            {
                printResult(result);
                return ;
            }

            if (x < N-1 && Map[x + 1, y] != '*' && !(result.Count()>0 && !(result.Last()!= 'U')))
            {
                Recurtion(x + 1, y, result + "D");
            }
            if (x >0  && Map[x - 1, y] != '*' && !(result.Count() > 0 && !(result.Last() != 'D')))
            {
                Recurtion(x - 1, y, result+"U");
            }
            if (y <M-1 && Map[x, y + 1] != '*' && !(result.Count() > 0 && !(result.Last() != 'L')))
            {
                Recurtion(x, y + 1, result+"R");
            }
            if (y > 0 && Map[x, y - 1] != '*' && !(result.Count() > 0 && !(result.Last() != 'R')))
            {
                Recurtion(x, y - 1, result+"L");
            }
        }

        static void printResult(string result)
        {
            Console.WriteLine(result);
        }

    }
}
