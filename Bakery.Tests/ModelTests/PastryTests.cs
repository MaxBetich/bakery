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
  }
}