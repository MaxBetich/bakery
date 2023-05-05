using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryProject.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void SetCount_SetsValueOfCount_Void()
    {
      Pastry newPastry = new Pastry();
      int newCount = 5;
      newPastry.Count = newCount;
      Assert.AreEqual(newCount, newPastry.Count);
    }

    [TestMethod]
    public void GetCount_ReturnsCount_Int()
    {
      int count = 3;
      Pastry newPastry = new Pastry();
      newPastry.Count = 3;
      int result = newPastry.Count;
      Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfThreeItems_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.Count = 3;
      int price = newPastry.GetPrice();
      Assert.AreEqual(6, price);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfFourItems_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.Count = 4;
      int price = newPastry.GetPrice();
      Assert.AreEqual(6, price);
    }
  }
}