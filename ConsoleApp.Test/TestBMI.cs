using ConsoleAppProject.App01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public class TestBMI
    {
        [TestMethod]
        public void TestInchesToFeet()
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
    }
}
