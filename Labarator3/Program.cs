using System;

namespace Labarator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of movies: ");
            int n = int.Parse(Console.ReadLine());

        Movie[] movies = new Movie[n];

            for (int i = 0; i < n; i++)
            {
                movies[i] = new Movie();

                Console.WriteLine(
                    "\nEnter movie information separated by spaces:"
                );

                Console.WriteLine(
                    "Format: Number Name Year Genre(1-5) Views Likes"
                );

                string input = Console.ReadLine();
                string[] data = input.Split(' ');

                movies[i].number = int.Parse(data[0]);
                movies[i].name = data[1];
                movies[i].year = int.Parse(data[2]);

                int genreNumber = int.Parse(data[3]);

                switch (genreNumber)
                {
                    case 1:
                        movies[i].genre = Genre.Action;
                        break;

                    case 2:
                        movies[i].genre = Genre.Comedy;
                        break;

                    case 3:
                        movies[i].genre = Genre.Drama;
                        break;

                    case 4:
                        movies[i].genre = Genre.Horror;
                        break;

                    case 5:
                        movies[i].genre = Genre.Romance;
                        break;

                    default:
                        throw new ArgumentException(
                            "Genre must be between 1 and 5."
                        );
                }

                movies[i].views = int.Parse(data[4]);
                movies[i].likes = int.Parse(data[5]);
            }

            Console.WriteLine("\nMovie List:");

            Console.WriteLine(
                String.Format(
                    "{0,4}{1,-15}{2,-8}{3,-12}{4,8}",
                    "No.",
                    "Name",
                    "Year",
                    "Genre",
                    "Rating"
                )
            );

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(movies[i].ToString());
            }
        }
    }
}
