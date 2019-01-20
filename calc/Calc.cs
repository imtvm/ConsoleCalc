using System;

namespace calc
{
    class Calc
    {
        static void Main(string[] args)
        {
            string oper = args[0];
            double result = 0;

            switch (oper) {
                case "+":
                    for (int i = 1; i < args.Length; i++ ) {
                        result += int.Parse(args[i]);
                    }
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = int.Parse(args[1]);
                    for (int i = 2; i < args.Length; i++)
                    {
                        result -= int.Parse(args[i]);
                    }
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = int.Parse(args[1]);
                    for (int i = 2; i < args.Length; i++)
                    {
                        result += int.Parse(args[i]);
                    }
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = int.Parse(args[1]);
                    for (int i = 2; i < args.Length; i++)
                    {
                        result *= int.Parse(args[i]);
                    }
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine(oper);
                    break;
            }
        }
    }
}
