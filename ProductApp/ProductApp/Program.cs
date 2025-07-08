namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "pencil", 10);
            Product p2 = new Product(2, "pen", 50);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
