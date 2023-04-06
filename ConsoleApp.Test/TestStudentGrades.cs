using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private readonly int[] StatsMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };

        private readonly StudentGrades
        studentGrades = new StudentGrades();

        /// <summary>
        /// Tests if 0 marks will output grade F
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //arrange
           Grades expectedGrade = Grades.F;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(0);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 39 marks will output grade F
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            //arrange
            Grades expectedGrade = Grades.F;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(39);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 40 marks will output grade D
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert40ToGradeD()
        {
            //arrange
            Grades expectedGrade = Grades.D;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(40);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 49 marks will output grade D
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            //arrange
            Grades expectedGrade = Grades.D;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(49);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 50 marks will output grade C
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert50ToGradeC()
        {
            //arrange
            Grades expectedGrade = Grades.C;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(50);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 59 marks will output grade C
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert59ToGradeC()
        {
            //arrange
            Grades expectedGrade = Grades.C;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(59);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 69 marks will output grade B
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert69ToGradeB()
        {
            //arrange
            Grades expectedGrade = Grades.B;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(69);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 60 marks will output grade B
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert60ToGradeB()
        {
            //arrange
            Grades expectedGrade = Grades.B;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(60);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        /// <summary>
        /// Tests if 70 marks will output grade A
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert70ToGradeA()
        {
            //arrange
            Grades expectedGrade = Grades.A;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(70);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Tests if 100 marks will output grade A
        /// it uses the assert class to check
        /// the calculation
        /// </summary>
        [TestMethod]
        public void TestConvert100ToGradeA()
        {
            //arrange
            Grades expectedGrade = Grades.A;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(100);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        /// <summary>
        /// Checks if converter correctly calculates the
        /// highest mark among all the students marks.
        /// </summary>
        [TestMethod]
        public void TestCalculateHighestMark()
        {
            converter.MarksOfStudents = StatsMarks;
            int expectedMax = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMax, converter.MaxiMarks);
        }

        /// <summary>
        /// Checks if converter correctly calculates the
        /// lowest mark among all the students marks.
        /// </summary>
        [TestMethod]
        public void TestCalculateLowestMark()
        {
            converter.MarksOfStudents = StatsMarks;
            int expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.MiniMarks);
        }

        /// <summary>
        /// Checks if converter correctly calculates the
        /// average/mean among all the students marks.
        /// </summary>
        [TestMethod]
        public void TestCalculateMeanStat()
        {
            converter.MarksOfStudents = StatsMarks;

            double expectedMean = 55.0;

            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.MeanStudentMarks);
        }

    }
}
