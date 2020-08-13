using System;
using WageApplication;
using Xunit;

namespace PayrollCalculatorApp.UnitTests
{
    public class OvertimeWagesUnitTests
    {
        [Fact]
        public void GivenIWork41HoursAtARateOf10_ThenIGet415Wages()
        {
            WageCalculator calculator = new WageCalculator();
            decimal wages = calculator.CalculateWages(41, 10);
            Assert.Equal(415, wages);
        }

       [Fact] 
        public void GivenIWork80HoursAtARateOf10_ThenIGet1000Wages()
        {
            WageCalculator calculator = new WageCalculator();
            decimal wages = calculator.CalculateWages(80, 10);
            Assert.Equal(1000, wages);

        }
    }
}