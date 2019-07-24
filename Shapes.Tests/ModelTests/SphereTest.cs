using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes.Models;


namespace Shapes.Test
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void SphereConstructor_CreatesInstancesOfSphere_Sphere()
        {
            Sphere mySphere = new Sphere(5);
            Assert.AreEqual(typeof(Sphere), mySphere.GetType());
        }

        [TestMethod]
        public void SphereSurface_CalculatesSurfaceAreaOfSphere_Sphere()
        {   
            // Arrange
            Sphere mySphere = new Sphere(5);
            // Act
            double result = mySphere.GetSurface();
            // Assert
            Assert.AreEqual(result, 314.159);
        }

        [TestMethod]
        public void SphereVolume_CalculatesVolumeOfSphere_Sphere()
        {
          // Arrange
          Sphere mySphere = new Sphere(5);
          // Act
          double result = mySphere.GetVolume();
          // Assert
          Assert.AreEqual(result, 523.599);
        }
    }
}