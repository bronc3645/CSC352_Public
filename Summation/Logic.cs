using System;
using System.Collections.Generic;

namespace Summation
{
    public class Logic
    {
        public static long Summation(long n)
        {
            /*if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + Summation(n - 1);
            }*/

            long result = 0;

            for (long i = n; i > 0; i--)
            {
                result += i;
            }
            return result;

            /*Stack<long> stack = new Stack<long>();

            while (n != 0)
            {
                stack.Push(n);
                n -= 1;
            }

            long result = 0;

            while (stack.Count != 0)
            {
                result += stack.Pop();
            }

            return result;*/
        }
    }
}
