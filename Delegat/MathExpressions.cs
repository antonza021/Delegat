using System;
using System.Collections.Generic;
using System.Text;

namespace Delegat
{
    class MathExpressions
    {
        private delegate double MathOperation(double value); //определение делегата MathOperation

        private static double Add(double value) { return value + 10; }   //определение статических методов, которые будут использоваться в качестве элементарных операций
        private static double Subtract(double value) { return value - 5; }
        private static double Multiply(double value) { return value * 3; }
        private static double Divide(double value) { return value / 2; }
        private static double Power(double value) { return Math.Pow(value, 2); }

        private static MathOperation[] operations = new MathOperation[]//массив из 10 делегатов на элементарные операции
        {
        Add,
        Subtract,
        Multiply,
        Divide,
        Power,
        Add,
        Subtract,
        Multiply,
        Divide,
        Power
        };

        public double CalculateMathExpression(double value) //метод для последовательного вызова операций из массива указателей на методы
        {
            foreach (var operation in operations)
            {
                value = operation(value);
            }
            return value;
        }
    }
}

