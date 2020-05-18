using System;
namespace SimpleCalculator2
{
    public class CalculatorEngine
    {
        double result;
        public double Calculate(string inputOperator, double num1, double num2)
        {
            switch (inputOperator)
            {
                case "*":
                    result = num1 * num2;
                    return result;
                case "/":
                    result = num1 / num2;
                    return result;
                case "+":
                    result = num1 + num2;
                    return result;
                case "-":
                    result = num1 - num2;
                    return result;
                default:
                    throw new Exception("The operator is not valid");

            }

        }
    }
}
