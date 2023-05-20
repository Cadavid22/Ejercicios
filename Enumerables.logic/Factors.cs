namespace Ejercicios
{
    public static class Factors
    {
        public static List<int> GetPrimeFactors(int number)
        {

            List<int> Factors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    Factors.Add(number / divisor);
                    number /= divisor;
                }
                else
                {
                    divisor++;
                }
            }
            return Factors;
        }

        public static string ToString(int[] numbers)
        {
            var output = string.Empty;
            foreach (int number in numbers)
            {
                output += $"{number}\t";
            }

            return output;
        }

    }
}