using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAnimal: IMakeNoise, IMakeTrick
    {
        void Perform();
    }
}
