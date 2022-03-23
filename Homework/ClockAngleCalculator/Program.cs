using ClockAngleCalculator.Entities;
using ClockAngleCalculator.Interfaces;
using System;

namespace ClockAngleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console
            Console.WriteLine("Welcome to the Clock Angle Calculator!\n");

            Console.Write("Please enter hours (12-hours format): ");
            var hrs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter minutes: ");
            var min = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Objects
            IClock clock = new Clock(hrs, min);
            #endregion

            #region Output
            Console.WriteLine($"The least angle in degrees between hours arrow and minutes arrow is {clock.CalculateAngle()}." + "\n");
            #endregion
        }
    }
}
