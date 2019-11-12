using System;

namespace Exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("FName", "LName", 1);
            var person2 = new Person("FName", "LName", 1);
            var person3 = new Person("FName", null , 1);
            var person4 = new Person("FName", "LName", -41);
            var person5 = new Person("FName", "LName", 150);




        }
    }
}
