using System;
using WageApplication;
using Xunit;


namespace PayrollCalculatorApp.UnitTests
{
    public class NegativeInput
    {

        [Fact]
        public void GivenNegative1HoursAtARateOf10_ThenReturnsNegativeHours()
        {
            WageCalculator calculator = new WageCalculator();
            decimal actualWages = calculator.CalculateWages(-1, 10);
            Assert.Equal(WageCalculator.NegativeHours, actualWages);
        }

        [Fact]
        public void Given1HoursAtANegative1Rate_ThenReturnsNegativeRate()
        {
            WageCalculator calculator = new WageCalculator();
            decimal actualWages = calculator.CalculateWages(1, -2);
            Assert.Equal(WageCalculator.NegativeRate, actualWages);
        }
    }
}

