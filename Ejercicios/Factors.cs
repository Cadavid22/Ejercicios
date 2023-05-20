using System;

namespace Ejercicios
{
    public static class PrimeFactors
    {
        public static void GetPrimeFactors(int number)
        {
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i);
                    number /= i;

                    if (number > 1)
                    {
                        Console.Write(" x ");
                    }
                }
            }

            if (number > 1)
            {
                Console.Write(number);
            }

            Console.WriteLine();
        }

    }
}