using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will convert miles into feet, feet to miles and miles to meters.
    /// </summary>
    /// <author>
    /// Martin Konecny Ver. 2.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double meters;

        /// <summary>
        /// this method will input the distanced measured from miles to feet
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));

        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));

        }

        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meters");
            miles = InputDistance("Please enter the number of miles > ");
            CalculateMeters();
            OutputDistance(miles, nameof(miles), meters, nameof(meters));

        }

        /// <summary>
        /// Ask the user to enter the amount of miles they want to calculate
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

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
            meters = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// Outputs feet to miles use of interpolation (dollar sign)
        /// </summary>
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <summary>
        /// This is the heading which greets the user, summarizes the app and shows the author
        /// </summary>
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("           Distance Converter        ");
            Console.WriteLine("            By Martin Konecny        ");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
