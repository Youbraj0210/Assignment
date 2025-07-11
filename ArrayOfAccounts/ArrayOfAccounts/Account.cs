using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
    internal class Account
    {
        /**
         * 
         * 
         * Account(accountNumber, name, balance, accountType -> savings/current). Constructors, getters, setters
    deposit(amount), withdraw(amount) -> you have maitain minimum balance of 500.
    accountNumber must be generated randomly.(IDBI10003456789)
    Create an account and test it using menu driven code.
    1. Create an Account
    2. View Balance
    3. Deposit
    4. Withdraw
    5. Exit
 
    Enter your choice: 
         * **/

        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AccountTpye { get; set; }

        private int minBalance = 500;

        public string CreateAccountNumber()
        {
            Random random = new Random();
            int number = random.Next(100000000, 999999999);
            string str = "ICIC" + number;
            return str;
        }

        public Account(string name, int balance, string accountTpye)
        {
            AccountNumber = CreateAccountNumber();
            Name = name;
            Balance = balance;
            AccountTpye = accountTpye;
            Console.WriteLine("Your Account Number is : " + AccountNumber);
        }

        public void Deposit()
        {
            Console.Write("What amount you want to deposit: ");
            int amount = int.Parse(Console.ReadLine());

            Balance += amount;
        }

        public void Withdraw()
        {
            if (Balance == 500)
            {
                Console.WriteLine("You cannot withdraw more amount reached Min Balance");
                return;
            }

            Console.Write("What amount you want to deposit: ");
            int amount = int.Parse(Console.ReadLine());

            if (Balance - amount < 500)
            {
                Console.WriteLine("You cannot withdraw more amount reached Min Balance");
                return;
            }

            Balance -= amount;


        }
    }

    internal class AccountManager
    {
        List<Account> accounts = new List<Account>();

        public void CreateAccount()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial Balance: ");
            int balance = int.Parse(Console.ReadLine());
            if(balance < 500)
            {
                Console.WriteLine("should be min 500");
                return;
            }
            Console.Write("Account Type Current OR Savings");
            string accountTpye = Console.ReadLine();

            Account account = new Account(name, balance, accountTpye);
            accounts.Add(account);
        }

        public void DisplayBalance()
        {
            Console.Write("Enter Account number: ");
            string accountNumber = Console.ReadLine();

            foreach(Account account in accounts)
            {
                if(account.AccountNumber == accountNumber)
                {
                    Console.WriteLine("Total Balance: "+account.Balance);
                    return;
                }
            }

            Console.WriteLine("No Such Account!");
        }

        public void DepositAmount()
        {
            Console.Write("Enter Account number: ");
            string accountNumber = Console.ReadLine();

            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    account.Deposit();
                    return;
                }
            }
            Console.WriteLine("No Such Account!");

        }

        public void WithdrawAmount()
        {
            Console.Write("Enter Account number: ");
            string accountNumber = Console.ReadLine();

            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    account.Withdraw();
                    return;
                }
            }
            Console.WriteLine("No Such Account!");
        }
    }
}
