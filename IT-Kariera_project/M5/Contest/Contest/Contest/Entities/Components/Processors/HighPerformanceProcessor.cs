using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public class HighPerformanceProcessor : Processor
    {
        public HighPerformanceProcessor(string model, int mineMiltiplier, decimal price)
                    : base(model, 8, price)
        {
        }
    }
}
