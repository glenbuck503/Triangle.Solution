using System;
using TriangleChecker.Models;

namespace TriangleChecker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter the length for side one: ");
      string userSide1 = Console.ReadLine();
      int side1 = int.Parse(userSide1);

      Console.WriteLine("Please enter the length for side two: ");
      string userSide2 = Console.ReadLine();
      int side2 = int.Parse(userSide2);

      Console.WriteLine("Please enter the length for side three: ");
      string userSide3 = Console.ReadLine();
      int side3 = int.Parse(userSide3);

      Triangle triangle = new Triangle();
      Console.WriteLine(triangle.isTriangle(side1, side2, side3));
    }
  }

}