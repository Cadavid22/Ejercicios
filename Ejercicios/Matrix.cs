using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios
{
    public static class Matrix
    {
        public static int[,] GetFillMyMatriz(int x, int y, string  type)
        {
            int[,] Array = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (type == "A")
                    {
                        Array[i, j] = (i + 1) * j;
                    }
                    else if (type == "B")
                    {
                        Array[i, j] = (j + 1) * i;
                    }
                 }
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

        public static string ToString(int[,] numbers)
        {
            var output = string.Empty;

            int m = numbers.GetLength(0);
            int n = numbers.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    output += $"{numbers[i,j]}\t";
                }
                output += $"\n";
            }

            return output + "\n";
        }
    }
}