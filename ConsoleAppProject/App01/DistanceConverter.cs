using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will ask the user to enter ther number of miles (fromUnit) and convert it to feet or
    /// meters (toUnit) and it will also ask the user for the number of feet and convert it into miles.
    /// </summary>
    /// <author>
    /// Martin Konecny Ver. 3.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METERS = 3.28084;

        public const double METERS_IN_FEET = 3.28084;

        public const double MILES_IN_METRES = 1609.34;

        public const string FEET = "Feet";
        public const string METERS = "Meters";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// this method will input the distanced measured from miles to feet
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();
            fromUnit = SelectUnit(" Please select from the distance unit > ");
            toUnit = SelectUnit(" Please select from the distance unit > ");

            Console.WriteLine($" Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();

        }

        /// <summary>
        /// Calculations are happening here for all the units. 
        /// </summary>
        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * MILES_IN_METRES;
            }
            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * METERS_IN_FEET;
            }

        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit =  ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METERS;
            }
            else if (choice.Equals("3"))
            {
                return MILES;

            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METERS}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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
        /// Outputs feet to miles use of interpolation (dollar sign)
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!\n");
        }

        /// <summary>
        /// This is the heading which greets the user, summarizes the app and shows the author
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("                 Distance Converter                 ");
            Console.WriteLine("                 By Martin Konecny                  ");
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
