using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChecker.Models;

namespace TriangleChecker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void isTriangle_ThreeSidesDontMakeTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.isTriangle(2, 1, 4));
    }
  }
}