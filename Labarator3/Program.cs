using Labarator3;
using System;

namespace Labarator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of movies: ");
            int count = int.Parse(Console.ReadLine());

        Movie[] movies = new Movie[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter information for movie {i + 1}:");

                Console.Write("Movie number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Genres: 1-Action, 2-Comedy, 3-Drama, 4-Horror, 5-Romance");
                Console.Write("Genre number: ");
                int genreNumber = int.Parse(Console.ReadLine());

                Genre genre = Movie.GetGenre(genreNumber);

                Console.Write("Views: ");
                int views = int.Parse(Console.ReadLine());

                Console.Write("Likes: ");
                int likes = int.Parse(Console.ReadLine());

                movies[i] = new Movie(number, title, year, genre, views, likes);
            }

            Console.WriteLine("\nMovie List:");
            Console.WriteLine(
                string.Format(
                    "{0,4}{1,-15}{2,-8}{3,-12}{4,8}",
                    "No.",
                    "Title",
                    "Year",
                    "Genre",
                    "Rating"
                )
            );

            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }

}
