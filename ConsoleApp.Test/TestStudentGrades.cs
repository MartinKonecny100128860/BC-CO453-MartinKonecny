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

        [TestMethod]
        public void TestConvert79ToGradeA()
        {
            //arrange
            Grades expectedGrade = Grades.A;

            //act
            Grades actualGrade = studentGrades.ConvertToGrade(79);

            //assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

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
        //ayo
        [TestMethod]
        public void TestCalculateMax()
        {
            converter.MarksOfStudents = StatsMarks;
            int expectedMax = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMax, converter.MaxiMarks);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            converter.MarksOfStudents = StatsMarks;
            int expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.MiniMarks);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            converter.MarksOfStudents = StatsMarks;

            double expectedMean = 55.0;

            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.MeanStudentMarks);
        }

    }
}
