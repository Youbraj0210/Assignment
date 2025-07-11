namespace CountWords
{
    internal class Program
    {
        public static void Count()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Split the sentence by whitespace, and remove empty entries
            string[] words = sentence.Split(' ');

            Console.WriteLine($"Number of words: {words.Length}");
        }
        static void Main(string[] args)
        {
            Count();
        }
    }
}
