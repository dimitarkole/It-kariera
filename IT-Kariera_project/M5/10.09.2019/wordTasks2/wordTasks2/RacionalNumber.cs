using System;
using System.Collections.Generic;
using System.Text;

namespace wordTasks2
{
    class RacionalNumber
    {
        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denumerator;

        public int Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}"; 
        }

    }
}
