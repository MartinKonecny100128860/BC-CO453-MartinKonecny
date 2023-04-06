using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace ConsoleApp.Test
{
    [TestClass]
    public class BMICalculatorTests
    {
        /// <summary>
        /// Tets method which chekcs if the calculations for bmi are correct. 
        /// it checks metric unit for lowest underweight bmi 
        /// </summary>
        [TestMethod]
        public void TestUnderweightLowMetricBMI()
        {
            // Arrange2
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 45;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 12.73;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which chekcs if the calculations for bmi are correct. 
        /// it checks metric unit for highest underweight bmi 
        /// </summary>
        [TestMethod]
        public void TestUnderweightHighMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 63.6;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 17.99;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which chekcs if the calculations for bmi are correct. 
        /// it checks imperial unit for lowest underweight bmi 
        /// </summary>
        [TestMethod]
        public void TestUnderweightLowImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 9;
            bmi.Pounds = 10;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 17.46;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which chekcs if the calculations for bmi are correct. 
        /// it checks imperial unit for highest underweight bmi 
        /// </summary>
        [TestMethod]
        public void TesthUnderweightHighImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 10;
            bmi.Pounds = 0;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 17.97;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for lowest normal range bmi 
        /// </summary>
        [TestMethod]
        public void TestNormalRangeLowMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 70.4;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 19.92;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for highest normal range bmi 
        /// </summary>
        [TestMethod]
        public void TestNormalRangeHighMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 95.3;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 26.96;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for lowest normal range bmi 
        /// </summary>
        [TestMethod]
        public void TestNormalRangeLowImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 10;
            bmi.Pounds = 4;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 18.49;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for highest normal range bmi 
        /// </summary>
        [TestMethod]
        public void TestNormalRangeHighImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 13;
            bmi.Pounds = 12;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 24.91;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for lowest overweight bmi 
        /// </summary>
        [TestMethod]
        public void TestOverweightLowMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 97.8;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 27.67;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for highest overweight bmi 
        /// </summary>
        [TestMethod]
        public void TestOverweightHighMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 115.9;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 32.79;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for lowest overweight bmi 
        /// </summary>
        [TestMethod]
        public void TestOverweightLowImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 13;
            bmi.Pounds = 12;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 24.91;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for highest overweight bmi 
        /// </summary>
        [TestMethod]
        public void TestOverweighthHighImperialBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 16;
            bmi.Pounds = 3;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 29.14;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for lowest obese 1 bmi 
        /// </summary>
        [TestMethod]
        public void TestObeseClassILowMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 118.5;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 33.53;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for highest obese 1 bmi 
        /// </summary>
        [TestMethod]
        public void TestObeseClassIMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 118.5;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 33.53;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for lowest obese 1 bmi 
        /// </summary>
        [TestMethod]
        public void TestImperialObeseClassILowBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 16;
            bmi.Pounds = 3;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 29.14;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for high obese 1 bmi 
        /// </summary>
        [TestMethod]
        public void TestImperialObeseClassIHighBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 19;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 34.28;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for lowest obese 2 bmi 
        /// </summary>
        [TestMethod]
        public void TestObeseClassIILowMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 141.2;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 39.95;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for highest obese 2 bmi 
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIHighMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 160.9;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 45.52;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for lowest obese 2 bmi 
        /// </summary>
        [TestMethod]
        public void TestImperialObeseClassIILowBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 19;
            bmi.Pounds = 2;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 34.41;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for highest obese 2 bmi 
        /// </summary>
        [TestMethod]
        public void TestImperialObeseClassIIHighBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 22;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 39.67;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for lowest obese 3 bmi 
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIILowMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 163.6;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 46.29;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks metric unit for highest obese 3 bmi 
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIIHighMetricBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.metres = 1.88;
            bmi.Kilograms = 175.5;

            // Act
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 49.65;

            //Assert
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.Index, 2));
        }

        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for lowest obese 3 bmi 
        /// </summary>
        [TestMethod]
        public void TestImperialObeseClassIIILowBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 22;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 39.67;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }
        /// <summary>
        /// Tets method which checks if the calculations for bmi are correct. 
        /// it checks imperial unit for highest obese 3 bmi 
        /// </summary>
        [TestMethod]
        public void TestImperialObeseClassIIIHighBMI()
        {
            // Arrange
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inches = 2;
            bmi.Stones = 30;
            bmi.Pounds = 1;

            // Act
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 54.05;

            // Assert
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.Index, 2));
        }

    }
}
