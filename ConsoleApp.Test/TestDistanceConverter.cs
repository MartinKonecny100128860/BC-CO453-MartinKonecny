using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestDistanceConverter
    {
        /// <summary>
        /// tests if 1 feet is correctly calculated to miles
        /// </summary>
        [TestMethod]
        public void TestFeetToMiles()
        {
            // Arrange 
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 5280;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);


        }

        /// <summary>
        /// tests if 1 feet is correctly calculated to meters
        /// </summary>
        [TestMethod]
        public void TestFeetToMeters()
        {
            // Arrange 
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METERS;

            converter.FromDistance = 3.28084;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);


        }

        /// <summary>
        /// tests if 1 mile is correctly calculated to feet
        /// </summary>
        [TestMethod]
        public void TestMilesToFeet()
        {
            // Arrange 
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 5280;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);


        }

        /// <summary>
        /// tests if 1 mile is correctly calculated to meters
        /// </summary>
        [TestMethod]
        public void TestMilesToMeters()
        {
            // Arrange 
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METERS;

            converter.FromDistance = 1.0;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);


        }

        /// <summary>
        /// tests if 1 meter is correctly calculated to feet
        /// </summary>
        [TestMethod]
        public void TestMetersToFeet()
        {
            // Arrange 
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METERS;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 3.28084;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);


        }

        /// <summary>
        /// tests if 1 meter is correctly calculated to miles
        /// </summary>
        [TestMethod]
        public void TestMetersToMiles()
        {
            // Arrange 
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METERS;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 1609.34;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            //Assert
            Assert.AreEqual(expectedDistance, converter.ToDistance);


        }
    }

}
