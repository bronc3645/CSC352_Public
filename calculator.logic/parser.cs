using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.logic
{
    public class parser
    {
        public static string ConvertTorpm(string equation)
        {
            Queue<string> output = new Queue<string>();
            Stack<string> operatorstack= new Stack<string>();

            string[] split = equation.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach(string token in split)
            {
                if (char.IsNumber(token.First()) || (token.Length > 1 && (token.StartsWith(".") || token.StartsWith("-"))))
                {
                    output.Enqueue(token);
                }
                else
                {
                    operatorstack.Push(token);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var outputElement in output)
            {
                sb.Append(outputElement);
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
