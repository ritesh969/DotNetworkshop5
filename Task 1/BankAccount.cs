using System;

namespace DotNetAssignment
{
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Here creating the Constructor to initialize accountNumber and balance
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;

            if (initialBalance > 0)
            {
                this.balance = initialBalance;
            }
            else
            {
                this.balance = 0;
                Console.WriteLine("Initial balance must be greater than 0. Setting balance to 0.");
            }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative or zero.");
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited {amount}. Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}. Remaining balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }
}
