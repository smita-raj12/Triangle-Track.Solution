using System;
using System.Collections.Generic;
using TriangleTracker.Models;


namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter side 1");
      string StringInputSide1=Console.ReadLine();
      int InputSide1 = int.Parse(StringInputSide1);
      Console.WriteLine("Enter side 2");
      string StringInputSide2=Console.ReadLine();
      int InputSide2 = int.Parse(StringInputSide2);
      Console.WriteLine("Enter side 3");
      string StringInputSide3=Console.ReadLine();
      int InputSide3 = int.Parse(StringInputSide3);
      Triangle testTriangle = new Triangle(InputSide1,InputSide2,InputSide3);
      Console.WriteLine(testTriangle.Output());
    }
  }   
}