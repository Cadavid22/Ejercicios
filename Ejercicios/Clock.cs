namespace Ejercicios
{
    public static class Clock
    {
        public static int[,] FillMatrix(int N)
        {
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = (i * 2) + j;
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int N = matrix.GetLength(0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] < 10)
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintHourglass(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int mid = n / 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i && j < n - i && i <= mid)
                    {
                        Console.Write("{0,3}", matrix[i, j]);
                    }
                    else if (j >= n - i - 1 && j <= i && i > mid)
                    {
                        Console.Write("{0,3}", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}