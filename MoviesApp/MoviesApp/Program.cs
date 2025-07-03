using System.Xml.Serialization;

namespace MoviesApp
{
    internal class Program
    {

        public static void DisplayMenu()
        {
            MovieManager movieManager = new MovieManager();
            int choice = 0;
            do
            {
                Console.WriteLine("Welcome to the movie store developed by: Youbraj");
                Console.WriteLine("1. Add new Movie\n2. Display All Movies\n3. Find Movie by ID\n4. Remove Movie by ID\r\n5. Clear All Movies\n6. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            movieManager.AddMovie();
                        }
                        break;
                    case 2:
                        {
                            movieManager.DisplayAllMovies();
                        }
                        break;
                    case 3:
                        {
                            movieManager.FindMovieByID();
                        }
                        break;
                    case 4:
                        {
                            movieManager.RemoveMovieByID();
                        }
                        break;
                    case 5:
                        {
                            movieManager.ClearAllMovies();
                        }
                        break;
                }


            }
            while (choice != 6);


        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
