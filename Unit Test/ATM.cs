using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        private readonly BankAccount bankAccount;
        private readonly PinValidator pinValidator;
        public ATM(decimal balance,string correctPIN) 
        {
            bankAccount = new BankAccount(balance);
            pinValidator = new PinValidator(correctPIN);
        }
        public bool CheckPIN(string enteredPIN)
        {
            return pinValidator.ValidatePIN(enteredPIN);
            
        }
        public bool WithdrawMoney(decimal enteredAmount)
        {
            return bankAccount.WithdrawMoney(enteredAmount);
        }
    }
}
