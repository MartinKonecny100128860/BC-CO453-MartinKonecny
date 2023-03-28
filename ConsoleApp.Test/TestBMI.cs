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

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestUnderweightImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.Stones = 5;
            bmi.Pounds = 5;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 9.37;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestNormalRangeMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 72;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 20.37;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestNormalRangeImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.Stones = 11;
            bmi.Pounds = 5;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 19.87;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestOverweightMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 105;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 29.71;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestOverweightImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.Stones = 15;
            bmi.Pounds = 5;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 26.87;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestObeseClassIMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 115;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 32.54;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestImperialObeseClassIBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.Stones = 18;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 31.62;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }


        [TestMethod]
        public void TestObeseClassIIMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 125;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 35.37;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestImperialObeseClassIIBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.Stones = 20;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 35.12;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }


        [TestMethod]
        public void TestObeseClassIIIMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 155;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 43.85;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        [TestMethod]
        public void TestImperialObeseClassIIIBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 3;
            bmi.Stones = 30;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 52.62;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

    }
}
