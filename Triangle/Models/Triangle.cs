using System;

namespace TriangleChecker.Models
{
  public class Triangle
  {
    public string triangleType()
    {
      return "";
    }

    public bool isTriangle(int side1, int side2, int side3)
    {
      if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
      {
        return false;
      }
      return true;
    }


  }
}