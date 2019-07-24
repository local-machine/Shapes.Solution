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
           int result = myCircle.GetDiameter();
           // Assert
           Assert.AreEqual(result, 10);
       }

    //    [TestMethod]

    }
}