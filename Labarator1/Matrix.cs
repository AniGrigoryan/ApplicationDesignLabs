using System;

namespace Labarator1
{
    internal class Matrix
    {
        private int N;
        private int A;
        private int B;
    private int[,] matrix;

        public int n
        {
            get => N;
            set => N = value > 0
                ? value
                : throw new ArgumentException("N must be positive.");
        }

        public int a
        {
            get => A;
            set => A = value;
        }

        public int b
        {
            get => B;
            set => B = value;
        }

        public Matrix(int n, int a, int b)
        {
            if (n <= 0)
                throw new ArgumentException("N must be positive.");

            if (a > b)
                throw new ArgumentException("A must be less than or equal to B.");

            N = n;
            A = a;
            B = b;

            matrix = new int[N, N];

            FillMatrix();
        }

        private void FillMatrix()
        {
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }

                Console.WriteLine();
            }
        }

        public int CountOddNumbers()
        {
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }

}
