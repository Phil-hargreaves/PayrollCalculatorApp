
using WageApplication;
using Xunit;

namespace PayrollCalculatorApp.UnitTests
{
    public class WageReviewTests
    {
        [Fact]
        public void GivenIWork81HoursAtARateOf10_ThenAnExceptionIsRaised()
        {
            WageCalculator calculator = new WageCalculator();

            System.ArgumentException argumentException = Assert.Throws<System.ArgumentException>(() => calculator.CalculateWages(81, 10));

        }

        [Fact]
        public void GivenIWork10HoursAtARateOf501_ThenAnExceptionIsRaised()
        {
            WageCalculator calculator = new WageCalculator();

            System.ArgumentException argumentException = Assert.Throws<System.ArgumentException>(() => calculator.CalculateWages(10, 501));

        }
    }
}