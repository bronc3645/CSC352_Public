using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePhoneNumber
{
    class Logic
    {
        internal static string TranslateToPhoneNumbers(int[] numbers)
        {
            //String result = "(" + numbers[0]+numbers[1]+numbers[2]+") "+numbers[3]+numbers[4]+numbers[5]+"-"+numbers[6]+numbers[7]+numbers[8]+numbers[9];
            //return result;
            Queue<string> stack = new Queue<string>();
            stack.Enqueue("(");
            for(int i = 0; i < 3; i++)
            {
                stack.Enqueue(""+numbers[i]);
            }
            stack.Enqueue(") ");
            for(int i = 3; i < 6; i++)
            {
                stack.Enqueue(""+numbers[i]);
            }
            stack.Enqueue("-");
            for(int i = 6; i < 10; i++)
            {
                stack.Enqueue("" + numbers[i]);
            }
            StringBuilder sb = new StringBuilder();
            while (stack.Count != 0)
            {
                sb.Append(stack.Dequeue());
            }
            return sb.ToString();
        }
    }
}
