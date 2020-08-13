using System;
using WageApplication;
using Xunit;

namespace PayrollCalculatorApp.UnitTests
{
    public class CalculateWagesUnitTests
    {
       
        [Fact]
        public void GivenIWorkZeroHoursAtARateOf10_ThenIGetZeroWages()
        {
            WageCalculator calculator = new WageCalculator();
            decimal wages = calculator.CalculateWages(0, 10);
            Assert.Equal(0, wages);

        }

        [Fact]
        public void GivenIWork1HoursAtARateOf10_ThenIGet10InWages()
        {
            WageCalculator calculator = new WageCalculator();
            decimal wages = calculator.CalculateWages(1, 10);
            Assert.Equal(10, wages);

        }

        [Fact]
        public void GivenIWork40HoursAtARateOf10_ThenIGet400InWages()
        {
            WageCalculator calculator = new WageCalculator();
            decimal wages = calculator.CalculateWages(40, 10);
            Assert.Equal(400, wages);
        }
        //Same scenarios - different way to write the tests
        [Theory]
        [InlineData (0, 10, 0)]
        [InlineData (1, 10, 10)]
        [InlineData (40, 10, 400)]
        public void CheckAllWageCalculations(int Hours, int HourRate, decimal ExpectedWages){

            WageCalculator calculator = new WageCalculator();
            decimal ActualWages = calculator.CalculateWages(Hours, HourRate);
            Assert.Equal(ExpectedWages, ActualWages);
                       
        }
    }
}
