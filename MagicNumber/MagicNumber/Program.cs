namespace MagicNumber
{
    internal class Program
    {
        static int SumOfDigits(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }

        static bool IsMagicNumber(int num)
        {
            return SumOfDigits(num) == 1;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter any Number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsMagicNumber(num))
                Console.WriteLine($"{num} is a magic number");
            else
                Console.WriteLine($"{num} is not a magic number");
        }
    }
}