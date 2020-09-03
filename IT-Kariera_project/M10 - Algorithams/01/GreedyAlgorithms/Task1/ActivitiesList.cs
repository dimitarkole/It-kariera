using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class ActivitiesList
    {
        public ActivitiesList()
        {
            this.Activities = new List<ActivityInputModel>();
        }

        public List<ActivityInputModel> Activities { get; set; }

        public void InputData(int n)
        {
            List<string> inputData = new List<string>();
            inputData.Add("a1 1 3");
            inputData.Add("a2 0 4");
            inputData.Add("a3 1 2");
            inputData.Add("a4 4 6");
            inputData.Add("a5 2 9");
            inputData.Add("a6 5 8");
            inputData.Add("a7 3 5");
            inputData.Add("a8 4 5");

            for (int i = 0; i < n; i++)
            {
                var data = inputData[i].Split(" ");
                var newActivity = new ActivityInputModel(data[0], int.Parse(data[1]), int.Parse(data[2]));
                Activities.Add(newActivity);
            }

            this.Sort();
        }

        public void Sort()
        {
            this.Activities = this.Activities.OrderBy(x => x.End).ToList();
        }

        public void solve()
        {
            var n = this.Activities.Count();
            var maxStack = new Stack<ActivityInputModel>();
            for (int i = 0; i < n; i++)
            {
                var stack = new Stack<ActivityInputModel>();
                var fakeData = new List<ActivityInputModel>(this.Activities);
                stack.Push(fakeData[i]);
                fakeData.RemoveAt(i);
                // bussinnes logic here
                var element = new ActivityInputModel();
                while ((element = fakeData
                        .FirstOrDefault(x => x.Start >= stack.Peek().End))!=null)
                {
                    stack.Push(element);
                    fakeData.Remove(element);
                }

                if(stack.Count > maxStack.Count)
                {
                    maxStack = new Stack<ActivityInputModel>(stack);
                }
            }
            var r = ListToString(maxStack.ToList());
            Console.WriteLine(r);
            Console.WriteLine(maxStack.Count());
        }
      
        public override string ToString()
        {
            return ListToString(this.Activities);
        }

        private string ListToString(List<ActivityInputModel> list)
        {
            var sb = new StringBuilder();
            foreach (var аctivity in list)
            {
                try
                {
                    sb.AppendLine(аctivity.ToString());

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return sb.ToString().Trim();
        }
    }
}


/*
  for (int p = 0; p < n; p++)
            {
                int i = p, j = 0;
                Console.Write("Izbrani lekcii - ");
                while (j++ < n-1)
                {
                    if (this.Activities[j].End < this.Activities[i].Start)
                    {
                        i = j;
                        Console.Write(" " + this.Activities[i].Name);
                    }
                }
                Console.WriteLine();
            }
 * 
 * */