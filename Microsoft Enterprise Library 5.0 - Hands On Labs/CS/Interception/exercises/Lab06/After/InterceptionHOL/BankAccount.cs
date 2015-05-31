using System;

namespace InterceptionHOL.BusinessLogic
{
    public sealed class BankAccount : MarshalByRefObject
    {
        private decimal balance;

        [TraceCallHandler("interception")]
        public decimal GetCurrentBalance()
        {
            return balance;
        }

        [TraceCallHandler("interception")]
        public void Deposit(decimal depositAmount)
        {
            balance += depositAmount;
        }

        [TraceCallHandler("interception")]
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
