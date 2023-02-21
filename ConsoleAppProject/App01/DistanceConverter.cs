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

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// this method will input the distanced measured in miles
        /// </summary>

        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();

        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();

        }

        public void MilesToMeters()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();

        }

        /// <summary>
        /// Ask the user to enter the amount of miles they want to calculate
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles you want to convert ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet you want to convert ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }

        private void InputMeters()
        {
            Console.Write("Please enter the number of meters you want to convert ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }
        /// <summary>
        /// Converts feet to miles (multiply)
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Converts miles to feet (divide)
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Converts miles to feet (divide)
        /// </summary>
        private void CalculateMeters()
        {
            metres = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// Outputs feet to miles
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }

        /// <summary>
        /// Outputs miles to feet
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");
        }

        /// <summary>
        /// Outputs miles to meters
        /// </summary>
        private void OutputMeters()
        {
            Console.WriteLine(miles + " miles is " + metres + " meters! ");
        }

        /// <summary>
        /// This is the heading which greets the user, summarizes the app and shows the author
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("       Convert Miles to Feet         ");
            Console.WriteLine("            By Martin Konecny        ");
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
