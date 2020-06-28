using DivisionExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisonExample.Tests
{
    [TestFixture]
    public class TestDivision
    {
        [Test]
        public void Dividing4By2Gives2()
        {
            Divider div = new Divider();
            var result = div.Divide(4, 2);

            Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
        }


        [Test]
        public void DividingBy0Gives0()
        {
            Divider div = new Divider();
            var result = div.Divide(4, 0);

            Assert.AreEqual(0, result, "Dividing by 0 does not result in 0.");
        }
    }
}
