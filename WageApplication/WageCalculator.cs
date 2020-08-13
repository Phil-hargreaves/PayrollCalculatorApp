using System;

namespace WageApplication
{
    public class WageCalculator
    {
        //Constants
        private const int NormalHours = 40;
        private const decimal OverTime = 1.5m;
        private const int MaxHours = 80;
        public const int MaxHourRate = 500;
        public const decimal NegativeHours = -1;
        public const int NegativeRate = -2;

        public decimal CalculateWages(int Hours, int HourlyRate)
        {
            if (Hours > MaxHours)
            {
                throw new System.ArgumentException("MaxHours. Hours: " + Hours);
            }

            if (HourlyRate > MaxHourRate)
            {
                throw new System.ArgumentException("MaxHourRate. HourlyRate: " + HourlyRate);
            }

            if (Hours < 0)
            {
                return NegativeHours;
            }

            if (HourlyRate < 0)
            {
                return NegativeRate;
            }

            decimal Wages = 0;

            if (Hours > NormalHours)
            {
                int OtHours = Hours - NormalHours;
                decimal OtWages = OtHours * HourlyRate * OverTime;
                Wages = OtWages + NormalHours * HourlyRate;

            }
            else
            {
                Wages = Hours * HourlyRate;
            }

            return Wages;
        }
    }
}