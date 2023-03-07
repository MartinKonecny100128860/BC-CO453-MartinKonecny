using ConsoleAppProject.Helpers;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        publi

        public class UnitSystems
        {
        }
        public const string INCHES = "Inches";

        private double height;
        private double weight;

        private string unitChoice;

        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            ConvertBMI();
        }

        public void ConvertBMI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Selecting units");
            string[] choices = new string[]
            {
            IMPERIAL, METRIC
            };

            Console.WriteLine($"\n Please select a unit to convert from\n");
            int choice = ConsoleHelper.SelectChoice(choices);
            unitChoice = choices[choice - 1];
            Console.WriteLine($"\n You have selected {unitChoice}! ");
        }
        public class BMI
        {
            public const int InchesInFeet = 12;
            public const int PundsInStones = 14;

            public double Index { get; set; }

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

            private double metres;

            ///sdefrgth
            ///

            public void CalculateIndex()
            {
                ConsoleHelper.OutputHeading("Body Mass Index Calculator");

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

            }

            public void CalculateMetricBMI()
            {
                Index = Kilograms / (metres * metres);
            }
            public void CalculateMetricBMI()
            {
                Inches += Feet * InchesInFeet;
                Pounds += Stones * PoundsInStones;

                Index = (double)Pounds * 703 / (Inches * Inches);

            }

            private UnitSystems SelectUnits()
            {
                string[] choices = new string[]
                {
                "Metric Units",
                "Imperial Units"
                };

                int choice = ConsoleHelper.SelectChoice(choices);

                if (choice == 1)
                {
                    return UnitSystems.Metric;
                }
                else return UnitSystems.Imperial;
            }

            private void InputImperialDetails()
            {
                Console.WriteLine("Enter your height to the nearest feet and inches");
                Console.WriteLine();

                Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
                Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

                Console.WriteLine();
                Console.WriteLine("Eter your weight to the nearest stones and pounds");
                Console.WriteLine();

                Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
                Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
            }

            private void InputMetricDetails()
            {
                Centimetres = (int)ConsoleHelper.InputNumber(
                    " \n Enter your height in centimetres > ");

                metres = (double)Centimetres / 100;

                Kilograms = ConsoleHelper.InputNumber(
                    " Enter your weight in kilograms > ");
            }

            public string GetHealthMessage()
            {
                StringBuilder message = new StringBuilder("/n");

                if (Index < Underweight)
                {
                    message.Append($" Your BMI is {Index:0.00}, " +
                        $"You are underweight! ");
                }
                else if (Index <= NormalRange)
                {
                    message.Append($" Your BMI is {Index:0.00}, " +
                        $"You are in the normal range! ");
                }
                else if (Index <= Overweight)
                {
                    message.Append($" Your BMI is {Index:0.00}, " +
                        $"You are overweight! ");
                }
                else if (Index <= ObeseLevel1)
                {
                    message.Append($" Your BMI is {Index:0.00}, " +
                        $"You are obese class I! ");
                }
                else if (Index <= ObeseLevel2)
                {
                    message.Append($" Your BMI is {Index:0.00}, " +
                        $"You are obese class II! ");
                }
                else if (Index <= ObeseLevel3)
                {
                    message.Append($" Your BMI is {Index:0.00}, " +
                        $"You are obese class III! ");
                }

                return message.ToString();

            }

            public string GetBameMessage()
            {
                StringBuilder message = new StringBuilder("\n");
                message.Append(" If you are black, Asian, or other minority");
                message.Append(" ethic groups, you have a higher risk");
                message.Append("\n");
                message.Append("\t Adults 23.0 or more are at increased risk");
            }

        }


    }
}
