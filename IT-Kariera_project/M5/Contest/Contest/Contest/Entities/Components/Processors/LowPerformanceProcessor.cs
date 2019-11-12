using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public class LowPerformanceProcessor : Processor
    {
        public LowPerformanceProcessor(string model, int mineMiltiplier, decimal price)
            : base(model, 2, price)      
        {
        }
    }
}
