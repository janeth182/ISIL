using System;

namespace InterceptionHOL.BusinessLogic
{
    public sealed class BankAccount : MarshalByRefObject
    {
        private decimal balance;

        public decimal GetCurrentBalance()
        {
            return balance;
        }

        public void Deposit(decimal depositAmount)
        {
            balance += depositAmount;
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > balance)
            {
                throw new ArithmeticException();
            }
            balance -= withdrawAmount;
        }
    }
}
