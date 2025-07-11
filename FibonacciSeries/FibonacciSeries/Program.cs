namespace FibonacciSeries
{
    internal class Program
    {
        public static void fibo(int count)
        {
            int currNumber = 0, nextNumber = 1;

            Console.Write(currNumber + " " + nextNumber + " ");
            do
            {
                int temp = currNumber + nextNumber;
                currNumber = nextNumber;
                nextNumber = temp;
                Console.Write(temp + " ");
                count--;

            } while (count != 0);
        }
        static void Main(string[] args)
        {
            fibo(10);
        }
    }
}
