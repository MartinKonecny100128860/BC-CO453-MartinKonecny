using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        public const int LowestGradeC= 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //properties


        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double[] Mean { get; set; }
        public int[] MinimumMark { get; set; }
        public int[] MaximumMark { get; set; }

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

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        // display menu of different options
        public void OutputMenu()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Input a mark between 0-100 for one and every student and store
        /// it in the marks array 
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Lists each student and displays their names
        /// and current grades / marks
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the students and display 
        /// their name and current Grade
        /// </summary>
        public void OutputGrades()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Output Stats - Mean. Max, Min
        /// </summary>
        public void OutputStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Outputs Grades for each student
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade}  {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }

        /// <summary>
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

        ///public void CalculateStats()
        //{
            //double total = 0;
            //MinMark = HighestMark;
            //MaxMark = LowestMark;

            //foreach (int mark in Marks)
            //{
                //total += mark;
                //if (mark > MaxMark) MaxMark = mark;
                //if (mark < MinMark) MinMark = mark;
            //}

            //Mean = total / Marks.Length;
        //}
        /// </summary>

        /// <summary>
        /// This method calculates the grade profile
        /// </summary>
        public void CalculateGradeProfile() 
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }
    }

}
