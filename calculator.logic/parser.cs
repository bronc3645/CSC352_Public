using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace calculator.logic
{
    public class Parser
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
                    if (isFunction(token))
                    {
                        operatorstack.Push(token);
                    }
                    else if (isOperator(token))
                    {
                        if (operatorstack.Count() != 0)
                        {
                            if (operatorHasequalpres(operatorstack.Peek(), token))
                            {
                                if (TokenIsLeftAssociative(token))
                                {
                                    while (operatorstack.Count() != 0)
                                    {
                                        if (operatorHasequalpres(operatorstack.Peek(), token))
                                        {
                                            output.Enqueue(operatorstack.Pop());
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                                operatorstack.Push(token);

                            }
                            else if (opperatorHasGreaterPres(operatorstack.Peek(), token))
                            {
                                Queue<string> temp = new Queue<string>();
                                int maxque = output.Count();
                                int stackcount = operatorstack.Count();
                                for(int i = 0; i < maxque; i++)
                                {
                                    temp.Enqueue(output.Dequeue());
                                    if (i == maxque-1)
                                    {
                                        for (int u = 0; u < stackcount; u++)
                                        {
                                            if (opperatorHasGreaterPres(operatorstack.Peek(), token))
                                            {
                                                temp.Enqueue(operatorstack.Pop());
                                            }
                                            else
                                            {
                                                break;
                                            }
                                            
                                        }
                                    }
                                }
                                while (temp.Any())
                                {
                                    output.Enqueue(temp.Dequeue());
                                }
                                operatorstack.Push(token);
                            }
                            else
                            {
                                operatorstack.Push(token);
                            }
                        }
                        else
                        {
                            operatorstack.Push(token);
                        }
                    }
                    else if (token.Equals("("))
                    {
                        operatorstack.Push(token);
                    }
                    else if (token.Equals(")"))
                    {
                        try
                        {
                            while (operatorstack.Peek() != "(")
                            {
                                output.Enqueue(operatorstack.Pop());
                            }
                            operatorstack.Pop();
                            if (operatorstack.Count!=0 && isFunction(operatorstack.Peek()))
                            {
                                output.Enqueue(operatorstack.Pop());
                            }
                        }
                        catch (InvalidOperationException ex)
                        {
                            throw new InvalidOperationException("Unbalanced parens!", ex);
                        }

                    }
                }
            }


            while(operatorstack.Count>=1)
            {
                if (operatorstack.Peek() == "(")
                {
                    throw new InvalidOperationException("Unbalance parens!");
                }
                else if (isFunction(operatorstack.Peek()))
                {
                    throw new InvalidOperationException("not enough parens for function!");
                }
                output.Enqueue(operatorstack.Pop());
            }
            
            StringBuilder sb = new StringBuilder();

            foreach (var outputElement in output)
            {
                sb.Append(outputElement);
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd();
        }

        public static string ConvertToInfix(string rpn)
        {
            string[] split = rpn.Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            for(int i = 0; i < split.Length; i++)
            {
                if (isOperator(split[i]))
                {
                    string right = stack.Pop();
                    string left = stack.Pop();
                    string temp = (left + split[i] + right);
                    stack.Push(temp);
                    int j;
                    for (j=i+1; j < split.Length; j++)
                    {
                        if (isOperator(split[j])){
                            if (opperatorHasGreaterPres(split[j], split[i]))
                            {
                                temp = "(" + temp + ")";
                                stack.Pop();
                                stack.Push(temp);
                            }
                            break;
                        }
                    }
                }
                else
                {
                    stack.Push(split[i]);
                }
            }
            return stack.Pop();
        }

        public static bool operatorHasequalpres(string v,string token)
        {
            if (v == token)
            {
                return true;
            }
            else
            {
                if(
                    ((v=="+"||v=="-")&&(token=="+"||token=="-"))
                    || ((v == "*" || v == "/") && (token == "*" || token == "/"))
                    ||(v=="^"&&token=="^"))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool TokenIsLeftAssociative(string token)
        {
            if (token == "^")
            {
                return false;
            }
            return true;
        }

        public static bool opperatorHasGreaterPres(string v, string token)
        {
            if (v == token)
            {
                return false;
            }
            else
            {
                if(
                    ((v == "/" || v == "*") && (token == "+" || token == "-"))
                    || (v == "^"))
                {
                    return true;
                }
            }
            return false;
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

        private static bool isFunction(string token)
        {
            switch (token)
            {
                case "sin":
                case "cos":
                case "tan":
                case "csc":
                case "sec":
                case "cot":
                case "log":
                case "ln":
                case "insin":
                case "incos":
                case "intan":
                case "mod":
                case "sqrt":
                case "fact":
                    return true;
                default:
                    return false;
            }
        }
    }
}
