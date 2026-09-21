namespace Ch04Ex02PrimeFactorsLib;

public static class PrimeFactorsHelper
{
    public static string PrimeFactors(int number)
    {
        List<int> factors = new List<int>();

        for (int factor = 2; factor <= number; factor++)
        {
            while (number % factor == 0)
            {
                factors.Add(factor);
                number /= factor;
            }
        }

        return string.Join(" x ", factors);
    }
}