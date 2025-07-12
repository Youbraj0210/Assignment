namespace FunctionsAndArrays
{
    internal class Program
    {
        public static int[] CalculateDiscount(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 7000)
                    arr[i] = arr[i] - (arr[i] * 5 / 100);
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter fees of 5 students: ");
            for (int i = 0; i < arr.Length; i++)
            {
                int fees = 0;
                Console.WriteLine("Enter fees for Student " + (i + 1));
                fees = int.Parse(Console.ReadLine());
                if (fees >= 5000 && fees <= 10000) { arr[i] = fees; }
                else
                {
                    Console.WriteLine("Error! fees must be in range 5000 to 10000");
                    i--;
                }
            }
            Console.WriteLine("\nFees with discount are as- ");
            Console.WriteLine(string.Join("\n", CalculateDiscount(arr)));
        }
    }
}