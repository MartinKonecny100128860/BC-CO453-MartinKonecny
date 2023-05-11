using ConsoleAppProject.Helpers;
using System;
using System.Drawing;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app calculates the bmi of an user. 
    /// </summary>
    /// <author>
    /// Student Name Martin Konecny
    /// version 6.1
    /// </author>
    public class BMI
    {
        /// <summary>
        /// Constant for how many inches are in feet and
        /// how many pounds are in stones
        /// </summary>
        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        /// <summary>
        /// Constant which defines upper limit values
        /// in the who weights status
        /// </summary>
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;
        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public double Index { get; set; }

        /// <summary>
        /// Imperial and metric variables
        /// </summary>
        public double Kilograms { get; set; }
        public int Centimetres { get; set; }

        public int Stones { get; set; }
        public int Pounds { get; set; }

        public int Feet { get; set; }
        public int Inches { get; set; }

        public UnitSystems UnitSystems
        {
            get => default;
        }

        public double metres;

        /// <summary>
        /// it displays the heading using the console helper class
        /// it prompts the user to select their prefered unit
        /// once the user selects this method will call either 
        /// InputMetricDetails() method or the InputImperialDetails() method
        /// which then prompts the user to input their weight and height. 
        /// </summary>
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading(" Body Mass Index Calculator");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            UnitSystems unitSystem = SelectUnits();

            if (unitSystem == UnitSystems.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            Console.WriteLine(GetHealthMessage());
            Console.WriteLine(GetBameMessage());

            OutputMenu();
        }

        /// <summary>
        /// Calculate metric BMI
        /// </summary>
        public void CalculateMetricBMI()
        {

            Index = Kilograms / (metres * metres);
        }

        /// <summary>
        /// Calculate imperial BMI
        /// </summary>
        public void CalculateImperialBMI()
        {
            Inches += Feet * InchesInFeet;
            Pounds += Stones * PoundsInStones;

            Index = (double)Pounds * 703 / (Inches * Inches);
        }

        /// <summary>
        /// This method will prompt the user to selected between two different units
        /// imperial and metric. it also returns selected UnitSystem enum
        /// </summary>
        private UnitSystems SelectUnits()
        {
            string[] choices = {UnitSystems.Metric.ToString(),
                                UnitSystems.Imperial.ToString(),};
            
            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                return UnitSystems.Metric;
            }
            else return UnitSystems.Imperial;
        }
        /// <summary>
        /// This method will prompt the user to input their height in feet and inches and 
        /// their weight in stones and pounds
        /// </summary>
        private void InputImperialDetails()
        {
            Console.WriteLine(" Enter your height to the nearest feet and inches");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

            Console.WriteLine();
            Console.WriteLine(" Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
        }
        /// <summary>
        /// This method will prompt the user to input their height in centimetres and 
        /// their weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            Centimetres = (int)ConsoleHelper.InputNumber(" \n Enter your height in centimetres > ");

            metres = (double)Centimetres / 100;

            Kilograms = ConsoleHelper.InputNumber(" Enter your weight in kilograms > ");
        }

        /// <summary>
        /// This method will detrmine the users BMI category which is based on the users
        /// index it also returns a message with the users index and category
        /// </summary>
        /// <returns></returns>
        public string GetHealthMessage()
        {
            // Create a new StringBuilder to build the message
            StringBuilder message = new StringBuilder("\n");

            // Display the user's BMI index
            Console.WriteLine($" Index = {Index}");

            // Determine the user's BMI category based on their index
            if (Index < Underweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                           $" You are underweight! ");
            }
            else if (Index <= NormalRange)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                            $" You are in the normal range! ");
            }
            else if (Index <= Overweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                            $" You are overweight! ");
            }
            else if (Index <= ObeseLevel1)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                            $" You are obese class I! ");
            }
            else if (Index <= ObeseLevel2)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                            $" You are obese class II! ");
            }
            else if (Index >= ObeseLevel3)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                            $" You are obese class III! ");
            }

            return message.ToString();

        }
        /// <summary>
        /// This method returms a message about increased risks for all the  listed groups
        /// of people
        /// </summary>
        public string GetBameMessage()
        {
            StringBuilder message = new StringBuilder("\n");
            ConsoleHelper.OutputTitle("BAME MESSAGE");
            message.Append(" If you are black, Asian, or other minority");
            message.Append(" ethic groups, you have a higher risk");
            message.Append("\n");
            message.Append("\n Adults 23.0 or more are at increased risk!");

            return message.ToString();
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
                        CalculateIndex();
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

        public UnitSystems UnitSystems1
        {
            get => default;
            set
            {
            }
        }
    }
}