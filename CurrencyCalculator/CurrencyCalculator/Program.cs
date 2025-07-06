namespace CurrencyCalculator
{
    internal class Program
    {
        static void ProvideNotes(int amount, out int Two1000, out int Five100, out int Two100, out int One100)
        {
            Two1000 = 0; Five100 = 0; Two100 = 0; One100 = 0;
            if (amount > 50000)
            {
                Console.WriteLine("Amount should not exceed 50000");
                return;
            }
            else if (amount % 100 != 0)
            {
                Console.WriteLine("Amount should be in multiples of 100");
                return;
            }

            while (amount != 0)
            {
                if (amount >= 2000)
                {
                    amount -= 2000;
                    Two1000++;
                }
                else if (amount >= 500)
                {
                    amount -= 500;
                    Five100++;
                }
                else if (amount >= 200)
                {
                    amount -= 200;
                    Two100++;
                }
                else
                {
                    amount -= 100;
                    One100++;
                }
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Withdrawal Amount: ");
            int.TryParse(Console.ReadLine(), out int amount);


            ProvideNotes(amount, out int TwoThousand, out int FiveHundred, out int TwoHundred, out int OneHundred);

            Console.WriteLine("2000 notes: {0}, 500 notes : {1}, 200 notes: {2}, 100 notes: {3}", TwoThousand, FiveHundred, TwoHundred, OneHundred);
        }
    }
}
