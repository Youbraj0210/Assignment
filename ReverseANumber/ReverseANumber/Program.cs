namespace ReverseANumber
{
    internal class Program
    {
        public static void ReverseNumber(int number)
        {
            int savedNumber = number;
            int reverse = 0;
            while (number > 0)
            {
                int temp = number % 10;
                reverse = reverse * 10 + temp;
                number /= 10;
            }

            Console.WriteLine(reverse);

            if (savedNumber == reverse)
            {
                Console.WriteLine($"{savedNumber} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{savedNumber} is not a Palindrome");

            }

        }
        static void Main(string[] args)
        {
            ReverseNumber(12334);
        }
    }
}
