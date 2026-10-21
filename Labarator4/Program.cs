using System;

namespace Labarator4
{
    internal class Program
    {
        static void A(in int x)
        {
            Console.WriteLine("A method (in): " + x);
        }
    static void B(out int x)
        {
            x = 20;
            Console.WriteLine("B method (out): " + x);
        }

        static void C(ref int x)
        {
            x = x + 10;
            Console.WriteLine("C method (ref): " + x);
        }

        static int SumValues(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int a = 5;

            Console.WriteLine("Testing in:");
            A(in a);
            Console.WriteLine("Value after A: " + a);

            Console.WriteLine();

            Console.WriteLine("Testing out:");
            int b;
            B(out b);
            Console.WriteLine("Value after B: " + b);

            Console.WriteLine();

            Console.WriteLine("Testing ref:");
            int c = 15;
            C(ref c);
            Console.WriteLine("Value after C: " + c);

            Console.WriteLine();

            Console.WriteLine("Testing params:");
            Console.WriteLine("Sum = " + SumValues(1, 2, 3));
            Console.WriteLine("Sum = " + SumValues(10, 20, 30, 40, 50));
            Console.WriteLine("Sum = " + SumValues(7, 8));
        }
    }
}
