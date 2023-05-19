namespace Enumerables.logic
{
    public static class Matrix
    {
        public static int[,] GetFillMyMatriz(int x, int y)
        {
            int[,] Array = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Array[i, j] = (i + 1) * j;

                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }

            return Array;
        }

        public static int[,] GetMultiplyMatriz(int[,] A, int[,] B)
        {
            int m = A.GetLength(0);
            int n = B.GetLength(0);
            int p = B.GetLength(1);
            int[,] C = new int[m, p];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }

        public static String ToString(int[,] numbers)
        {
            var output = string.Empty;
            foreach (int number in numbers)
            {
                output += $"{number}\t";
            }

            return output + "\n";
        }
    }
}