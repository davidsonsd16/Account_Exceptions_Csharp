using System;
using System.Globalization;
using Account_Exceptions_Csharp.Entities.Exceptions;

namespace Account_Exceptions_Csharp.Entities {
    class Account {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount) {
            Balance += amount;
            Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void Withdraw (double amount) {
            if (amount > Balance) {
                throw new DomainException("Not enough balance");
            }
            if (amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            Balance -= amount;
            Console.WriteLine("New balance: "+ Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
