using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class WorkList
    {
        public WorkList()
        {
            this.Works = new List<WorkInputModel>();
        }

        public List<WorkInputModel> Works { get; set; }

        public void InputData(int n)
        {
            List<string> inputData = new List<string>();
            inputData.Add("1 2 60");
            inputData.Add("2 1 100");
            inputData.Add("3 3 20");
            inputData.Add("4 2 40");
            inputData.Add("5 1 20");

            for (int i = 0; i < inputData.Count; i++)
            {
                var data = inputData[i].Split(" ");
                var newActivity = new WorkInputModel(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]));
                Works.Add(newActivity);
            }

            this.Sort();

            var chosenWorks = new List<WorkInputModel>();
            chosenWorks.Add(this.Works[0]);
            for (int i = 1; i < Works.Count; i++)
            {
                if(chosenWorks.Last().Day<Works[i].Day)
                {
                    chosenWorks.Add(Works[i]);
                }
            }
            Console.WriteLine(string.Join(" ", chosenWorks));
            Console.WriteLine($"Максимална печалба {chosenWorks.Sum(x=> x.Money)}");
        }

        public void Sort()
        {
            this.Works = this.Works
                .OrderByDescending(x => x.Money)
                .ThenBy(x => x.Index)
                .ToList();
        }
    }
}
