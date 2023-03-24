using ConsoleAppProject.App01;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will ask the user to enter ther number of miles (fromUnit) and convert it to feet or
    /// meters (toUnit) and it will also ask the user for the number of feet and convert it into miles.
    /// </summary>
    /// <author>
    /// Martin Konecny Ver. 4.1
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

        public double FromDistance;
        public double ToDistance;

        public string FromUnit;
        public string ToUnit;

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// this method will input the distanced measured from miles to feet
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();
            FromUnit = SelectUnit(" Please select the distance unit you want to convert from > ");
            ToUnit = SelectUnit(" Please select the distance unit you want to convert to > ");

            Console.WriteLine($" Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();

        }

        /// <summary>
        /// Calculations are happening here for all the units. 
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METERS)
            {
                ToDistance = FromDistance / FEET_IN_METERS;
            }
            else if (FromUnit == METERS && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METERS)
            {
                ToDistance = FromDistance * MILES_IN_METRES;
            }
            else if (FromUnit == METERS && ToUnit == FEET)
            {
                ToDistance = FromDistance * METERS_IN_FEET;
            }

        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have selected {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            DistanceUnits unit;

            switch (choice)
            {
                case "1": unit = DistanceUnits.Feet; break;
                case "2": unit = DistanceUnits.Metres; break;
                case "3": unit = DistanceUnits.Miles; break;

                default: unit = DistanceUnits.NoUnit; break;
            }

            if (unit == DistanceUnits.NoUnit)
            {
                Console.WriteLine(" \n Wrong selection! Try again!");
                Console.WriteLine(" \n You MUST select number between 1 to 3!");
            }
            Console.WriteLine($"\n You have chosen {unit}");
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
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance} {ToUnit}!\n");
        }

        /// <summary>
        /// This is the heading which greets the user, summarizes the app and shows the author
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n -------------------------------------------------");
            Console.WriteLine("                 Distance Converter                 ");
            Console.WriteLine("                 By Martin Konecny                  ");
            Console.WriteLine(" -------------------------------------------------\n");
        }
    }
}
