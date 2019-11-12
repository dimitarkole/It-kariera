using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Creature
    {
        private string name, areal;
        private int years;

        public string getName()
        {
            return this.name;
        }

        public string getAreal()
        {
            return this.areal;
        }

        public int getYears()
        {
            return this.years;
        }

        public void setName(string value)
        {
            this.name = value;
        }

        public void setAreal(string value)
        {
            this.name = value;
        }
       
        public void setYears(int value)
        {
            this.years= value;
        }

    }
}
