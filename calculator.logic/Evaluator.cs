using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.logic
{
    public class Evaluator
    {
        public static double Eval(string rpn)
        {
            string[] split = rpn.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>();
            foreach(string token in split)
            {
                if (isOperator(token)){
                    double right = double.Parse(stack.Pop());
                    double left = double.Parse(stack.Pop());
                    switch (token)
                    {
                        case "+":
                            {
                                stack.Push(""+(left + right));
                                break;
                            }
                        case "-":
                            {
                                stack.Push("" + (left - right));
                                break;
                            }
                        case "*":
                            {
                                stack.Push("" + (left * right));
                                break;
                            }
                        case "/":
                            {
                                stack.Push("" + (left / right));
                                break;
                            }
                        case "^":
                            {
                                stack.Push("" + (Math.Pow(left, right)));
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else{
                    stack.Push(token);
                }
            }
            if (stack.Count == 1)
            {
                return double.Parse(stack.Pop());
            }
            else
            {
                throw new Exception();
            }
        }

        private static bool isOperator(string token)
        {
            switch (token)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                    return true;
                default:
                    return false;
            }
        }
    }
}
