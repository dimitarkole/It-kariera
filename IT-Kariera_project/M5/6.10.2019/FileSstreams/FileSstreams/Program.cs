using System;
using System.IO;

namespace FileSstreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
        }


        static void Problem1()
        {
            string fileName = "file.txt";

            WriteFile(fileName);

            StreamReader  reader = new StreamReader(fileName);           
            using (reader)
            {
                string line = reader.ReadLine();
                bool writting = false;
                while (line!=null)
                {
                    if (writting == true)
                    {
                        writting = false;
                        Console.WriteLine(line);
                    }
                    else writting = true;
                    line = reader.ReadLine();
                }
            }
        }

        static void WriteFile(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            int n = int.Parse(Console.ReadLine());
            using(writer)
            {
                for (int i = 0; i < n; i++)
                {
                    string row = Console.ReadLine();
                    writer.WriteLine(row);
                }
            }
            
        }
    }
}
