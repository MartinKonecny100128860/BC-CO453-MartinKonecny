using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace ConsoleApp.Test
{
    [TestClass]
    public class BMICalculatorTests
    {
        [TestMethod]
        public void TestUnderweightMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.8;
            bmi.Kilograms = 50;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 15.43;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestUnderweightImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Inches = 70;
            bmi.Pounds = 110;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 15.78;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

    }
}
