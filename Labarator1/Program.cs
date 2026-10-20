using System;

namespace Labarator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(5, 1, 20);

        Console.WriteLine("Matrix:");
            matrix.ShowMatrix();

            Console.WriteLine();

            Console.WriteLine(
                $"Number of odd elements: {matrix.CountOddNumbers()}"
            );
        }
    }

}
