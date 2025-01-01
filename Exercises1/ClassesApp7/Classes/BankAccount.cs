using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp7.Classes
{
    internal class BankAccount
    {
        // Fields
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        // Parameterized Constructor
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance is {Balance:C}.");
        }

        // Withdraw Method
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException("Withdrawal amount exceeds the current balance.");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance is {Balance:C}.");
        }
    }
}
