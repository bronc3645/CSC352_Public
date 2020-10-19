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

        public static string Eval_stepByStep(string rpn)
        {
            string[] split = rpn.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>();
            Stack<string> temp = new Stack<string>();
            StringBuilder result = new StringBuilder();
            string switc;
            string token;
            for(int i = 0; i < split.Length; i++)
            {
                token = split[i];
                if (isOperator(token))
                {
                    double right = double.Parse(stack.Pop());
                    double left = double.Parse(stack.Pop());
                    switch (token)
                    {
                        case "+":
                            {
                                stack.Push("" + (left + right));
                                while (stack.Count != 0)
                                {
                                    temp.Push(stack.Pop());
                                }
                                while (temp.Count != 0)
                                {
                                    switc = temp.Pop();
                                    stack.Push(switc);
                                    result.Append(switc + " ");
                                }
                                for(int j = i+1; j < split.Length; j++)
                                {
                                    result.Append(split[j]+" ");
                                }
                                result.AppendLine();
                                break;
                            }
                        case "-":
                            {
                                stack.Push("" + (left - right));
                                while (stack.Count != 0)
                                {
                                    temp.Push(stack.Pop());
                                }
                                while (temp.Count != 0)
                                {
                                    switc = temp.Pop();
                                    stack.Push(switc);
                                    result.Append(switc + " ");
                                }
                                for (int j = i + 1; j < split.Length; j++)
                                {
                                    result.Append(split[j] + " ");
                                }
                                result.AppendLine();
                                break;
                            }
                        case "*":
                            {
                                stack.Push("" + (left * right));
                                while (stack.Count != 0)
                                {
                                    temp.Push(stack.Pop());
                                }
                                while (temp.Count != 0)
                                {
                                    switc = temp.Pop();
                                    stack.Push(switc);
                                    result.Append(switc + " ");
                                }
                                for (int j = i + 1; j < split.Length; j++)
                                {
                                    result.Append(split[j] + " ");
                                }
                                result.AppendLine();
                                break;
                            }
                        case "/":
                            {
                                stack.Push("" + (left / right));
                                while (stack.Count != 0)
                                {
                                    temp.Push(stack.Pop());
                                }
                                while (temp.Count != 0)
                                {
                                    switc = temp.Pop();
                                    stack.Push(switc);
                                    result.Append(switc + " ");
                                }
                                for (int j = i + 1; j < split.Length; j++)
                                {
                                    result.Append(split[j] + " ");
                                }
                                result.AppendLine();
                                break;
                            }
                        case "^":
                            {
                                stack.Push("" + (Math.Pow(left, right)));
                                while (stack.Count != 0)
                                {
                                    temp.Push(stack.Pop());
                                }
                                while (temp.Count != 0)
                                {
                                    switc = temp.Pop();
                                    stack.Push(switc);
                                    result.Append(switc + " ");
                                }
                                for (int j = i + 1; j < split.Length; j++)
                                {
                                    result.Append(split[j] + " ");
                                }
                                result.AppendLine();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else
                {
                    stack.Push(token);
                }
            }
            return result.ToString().TrimEnd();
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
