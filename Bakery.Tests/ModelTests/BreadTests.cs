using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryProject.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void SetCount_SetsValueOfCount_Void()
    {
      Bread newBread = new Bread();
      int newCount = 5;
      newBread.Count = newCount;
      Assert.AreEqual(newCount, newBread.Count);
    }
  }
}