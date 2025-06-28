namespace SimpleMoviesApp
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            MovieManager manager = new MovieManager();

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("choose: ");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display Student");
                Console.WriteLine("3. Clear All");
                Console.WriteLine("4. exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddMovies();
                        break;
                    case 2:
                        manager.DisplayMovies();
                        break;
                    case 3:
                        manager.ClearAll();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid input!");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
