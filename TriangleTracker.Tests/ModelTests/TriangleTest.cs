using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_ContainsInputValues()
    {
      Triangle testTriangle = new Triangle(2,4,6);
      Assert.AreEqual(2, testTriangle.Side1);
      Assert.AreEqual(4, testTriangle.Side2);
      Assert.AreEqual(6, testTriangle.Side3);
    }
    [TestMethod]
    public void IsNot_Triangle_True(){
        Triangle testTriangle = new Triangle(3,9,22);
        Assert.AreEqual(true, testTriangle.IsNotTriangle());
    }
    [TestMethod]
    public void IsNot_Triangle_False(){
        Triangle testTriangle = new Triangle(3,9,6);
        Assert.AreEqual(false, testTriangle.IsNotTriangle());
    }
    [TestMethod]
    public void Is_IsEquilateral_IfAllSidesAreEqualReturn_True(){
        Triangle testTriangle = new Triangle(10,10,10);
        Assert.AreEqual(true, testTriangle.IsEquilateral());
    }
    [TestMethod]
    public void Is_IsEquilateral_IfAllSidesAreEqualReturn_False(){
      Triangle testTriangle = new Triangle(10,10,9);
      Assert.AreEqual(false, testTriangle.IsEquilateral());
    }
    [TestMethod]
    public void Is_Isosceles_IfTwoSidesEqualReturn_True()
    {
      Triangle testTriangle = new Triangle(4,4,6);
      Assert.AreEqual(true, testTriangle.Isosceles());
    }
    [TestMethod]
    public void Is_Isosceles_IfTwoSidesEqualReturn_False()
    {
      Triangle testTriangle = new Triangle(4,5,6);
      Assert.AreEqual(false, testTriangle.Isosceles());
    }
    [TestMethod]
    public void Is_Scalene_IfNoSidesAreEqualReturn_True()
    {
      Triangle testTriangle = new Triangle(2,4,6);
      Assert.AreEqual(true, testTriangle.Scalene());
    }
    [TestMethod]
    public void Is_Scalene_IfNoSidesAreEqualReturn_False()
    {
      Triangle testTriangle = new Triangle(2,2,2);
      Assert.AreEqual(false, testTriangle.Scalene());
    }
  }
}
