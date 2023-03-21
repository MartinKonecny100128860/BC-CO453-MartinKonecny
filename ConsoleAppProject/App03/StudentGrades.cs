using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

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
        public int[] Minimm { get; set; }
        public int[] Maximum { get; set; }

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
        ///Convert a student mark to a grade 
        ///from F fail to A first class
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }
        /// <summary>
        /// Calculate and display the minimum, maximum
        /// and mean mark for each student
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// This method calculates the grade profile
        /// </summary>
        public void CalculateGradeProfile() 
        { 
            throw new NotImplementedException(); 
        }
    }

}
