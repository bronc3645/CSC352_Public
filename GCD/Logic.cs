using System;

namespace GCD
{
    public class Logic
    {
        public static long gcd(long x, long y)
        {
            /*if (y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }*/

            /*if (x < y)
            {
                long temp = y;
                y = x;
                x = temp;
            }

            long result = 0;

            for(long i = y; i > 0; i--)
            {
                if (x % i == 0 && y % i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;*/

            long gcd=0;

            while (y != 0)
            {
                gcd = y;
                y = x % y;
                x = gcd;
            }

            return gcd;
        }
    }
}
