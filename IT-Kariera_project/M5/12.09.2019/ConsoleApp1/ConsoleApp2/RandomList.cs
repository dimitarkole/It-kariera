using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RandomList: ArrayList
    {
        private Random rnd;
        public List<string> data;

        public string RandomString()
        {
            int element = rnd.Next(0, data.Count - 1);
            string str = data[element];
            data.Remove(str);
            return str;

        }
    }
}
