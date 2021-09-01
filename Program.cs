using System;
using System.Collections.Generic;
using TrangleTracker.Models;


namespace TrangleTracker
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
      Trangle testTrangle = new Trangle(InputSide1,InputSide2,InputSide3);
      Console.WriteLine(testTrangle.Output());
    }
  }   
}