using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }

        public Movie(int id, string name, int yearOfRelease, string genre)
        {
            Id = id;
            Name = name;
            YearOfRelease = yearOfRelease;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"id: {Id} name: {Name} year: {YearOfRelease} genre: {Genre}";
        }
    }

    internal class MovieManager
    {
        List<Movie> movies = new List<Movie>();

        public void AddMovie()
        {
            try
            {
                if (movies.Count >= 5)
                {
                    throw new MaximumMoviesException("Limit Reached!");
                }

                Console.Write("Enter id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter year of release: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Enter genre: ");
                string genre = Console.ReadLine();

                Movie movie = new Movie(id, name, year, genre);
                movies.Add(movie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void FindMovieByID()
        {
            try
            {
                Console.Write("Enter movie ID: ");
                int id = int.Parse(Console.ReadLine());

                bool exist = false;
                foreach (Movie movie in movies)
                {
                    if (movie.Id == id)
                    {
                        exist = true;
                        Console.WriteLine(movie.ToString());
                    }
                }

                if (!exist)
                {
                    throw new InvalidIdException("The movie with this id doesnot exist!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplayAllMovies()
        {
            if(movies.Count == 0)
            {
                Console.WriteLine("No movies to display!");
                return;
            }

            Console.WriteLine("-----MOVIES-----");
            foreach(Movie movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        public void ClearAllMovies()
        {
            movies.Clear();
            Console.WriteLine("All moves Cleared!");
        }

        public void RemoveMovieByID()
        {
            try
            {
                Console.Write("Enter movie ID: ");
                int id = int.Parse(Console.ReadLine());

                bool exist = false;
                foreach (Movie movie in movies)
                {
                    if (movie.Id == id)
                    {
                        exist = true;
                        movies.Remove(movie);
                        break;
                    }
                }

                if (!exist)
                {
                    throw new InvalidIdException("The movie with this id doesnot exist!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
