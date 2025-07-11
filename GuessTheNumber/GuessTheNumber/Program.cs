namespace GuessTheNumber
{
    internal class Program
    {
        static void StartGame()
        {
            Random rnd = new Random();
            int generatedNumber = rnd.Next(1, 100);
            int guessedNumber;
            int tries = 0;
            int maxTries = 5;

            do
            {
                if(tries == maxTries)
                {
                    Console.WriteLine("Max tries Reached!");
                    return;
                }
                Console.Write("Guess a number between 1 and 100:");
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber < generatedNumber)
                    Console.WriteLine("Sorry! too Low.");
                if (guessedNumber > generatedNumber)
                    Console.WriteLine("Sorry! too High.");

                tries++;

            } while (guessedNumber != generatedNumber);

            Console.WriteLine("You guessed the number correctly in {0} tries.", tries);
        }
        static void Main(string[] args)
        {
            bool flag = true;


            while (flag)
            {
                Console.Write("Enter 1 to start the game or Enter 0 to exit the game : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Thanks for Playing!");
                            flag = false;
                        }
                        break;
                    case 1:
                        StartGame();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}