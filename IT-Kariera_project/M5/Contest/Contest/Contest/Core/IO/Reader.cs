using CryptoMiningSystem.Core.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contest.Core.IO
{
    public class Reader : IReader
    {
        public string Read()
        {
            string line = Console.ReadLine();
            return line;
        }
    }
}
