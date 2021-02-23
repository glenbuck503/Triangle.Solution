using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChecker.Models;

namespace TriangleChecker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_ThreeSidesDontMakeTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(2, 1, 4));
    }

    [TestMethod]
    public void TriangleType_Scalene_True()
    {
      Assert.AreEqual("Scalene", new Triangle().TriangleType(5, 3, 4));
    }

    [TestMethod]
    public void TriangleType_Equilateral_True()
    {
     
      Assert.AreEqual("Equilateral", new Triangle().TriangleType(777,777,777));
    }

    [TestMethod]
    public void TriangleType_Isosceles_True()
    {
      Assert.AreEqual("Isosceles", new Triangle().TriangleType(2,3,3));
    }
  }
}