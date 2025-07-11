namespace InOutParams
{
    internal class Program
    {
        static void PrintNames(params string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("No names were provided.");
            }
            else
            {
                Console.WriteLine("Names:");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
        static void AddFive(in int x, out int res)
        {
            res = x + 5;
        }
        static void Main(string[] args)
        {

            int a = 10;
            int result;
            AddFive(in a, out result);
            Console.WriteLine($"Original value (in): {a}");
            Console.WriteLine($"Result after adding 5 (out): {result}\n");

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int parsedNumber);
            if (success)
            {
                Console.WriteLine($"Valid number entered: {parsedNumber}\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
            }

            PrintNames("Alice", "Bob", "Charlie");
            PrintNames();

            Console.WriteLine("Mixing types: {0}, {1}, {2}", 42, "hello", 3.14);
        }

        
    }
}