using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilyAfterAtack()
        {
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.AreEqual(2, axe.DurabilityPoints, "Axe Durability dosn't change after atack.");
        }

        [Test]
        public void BrokenAxeCantAtack()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);
            axe.Attack(dummy);
            axe.Attack(dummy);
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message,Is.EqualTo("Axe is broken."));
        }
    }
}
