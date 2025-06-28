using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoviesApp
{
    internal class Movie
    {
        public int MovieId {  get; set; }
        public string Name {  get; set; }
        public string Genre { get; set; }
        public int Year {  get; set; }

        public Movie(int movieId, string name, string genre, int year)
        {
            MovieId = movieId;
            Name = name;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            string str = $"movieID: {MovieId} movieName: {Name} Genre: {Genre} Year: {Year}";
            return str;
        }
    }

    internal class MovieManager
    {
        Movie[] movies = new Movie[10];

        static int count = 0;

        public void DisplayMovies()
        {
            if(count == 0)
            {
                Console.WriteLine("There are no movies to display!");
                return;
            }

            foreach(Movie movie in movies)
            {
                if(movie != null)
                {
                    Console.WriteLine(movie.ToString());
                }
            }
        }

        public void AddMovies()
        {
            if(count == movies.Length)
            {
                Console.WriteLine("No more movies can be added!");
                return;
            }
            Console.Write("movieID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("movieName: ");
            string name = Console.ReadLine();
            Console.Write("movie genre: ");
            string genre = Console.ReadLine();
            Console.Write("year: ");
            int year = int.Parse(Console.ReadLine());

            Movie movie = new Movie(id, name, genre, year);
            movies[count++] = movie;
            Console.WriteLine("Movie Added!");
        }

        public void ClearAll()
        {
            for(int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    movies[i] = null;
                    count--;
                }
            }
            Console.WriteLine("cleared All!");
        }
    }
}
