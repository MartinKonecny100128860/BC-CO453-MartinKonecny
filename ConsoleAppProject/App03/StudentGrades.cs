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
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
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
        public int[] StudentsGradeProfile { get; set; }
        public double MeanStudentMarks { get; private set; }
        public int MaxiMarks { get; private set; }
        public int MiniMarks { get; private set; }

        private int[] Marks;

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
                "Jonathan", "Joseph", "Holly",
                "Jotaro", "Jolyne", "Johnny",
                "Polnareff", "Rohan", "Giorno",
                "Brando"
            };

            StudentsGradeProfile = new int[(int)Grades.A + 1];
            MarksOfStudents = new int[Students.Length];
        }

        // display menu of different options
        public void OutputMenu()
        {
            bool exit = false;
            do
            {
                ConsoleHelper.OutputHeading(" Student Marks ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine(" \n Enter a number to select an option: \n ");
                Console.WriteLine(" 1. Input Marks For Each Student > ");
                Console.WriteLine(" 2. Output Grades For All Students > ");
                Console.WriteLine(" 3. Output Mean / Statistics Marks > ");
                Console.WriteLine(" 4. Output Students Grades > ");
                Console.WriteLine(" 5. Outpy Grade Profile");
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
                        OutputMarks();
                        break;
                    case "5":
                        OutputGradeProfile();
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

        //testing 

        //end testing

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
        /// Input a mark between 0-100 for one and every student and store
        /// it in the marks array 
        /// </summary>
        public void InputMarks()
        {
            for (int index = 0; index < Students.Length; index++)
            {
                Console.Write($"\n Enter Marks For {Students[index]}: ");
                int mark = int.Parse(Console.ReadLine());

                if (mark < LowestMark || mark > HighestMark)
                {
                    ConsoleHelper.InputNumber($"This mark is invalid! Please enter a mark between {LowestMark} and {HighestMark}.");
                    index--;
                }
                else
                {
                    MarksOfStudents[index] = mark;
                }
            }
        }
        /// <summary>
        /// Lists each student and displays their names
        /// and current grades / marks
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading("Student marks:\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int index = 0; index < Students.Length; index++)
            {
                Console.WriteLine($"{Students[index]}: {MarksOfStudents[index]}");
            }
        }

        /// <summary>
        /// List all the students and display 
        /// their name and current Grade
        /// </summary>
        /// <summary>
        /// List all the students and display 
        /// their name and current Grade
        /// </summary>
        public void OutputGrades()
        {
            ConsoleHelper.OutputHeading("\n Outputting grades for each student:");
            Console.ForegroundColor = ConsoleColor.Green;

            for (int index = 0; index < Students.Length; index++)
            {
                Grades grade = ConvertToGrade(MarksOfStudents[index]);
                Console.WriteLine($"\n {Students[index]}: has achieved Grade {grade} > ({MarksOfStudents[index]} out of 100)");
            }
        }

        /// <summary>
        /// Output Stats - Mean. Max, Min
        /// </summary>
        public void OutputStats()
        {
            CalculateStats();

            ConsoleHelper.OutputHeading("Stats");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"\n Mean mark: {MeanStudentMarks:F2}");
            Console.WriteLine($"\n Maximum mark: {MaxiMarks}");
            Console.WriteLine($"\n Minimum mark: {MiniMarks}");
        }

        /// <summary>
        /// 
        ///Convert a student mark to a grade 
        ///from F fail to A first class
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
        /// Calculate and display the minimum, maximum
        /// and mean mark for each student
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


        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }

        private void OutputGradeProfile()
        {
            throw new NotImplementedException();
        }


    }

}
