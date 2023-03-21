using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestStudentGrades
    {
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
    }
}
