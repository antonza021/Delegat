using System;

namespace Delegat
{
    class Program
    {
        static void Main(string[] args)
        {
            MathExpressions expressions = new MathExpressions();

            double result1 = expressions.CalculateMathExpression(2.5);
            double result2 = expressions.CalculateMathExpression(-10);
            double result3 = expressions.CalculateMathExpression(0);

            Console.WriteLine($"Результат1: {result1}");
            Console.WriteLine($"Результат2: {result2}");
            Console.WriteLine($"Результат3: {result3}");

            Console.ReadKey();
        }
    }
}
