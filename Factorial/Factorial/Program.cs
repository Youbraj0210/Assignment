namespace Factorial
{
    internal class Program
    {
        public static int Factorial(int num)
        {
            int fact = 1;
            while (num != 1)
            {
                fact *= num;
                num--;
            }

            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
