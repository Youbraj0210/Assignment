namespace BasicStatsCommandLineArgs
{
    internal class Program
    {
        static int Sum(string[] str)
        {
            int sum = 0;
            foreach (string num in str)
            {
                int number = int.Parse(num);
                sum += number;
            }

            return sum;
        }

        static int Avg(int sum, int length)
        {
            return sum / length;
        }

        static int mini(string[] str)
        {
            int min = int.MaxValue;
            foreach (string num in str)
            {
                int number = int.Parse(num);
                if (min > number)
                    min = number;
            }

            return min;
        }

        static int maxi(string[] str)
        {
            int max = int.MinValue;
            foreach (string num in str)
            {
                int number = int.Parse(num);
                if (max < number)
                    max = number;
            }
            return max;
        }

        static void Calc(string[] str)
        {
            int sum = Sum(str);
            int Average = Avg(sum, str.Length);
            int min = mini(str);
            int max = maxi(str);

            Console.WriteLine("\nsum: {0}, min: {1}, max: {2} , Average: {3}", sum, min, max, Average);

        }
        static void Main(string[] args)
        {
            Calc(args);
        }
    }
}
