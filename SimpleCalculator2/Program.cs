using System;

namespace SimpleCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculator = new CalculatorEngine();
                Console.WriteLine("Enter a number: ");
                double firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
                Console.WriteLine("Enter a number: ");
                double secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
                Console.WriteLine("Enter the operator: * + - /");
                string operation = Console.ReadLine();
                double result = calculator.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine("{0} {1} {2} = {3} ", firstNumber, operation, secondNumber, result);


            }
            catch (Exception ex)
            {

                //throw new Exception("new error", ex);
                Console.WriteLine(ex.Message);

            }
        }
    }
}
