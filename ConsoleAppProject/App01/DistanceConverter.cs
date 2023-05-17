using ConsoleAppProject.App01;
using ConsoleAppProject.Helpers;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will ask the user to enter ther number of miles (fromUnit) and convert it to feet or
    /// meters (toUnit) and it will also ask the user for the number of feet and convert it into miles.
 
    /// </summary>
    /// 
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
        /// <summary>
        /// A constructor of the DistanceConverter class, it sets the default
        /// conversion to miles and feet.
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
            FromUnit = MILES;
            ToUnit = METERS;
            FromUnit = FEET;
            ToUnit = MILES;
            FromUnit = FEET;
            ToUnit = METERS;
            FromUnit = METERS;
            ToUnit = FEET;
            FromUnit = METERS;
            ToUnit = MILES;
        }

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// this method will input the distanced measured from miles to feet. It is the main
        /// methid for this application
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

            OutputMenu();

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
        /// <summary>
        /// This method will prompt the user to pick a distance unit to convert 
        /// from or convert to, It calls the DisplayChoices method to display the
        /// available choices.
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice;
            bool ErrorMessageChoice;

            do
            {
                choice = DisplayChoices(prompt);
                ErrorMessageChoice = this.ErrorMessageChoice(choice);
            }
            while (!ErrorMessageChoice);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have selected {unit}");
            return unit;
        }
        /// <summary>
        /// This method is being called by the SelectUnit method
        /// it will convert users input to a unit string
        /// </summary>
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
        /// <summary>
        /// this method will display the available choices for the distance units
        /// It also prompts the user to pick one of the options
        /// </summary>
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
        /// DDisplays an error message if the user enters a letter instead of a number.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double distance;
            while (!double.TryParse(value, out distance) || value.Any(c => !char.IsLetterOrDigit(c)))
            {
                Console.WriteLine(" This input is inavlid! Please try again.");
                Console.Write(prompt);
                value = Console.ReadLine();
            }
            return distance;
        }

        /// <summary>
        /// Outputs feet to miles use of interpolation (dollar sign)
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance} {ToUnit}!\n");
        }
        public void OutputMenu()
        {
            bool exit = false;
            do
            {
                // console helper for the heading
                ConsoleHelper.OutputHeading(" App01: Distance Converter ");
                //changes the colour of the text for readability
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" 1. Convert Again");
                Console.WriteLine(" 2. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ConvertDistance();
                        break;
                    case "2":
                        Program.Main();
                        break;
                    default:
                        Console.WriteLine(" This input is inavlid! Please try again.");
                        break;

                }
            } while (!exit);
        }
        /// <summary>
        /// This method will check if the users choice is valid, if it isnt
        /// an error message will be displayed and will return false
        /// </summary>
        private bool ErrorMessageChoice(string choice)
        {
            if (choice == "1" || choice == "2" || choice == "3")
            {
                return true;
            }
            else
            {
                Console.WriteLine(" This choice is NOT valid! Please select options 1, 2, or 3.");
                return false;
            }
        }

        /// <summary>
        /// This is the heading which greets the user, summarizes the app and shows the author
        /// </summary>
        private void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n -------------------------------------------------");
            Console.WriteLine("                 Distance Converter                 ");
            Console.WriteLine("                 By Martin Konecny                  ");
            Console.WriteLine(" -------------------------------------------------\n");
        }

    }

}
