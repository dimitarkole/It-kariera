using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            var activityList = new ActivitiesList();
            activityList.InputData(n);
            activityList.solve();
        }
    }
}
