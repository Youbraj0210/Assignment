namespace PrimeNumber
{
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            bool isPrime = true;
            for(int i = 2; i < n / 2; i++)
            {
                if(n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
        static void Main(string[] args)
        {
            int number = 23;
            Console.WriteLine(IsPrime(number));
        }
    }
}
