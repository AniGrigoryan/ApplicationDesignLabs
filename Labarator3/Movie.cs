using System;

namespace Labarator3
{
    public enum Genre
    {
        Action = 1,
        Comedy,
        Drama,
        Horror,
        Romance
    }
public class Movie
    {
        public int Number;
        public string Title;
        public int Year;
        public Genre Genre;
        public int Views;
        public int Likes;

        public Movie(int number, string title, int year, Genre genre, int views, int likes)
        {
            Number = number;
            Title = title;
            Year = year;
            Genre = genre;
            Views = views;
            Likes = likes;
        }

        public double CalculateRating()
        {
            if (Views <= 0)
                return 0;

            return Math.Sqrt((double)Likes * Likes / Views);
        }

        public override string ToString()
        {
            return string.Format(
                "{0,4}{1,-15}{2,-8}{3,-12}{4,8:F3}",
                Number,
                Title,
                $"({Year})",
                Genre,
                CalculateRating()
            );
        }

        public static Genre GetGenre(int genreNumber)
        {
            switch (genreNumber)
            {
                case 1:
                    return Genre.Action;
                case 2:
                    return Genre.Comedy;
                case 3:
                    return Genre.Drama;
                case 4:
                    return Genre.Horror;
                case 5:
                    return Genre.Romance;
                default:
                    throw new ArgumentException("Genre must be between 1 and 5.");
            }
        }
    }

}
