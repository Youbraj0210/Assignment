namespace LoopsAndArray
{
    internal class Program
    {
        public static void ForLoopDemo()
        {
            Console.WriteLine("For Loop from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i = " + i);
            }
        }

        //  While Loop
        public static void WhileLoopDemo()
        {
            Console.WriteLine("\nWhile Loop from 1 to 5:");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("j = " + j);
                j++;
            }
        }

        //  integer array usage
        public static void IntArrayDemo()
        {
            Console.WriteLine("\nInteger Array Demo:");
            int[] numbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }
        }

        //  string array usage
        public static void StringArrayDemo()
        {
            Console.WriteLine("\nString Array Demo:");
            string[] names = { "Alice", "Bob", "Tejas", "Om" };

            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }
        }


        static void Main()
        {
            ForLoopDemo();
            WhileLoopDemo();
            IntArrayDemo();
            StringArrayDemo();
        }
    }
}
