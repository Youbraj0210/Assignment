namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(101, "Youbraj", 22);
            Player player2 = new Player(102, "Rohan");

            Player result = player2.WhoIsElder(player1);
            Console.WriteLine("\nDetails of older player: ");
            Console.WriteLine($"ID = {result.getId()}, Age = {result.getAge()}, Name = {result.getName()}");
        }
    }
}
