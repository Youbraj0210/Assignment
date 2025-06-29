namespace StringManipulation
{
    internal class Program
    {
        public static void Seperate(string str)
        {
            string[] strings = str.Split(',');

            Console.WriteLine("Developer name: " + strings[0]);
            Console.WriteLine("Company name: " + strings[1]);
            Console.WriteLine("Location name: " + strings[2]);
        }
        static void Main(string[] args)
        {
            Seperate("Sachin,Aurionrpo,Mumbai");
        }
    }
}
