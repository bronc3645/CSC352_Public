namespace FunWithLoops
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        internal static IEnumerable<int> NumbersOneThruTwentyFive()
        {
            for (int i = 1; i <= 25; i++)
            {
                yield return i;
            }
        }

        internal static IEnumerable<int> EvenNumbersOneThruTwentyFive()
        {
            for (int i = 2; i <= 25; i+=2)
            {
                yield return i;
            }
        }

        internal static IEnumerable<int> OddNumbersOneThruTwentyFive()
        {
            for (int i = 1; i <= 25; i += 2)
            {
                yield return i;
            }
        }

        internal static IEnumerable<int> PrimeNumbersOneThruTwentyFive()
        {
            for (int i = 1; i <= 25; i ++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }

        internal static bool IsPrime(int number)
        {
            bool test = false;
            if (number == 2)
            {
                test = true;
            }
            else if (number > 2)
            {
                test = true;
                for (int i = 2; i <= number/2; i++)
                {
                    if (number % i == 0)
                    {
                        test = false;
                        break;
                    }
                }
            }
            return test;

        }

        internal static IEnumerable<int> GetNumbersOneThru(int thruInclusive)
        {
            for (int i = 1; i <= thruInclusive; i ++)
            {
                yield return i;
            }
        }

        internal static IEnumerable<int> GetRangeThruInclusive(int start, int end)
        {
            for (int i = start; i <= end; i ++)
            {
                yield return i;
            }
        }

        internal static IEnumerable<int> GetPrimesInRangeInclusive(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }
    }
}
