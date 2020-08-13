using System;
using WageApplication;
using Xunit;


namespace PayrollCalculatorApp.UnitTests
{
    public class RateCalculations
    {
        [Fact]
        public void Given10HoursAtMaxRate_ThenReturnsValue()
        {
            WageCalculator calculator = new WageCalculator();
            decimal Wages = calculator.CalculateWages(10, WageCalculator.MaxHourRate);
            Assert.Equal(5000, Wages);
        }

        [Fact]
        public void Given10HoursAt1Rate_ThenReturns10()
        {
            WageCalculator calculator = new WageCalculator();
            decimal Wages = calculator.CalculateWages(10, 1);
            Assert.Equal(10, Wages);
        }
    }

}

