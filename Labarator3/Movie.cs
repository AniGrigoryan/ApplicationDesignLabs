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
internal class Movie
    {
        public int number;
        public string name;
        public int year;
        public Genre genre;
        public int views;
        public int likes;

        public double Rating()
        {
            return Math.Sqrt((double)likes * likes / views);
        }

        public override string ToString()
        {
            return String.Format(
                "{0,4}{1,-15}{2,-8}{3,-12}{4,8:0.000}",
                number,
                name,
                "(" + year + ")",
                genre,
                Rating()
            );
        }
    }

}
