using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Core.IO.Contracts
{
    public interface IWriter
    {
        void Write(string line);

    }
}
