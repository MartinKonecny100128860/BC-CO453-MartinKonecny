using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using ConsoleAppProject.App02;
using ConsoleAppProject.App01;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This is the main student grades class where student marks 
    /// can be entered, displayed calculated/converted to grade,
    /// statiscts are calculated here as well as the students grade
    /// profile.
    /// </summary>
    public class StudentGrades
    {

        // constants which ae the grade boundaries

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //properties

        public string[] Students { get; set; }
        public int[] MarksOfStudents { get; set; }
        public int[] GradeProfile { get; set; }
        public double MeanStudentMarks { get; private set; }
        public int MaxiMarks { get; private set; }
        public int MiniMarks { get; private set; }

        public int[] Marks { get; set; }

        //Associations in the class diagram
        public Grades Grades
        { get => default; set { } }

        // attrributes

        /// <summary>
        /// Constructor
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Jonathan", "Joseph", "Jotaro",
                "Josuke", "Giorno", "Jolyne",
                "Polnareff", "Rohan", "Tobi",
                "Ash"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            MarksOfStudents = new int[Students.Length];

        }

        /// <summary>
        /// Displays meain menu of this program, it displays
        /// 6 different options the user can select from.
        /// </summary>
        public void OutputMenu()
        {
            bool exit = false;
            do
            {
                // console helper for the heading
                ConsoleHelper.OutputHeading(" App03: Student Marks ");
                //changes the colour of the text for readability
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine(" \n Enter a number to select an option \n");
                Console.WriteLine(" 1. Input Marks For Each Student");
                Console.WriteLine(" 2. Output Grades For All Students");
                Console.WriteLine(" 3. Output Statistics / Mean Marks");
                Console.WriteLine(" 4. Output Grade Profile");
                Console.WriteLine(" 5. Output Marks");
                Console.WriteLine(" 6. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        InputMarks();
                        break;
                    case "2":
                        OutputGrades();
                        break;
                    case "3":
                        OutputStats();
                        break;
                    case "4":
                        OutputGradeProfile();
                        break;
                    case "5":
                        OutputMarks();
                        break;
                    case "6":
                        Program.Main();
                        break;
                    default:
                        Console.WriteLine(" This input is inavlid! Please try again.");
                        break;

                }
            } while (!exit);
        }

        /// <summary>
        /// Returns an array of grades for each student based on the marks they achieved.
        /// </summary>
        public char[] Grade
        {
            get
            {
                if (Marks == null)
                {
                    return null;
                }

                char[] grades = new char[Marks.Length];

                for (int Index = 0; Index < Marks.Length; Index++)
                {
                    grades[Index] = StudentGrade(Marks[Index]);
                }

                return grades;
            }
        }

        /// <summary>
        /// This methods takes the user inputs and returns their
        /// corresponding grade as a character
        /// </summary>
        private char StudentGrade(int mark)
        {
            if (mark >= 80)
            {
                return 'A';
            }
            else if (mark >= 70)
            {
                return 'B';
            }
            else if (mark >= 60)
            {
                return 'C';
            }
            else if (mark >= 50)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }


        /// <summary>
        /// This method prompts the user to input marks between 0-100 for each student in
        /// the Students array. if the user inputs a number higher than 100 an error message 
        /// will appear. The marks are then stored in the MarksOfStudents array.
        /// </summary>
        public void InputMarks()
        {
            for (int index = 0; index < Students.Length; index++)
            {
                Console.Write($"\n Enter Marks For {Students[index]} > ");
                int mark = int.Parse(Console.ReadLine());

                if (mark < LowestMark || mark > HighestMark)
                {
                    ConsoleHelper.InputNumber($" This mark is invalid! Please enter a mark between {LowestMark} and {HighestMark}.");
                    index--;
                }
                else
                {
                    MarksOfStudents[index] = mark;
                }
            }
        }
        /// <summary>
        /// This method lists all of the student's names and the
        /// mark they have achieved out of 100
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading(" Marks of Every Student");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            for (int index = 0; index < Students.Length; index++)
            {
                Console.WriteLine($"{Students[index]}'s Grade is > {MarksOfStudents[index]}/100");
            }
        }

        /// <summary>
        /// This method lists all of the student's names and the
        /// Grade they have achieved A,B,C,D or F
        /// </summary>
        public void OutputGrades()
        {
            ConsoleHelper.OutputHeading("Grades For Each Student");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            for (int index = 0; index < Students.Length; index++)
            {
                Grades grade = ConvertToGrade(MarksOfStudents[index]);
                Console.WriteLine($"\n {Students[index]}: Has Achieved Grade {grade} > ({MarksOfStudents[index]} Out of 100)");
            }
        }

        /// <summary>
        /// This method outputs the statistics for all the students 
        /// (Mean. Highest Mark and Lowest Mark)
        /// </summary>
        public void OutputStats()
        {
            //This is where the calculations for the statistics happen
            CalculateStats();

            ConsoleHelper.OutputHeading("Student Marks Statistics");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"\n Mean Mark: {MeanStudentMarks:F2}");
            Console.WriteLine($"\n Highest Mark is: {MaxiMarks}/100");
            Console.WriteLine($"\n Lowest Mark is: {MiniMarks}/100");

        }

        /// <summary>
        /// This method takes the students mark which was inputed 
        /// and returns it as a grade (A, B, C, D or F)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }
        }
        /// <summary>
        /// This method calculates the mean, lowest mark and highest mark
        /// </summary>

        public void CalculateStats()
        {
            double total = 0.0;
            MiniMarks = HighestMark;
            MaxiMarks = LowestMark;

            foreach (int mark in MarksOfStudents)
            {
                total += mark;
                if (mark > MaxiMarks) MaxiMarks = mark;
                if (mark < MiniMarks) MiniMarks = mark;
            }

            MeanStudentMarks = total / MarksOfStudents.Length;
        }

        /// <summary>
        /// This method calculates the amount of students in 
        /// every grade category and stores the number in
        /// GradeProfile Array
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int index = 0; index < GradeProfile.Length; index++)
            {
                GradeProfile[index] = 0;
            }
            foreach (int mark in MarksOfStudents)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /// <summary>
        /// This method outputs the grade profile which lists
        /// the percentage of students in each grade category.
        /// It also calls the CalculateGradeProfile() method
        /// so it can calculate the counts for every category
        /// within this method. 
        /// </summary>
        public void OutputGradeProfile()
        {
            CalculateGradeProfile();
            ConsoleHelper.OutputHeading("Students Grade Profile");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Grades grade = Grades.F;

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / MarksOfStudents.Length;
                Console.WriteLine($" Grade {grade} Profile\n Percentage: {percentage}% | No. of Students: {count}");
                grade++;
            }
            OutputMenu();
        }


    }

}
