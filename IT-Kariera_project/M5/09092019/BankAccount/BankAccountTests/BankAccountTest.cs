using BankAccount;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTests
{
    [TestFixture]

    public class BankAccountTest
    {
        BankAccountClass account;
        [SetUp]
        public void StartUp()
        {
            account = new BankAccountClass();
        }

        [Test]
        public void AcountInitializeWithPositiveValue()
        {
            //BankAccountClass acount = new BankAccountClass(2000m);
            decimal depositivAmount = -100;
            account.Deposit(depositivAmount);
            Assert.AreEqual(2000m, account.Balance);
        }

        [Test]
        public void DepositShouldAddMoney()
        {
            account.Deposit(50);
            Assert.IsTrue(account.Balance == 50);
        }

        [Test]
        public void DepositAmountMustBePositiveException()
        {
            decimal depositivAmount = -100;

            Assert.Throws<InvalidOperationException>(
            () => {
                account.Deposit(depositivAmount);
            });
        }


        [TestCase(100)]
        [TestCase(200)]
        [TestCase(30)]
        [TestCase(-230)]
        public void AccountInitializeWithPositiveValue()
        {
            //BankAccountClass acount = new BankAccountClass(2000m);
            decimal depositivAmount = -100;
            account.Deposit(depositivAmount);
            Assert.AreEqual(2000m, account.Balance);
        }
    }

}
