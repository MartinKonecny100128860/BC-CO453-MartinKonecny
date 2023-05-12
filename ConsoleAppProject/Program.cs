using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App06;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Martin Konecny 03/02/2023
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI BmiCalculator = new BMI();
        private static StudentGrades Grades = new StudentGrades();
        private static NetworkApp Media = new NetworkApp();
        private static RPS RPS = new RPS();

        public static BMI BMI
        {
            get => default;
            set
            {
            }
        }

        public static DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            string[] myChoices = { "Distance Converter", "BMI Calculator",
                                 "Student Marks", "Social Network", "RPS Game",};

            int option = ConsoleHelper.SelectChoice(myChoices);

            if (option == 1)
            {
                converter.ConvertDistance();
            }
            else if (option == 2)
            {
                BmiCalculator.CalculateIndex();
            }
            else if (option == 3)
            {
                Grades.OutputMenu();
            }
            else if (option == 4)
            {
                Media.DisplayChoices();
            }

            else if (option == 5)
            {
                RPS.Main(); 
            }

        }
    }
}
