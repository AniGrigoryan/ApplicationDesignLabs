using System;

namespace Labarator2
{
    internal class Program
    {
        static int ToMultiplicate(int x, int N = 2)
        {
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                result += x;
            }

            return result;
        }

        static double ToMultiplicate(double x, int N = 2)
        {
            double result = 0;

            for (int i = 0; i < N; i++)
            {
                result += x;
            }

            return result;
        }

        static string ToMultiplicate(string x, int N = 2)
        {
            string result = "";

            for (int i = 0; i < N; i++)
            {
                result += x;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToMultiplicate(5, 3));
            Console.WriteLine(ToMultiplicate(2.5, 4));
            Console.WriteLine(ToMultiplicate("Hi", 3));

            Console.WriteLine();

            Console.WriteLine(ToMultiplicate(10));
            Console.WriteLine(ToMultiplicate(1.5));
            Console.WriteLine(ToMultiplicate("Hello"));
        }
    }
}
