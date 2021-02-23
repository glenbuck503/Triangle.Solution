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
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.TriangleType(5, 3, 4));
    }


  }
}