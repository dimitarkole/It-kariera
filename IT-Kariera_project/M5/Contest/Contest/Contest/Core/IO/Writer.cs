using CryptoMiningSystem.Core.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contest.Core.IO
{
    public class Writer : IWriter
    {
        public void Write(string line)
        {
            Console.WriteLine(line);
        }
    }
}
