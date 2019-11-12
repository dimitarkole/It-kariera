using System;
using System.IO;
using System.Linq;

namespace FileStream2
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem3();
        }


        static void Problem1()
        {
            string fileName = "file.txt";

            //WriteFile(fileName);

            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string line = reader.ReadLine();
                bool writting = false;
                while (line != null)
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

        static void Problem2()
        {
            string fileName = "file.txt";

            //WriteFile(fileName);

            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string line = reader.ReadLine();
                int countLine = 1;
                while (line != null)
                {
                    Console.WriteLine($"Line {countLine}: {line}");
                    countLine++;
                    line = reader.ReadLine();
                }
            }
        }
         

        static void Problem3()
        {
            StreamReader readerWord = new StreamReader("words.txt");
            using (readerWord)
            {
                string searchWord = readerWord.ReadLine();
                char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' ','-'};
                while (searchWord != null)
                {
                    int countWordInFile = 0;
                    searchWord = searchWord.ToLower();
                    StreamReader readerText = new StreamReader("text.txt");
                    using (readerText)
                    {
                        string lineOfText = readerText.ReadLine();
                        while (lineOfText != null)
                        {
                            countWordInFile += lineOfText.ToLower().Split(separators).ToArray().Count(x => x == searchWord);
                            lineOfText = readerText.ReadLine();
                        }
                        Console.WriteLine($"{searchWord} - {countWordInFile}");
                        searchWord = readerWord.ReadLine();
                    }                 
                }                  
            }
        }
        static void WriteFile(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            int n = int.Parse(Console.ReadLine());
            using (writer)
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
