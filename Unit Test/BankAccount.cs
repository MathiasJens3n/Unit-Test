using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class BankAccount
    {
        public decimal Balance { get; private set; }
        public BankAccount(decimal balance)
        {
            Balance = balance;
        }
        public bool WithdrawMoney(decimal enteredAmount)
        {
            return enteredAmount <= Balance;
        }
    }
}
