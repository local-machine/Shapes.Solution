using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes.Models;


namespace Shapes.Test
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleConstructor_CreatesInstancesOfCircle_Circle()
        {
            Circle myCircle = new Circle(5);
            Assert.AreEqual(typeof(Circle), myCircle.GetType());
        }

        [TestMethod]
        public void CircleDiameter_CalculatesDiameterOfCircle_Circle()
        {
            // Arrange
            Circle myCircle = new Circle(5);
            // Act
            double result = myCircle.GetDiameter();
            // Assert
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void CircleCircumference_CalculatesCircumferenceOfCircle_Circle()
        {
          // Arrange
          Circle myCircle = new Circle(5);                  
          // Act
          double result = myCircle.GetCircumference();
          // Assert
          Assert.AreEqual(31.416, result);                              
        }
    }
}