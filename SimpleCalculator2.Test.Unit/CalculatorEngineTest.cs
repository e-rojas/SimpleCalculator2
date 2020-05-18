using NUnit.Framework;

namespace SimpleCalculator2.Test.Unit
{
    public class CalculatorEngineTest

    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        [Test]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("+", num1, num2);
            Assert.AreEqual(3, result);
        }
    }
}