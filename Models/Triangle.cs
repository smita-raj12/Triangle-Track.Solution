using System;

namespace  TriangleTracker.Models
{
    public class Triangle
    {
      public int Side1 {get; set;}
      public int Side2 {get; set;}
      public int Side3 {get; set;} 
    
    public Triangle(int side1, int side2, int side3) 
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public bool IsNotTriangle()
    {
      return (
          (Side1 > (Side2 + Side3)) || 
          (Side2 > (Side1 + Side3)) || 
          (Side3 > (Side1 + Side2))
      );
    }

    public bool IsEquilateral()
    {
      return(Side1==Side2 && Side2==Side3);
      
    }

    public bool Isosceles()
    {
      return (Side1==Side2 || Side2==Side3 || Side1==Side3);
    }
    
    public bool Scalene()
    {
      return (Side1!=Side2 && Side2!=Side3 && Side3!=Side1);
    }

    public string Output()
    {
      if (IsNotTriangle())
      {
        return "This is not a Triangle";
      }
      else if (IsEquilateral())
      {
        return "It's a Equilateral";
      }
      else if( Isosceles())
      {
        return "It's a Isosceles";
      }
      else if(Scalene())
      {
        return "This is a Scalene Triangle";
      }
      else
      {
        return null;
      }
    }
  }
}