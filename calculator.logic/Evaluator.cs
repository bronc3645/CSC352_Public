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
            StringBuilder infixresult = new StringBuilder();
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
                                //result.Append(Parser.ConvertToInfix(GeneateCurrentRPN(stack, split.Skip(i + 1))));
                                //result.AppendLine();
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
                                infixresult.Append(Parser.ConvertToInfix(result.ToString().Substring(0, result.ToString().LastIndexOf("\r\n"))));
                                break;
                            }
                        case "-":
                            {
                                stack.Push("" + (left - right));
                                //result.Append(Parser.ConvertToInfix(GeneateCurrentRPN(stack, split.Skip(i + 1))));
                                //result.AppendLine();
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
                                infixresult.Append(Parser.ConvertToInfix(result.ToString().Substring(0, result.ToString().LastIndexOf("\r\n"))));
                                break;
                            }
                        case "*":
                            {
                                stack.Push("" + (left * right));
                                //result.Append(Parser.ConvertToInfix(GeneateCurrentRPN(stack, split.Skip(i + 1))));
                                //result.AppendLine();
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
                                infixresult.Append(Parser.ConvertToInfix(result.ToString().Substring(0, result.ToString().LastIndexOf("\r\n"))));
                                break;
                            }
                        case "/":
                            {
                                stack.Push("" + (left / right));
                                //result.Append(Parser.ConvertToInfix(GeneateCurrentRPN(stack, split.Skip(i + 1))));
                                //result.AppendLine();
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
                                infixresult.Append(Parser.ConvertToInfix(result.ToString().Substring(0, result.ToString().LastIndexOf("\r\n"))));
                                break;
                            }
                        case "^":
                            {
                                stack.Push("" + (Math.Pow(left, right)));
                                //result.Append(Parser.ConvertToInfix(GeneateCurrentRPN(stack, split.Skip(i + 1))));
                                //result.AppendLine();
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
                                infixresult.Append(Parser.ConvertToInfix(result.ToString().Substring(0, result.ToString().LastIndexOf("\r\n"))));
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
            return infixresult.ToString().TrimEnd();
        }

        private static string GeneateCurrentRPN(Stack<string> evaluatorStack, IEnumerable<string> enumerable)
        {
            StringBuilder currentRPN = new StringBuilder();

            foreach (var current in evaluatorStack)
            {
                currentRPN.Append($"{current} ");
            }

            foreach (var current in enumerable)
            {
                currentRPN.Append($"{current} ");
            }

            return currentRPN.ToString().Trim();
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
