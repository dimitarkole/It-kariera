using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class ProgramList
    {
        public ProgramList()
        {
            this.Programs = new List<ProgramInputModel>();
        }

        public List<ProgramInputModel> Programs { get; set; }

        public void InputData(int n)
        {
            List<string> inputData = new List<string>();
            inputData.Add("1 1 0,3");
            inputData.Add("2 3 0,1");
            inputData.Add("3 2 0,5");
            inputData.Add("4 4 0,6");

            for (int i = 0; i < inputData.Count; i++)
            {
                var data = inputData[i].Split(" ");
                var newActivity = new ProgramInputModel(data[0], int.Parse(data[1]), double.Parse(data[2]));
                Programs.Add(newActivity);
            }

            this.Sort();
            Console.WriteLine(string.Join(" ",this.Programs));
        }

        public void Sort()
        {
            this.Programs = this.Programs
                .OrderByDescending(x => x.Probability / x.Length)
                .ToList();
        }
    }
}
