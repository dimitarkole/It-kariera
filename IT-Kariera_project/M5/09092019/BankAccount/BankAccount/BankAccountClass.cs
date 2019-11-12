using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccountClass
    {
        public decimal Balance { get; set; }

        public int Id { get; set; }

        public BankAccountClass(decimal amount)
        {
            this.Balance = amount;

        }

        public BankAccountClass()
            : this(0) {       }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("The amount must be over than ziro!");
            }
            this.Balance += amount;
        }
    }
}
