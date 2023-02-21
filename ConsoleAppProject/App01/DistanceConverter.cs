using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will convert miles into feet.
    /// </summary>
    /// <author>
    /// Martin Konecny Ver. 1.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("       Convert Miles to Feet         ");
            Console.WriteLine("            By Martin Konecny        ");
            Console.WriteLine("-------------------------------------\n");
        }

        /// <summary>
        /// Ask the user to enter the amount of miles they want to calculate
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles you want to convert ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }
        /// <summary>
        /// Converts miles to feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet !");
        }
    }
}
