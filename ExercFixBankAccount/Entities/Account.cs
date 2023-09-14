using System;
using ExercFixBankAccount.Entities.Exceptions;
namespace ExercFixBankAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance!");
            }

            Balance -= amount;
        }
    }
}
