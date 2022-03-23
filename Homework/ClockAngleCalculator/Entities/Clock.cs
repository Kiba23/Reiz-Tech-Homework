using System;
using ClockAngleCalculator.Interfaces;

namespace ClockAngleCalculator.Entities
{
    public class Clock : IClock
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }

        public Clock(int hours, int minutes)
        {
            if (hours < 0 || hours > 12 || minutes < 0 || minutes > 60)
            {
                throw new ArgumentException("Wrong hours or minutes.");
            }

            MaxValuesCheck(); // Cases when hours = 12 and minutes = 60, we should zero this values then

            Hours = hours;
            Minutes = minutes;
        }

        public int CalculateAngle()
        {
            int hourAngle = (int) (0.5 * (Hours * 60)); // Add "+ Minutes" here if we want to simulate real watches,
                                                        // where hour arrow is moving after it reaches 3:00 (for ex.)
            int minuteAngle = Minutes * 6;

            int diff = Math.Abs(hourAngle - minuteAngle);

            return Math.Min(360 - diff, diff);
        }

        private void MaxValuesCheck()
        {
            if (Hours == 12)
            {
                Hours = 0;
            }
            if (Minutes == 60)
            {
                Minutes = 0;
                Hours += 1;
            }
        }
    }
}
