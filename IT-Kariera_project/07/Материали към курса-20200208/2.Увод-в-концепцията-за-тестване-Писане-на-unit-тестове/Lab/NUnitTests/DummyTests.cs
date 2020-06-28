using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesDurabilyAfterAtack()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(5);
            Assert.AreEqual(5, dummy.Health, "Dummy healt dosn't change after atack.");
        }

        [Test]
        public void DiadDummy()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(5);
            dummy.TakeAttack(5);
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(5));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DiadDummyCouldGiveXP()
        {
            Dummy diedDummy = new Dummy(-10, 10);
            var result = diedDummy.GiveExperience();

            Assert.AreEqual(10, result, "Diad Dummy Couldn't Give XP.");
        }

        [Test]
        public void LiveDummyCouldntGiveXP()
        {
            Dummy dummy = new Dummy(10, 10);
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
