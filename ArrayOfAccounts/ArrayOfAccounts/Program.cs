namespace ArrayOfAccounts
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            AccountManager manager = new AccountManager();
            int? choice = null;
            do
            {
                Console.WriteLine("\n====== Bank Menu ======");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            manager.CreateAccount();
                        }
                        break;
                    case 2:
                        {
                            manager.DisplayBalance();
                        }
                        break;
                    case 3:
                        {
                            manager.DepositAmount();
                        }
                        break;
                    case 4:
                        {
                            manager.WithdrawAmount();
                        }
                        break;
                }

            } while (choice != 5);
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
