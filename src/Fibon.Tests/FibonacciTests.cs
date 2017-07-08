using Fibon.Service;
using Xunit;

namespace Fibon.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        public void WorksCorrectly(int number, int expectedResult)
        {
            ICalculator calc = new FastOne();
            int result = calc.Fib(number);

            Assert.Equal(expectedResult, result);
        }
    }
}
