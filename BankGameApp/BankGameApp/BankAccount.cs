using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGameApp
{
    internal class BankAccount
    {
        public string AccountHolder {  get; set; }
        public double Balance {  get; set; }

        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            if(Balance < amount)
            {
                Console.WriteLine("balance is less than the amount!");
                return;
            }

            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
