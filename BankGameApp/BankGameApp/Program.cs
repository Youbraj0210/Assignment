namespace BankGameApp
{
    internal class Program
    {
        public static void ChoiceFunction(BankAccount account)
        {
            Console.Write($"{account.AccountHolder} Withdraw or Deposit (w/d): ");
            string choice = Console.ReadLine();
            if (choice == "w")
            {
                Console.Write("Amount to Withdraw :");
                double amount = int.Parse(Console.ReadLine());

                account.Withdraw(amount);
            }
            else if (choice == "d")
            {
                Console.Write("Amount to Deposit :");
                double amount = int.Parse(Console.ReadLine());

                account.Deposit(amount);
            }
        }
        public static void StartGame()
        {
            Random rnd = new Random();
            double rndBalance1 = 1000 + rnd.NextDouble()*10000;
            Console.WriteLine(rndBalance1);
            double rndBalance2 = 1000 + rnd.NextDouble()*10000;
            Console.WriteLine(rndBalance2);
            BankAccount account1 = new BankAccount("Holder1",rndBalance1);
            BankAccount account2 = new BankAccount("Holder2",rndBalance2);

            int rounds = 3;
            int count = 1;
            while(rounds != 0)
            {
                Console.WriteLine($"Round {count++}: ");
                ChoiceFunction(account1);
                ChoiceFunction(account2);

                rounds--;
            }

            if(account1.Balance > account2.Balance)
            {
                Console.WriteLine($"Account 1 {account1.AccountHolder} won with balance: {account1.Balance}");
            }
            else
            {
                Console.WriteLine($"Account 2 {account2.AccountHolder} won with balance: {account2.Balance}");
            }
        }
        static void Main(string[] args)
        {
            StartGame();
        }
    }
}
