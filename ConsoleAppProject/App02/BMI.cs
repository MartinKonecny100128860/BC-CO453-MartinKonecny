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
        }


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

        private void InputImperialDetails()
        {
            Console.WriteLine("Enter your height to the nearest feet and inches");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

            Console.WriteLine();
            Console.WriteLine("Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
        }

        private void InputMetricDetails()
        {
            Centimetres = (int)ConsoleHelper.InputNumber(" \n Enter your height in centimetres > ");

            metres = (double)Centimetres / 100;

            Kilograms = ConsoleHelper.InputNumber(" Enter your weight in kilograms > ");
        }

        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            Console.WriteLine($"Index = {Index}");

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
            else if (Index >= ObeseLevel3)
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

            return message.ToString();
        }

    }
}