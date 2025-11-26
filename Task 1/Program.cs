using System;

namespace DotNetAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the BankAccount object
            BankAccount myAccount = new BankAccount("ACC123", 500);

            // Now display the account number....
            Console.WriteLine("Account Number: " + myAccount.AccountNumber);

            // Depositing the money 
            myAccount.Deposit(200);

            // WNow withdrawing the money
            myAccount.Withdraw(100);

            // Printing the remaining balance....
            Console.WriteLine("Remaining Balance: " + myAccount.Balance);

            Console.ReadLine();
        }
    }
}
