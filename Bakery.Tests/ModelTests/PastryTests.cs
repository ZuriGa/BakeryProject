using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int orderQuantity = 1;
      Pastry newPastry = new Pastry(orderQuantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(orderQuantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetsValueOfQuantity_Void()
    {
      Pastry newPastry = new Pastry(1);
      int newOrderQuantity = 4;
      newPastry.Quantity = newOrderQuantity;
      Assert.AreEqual(newOrderQuantity, newPastry.Quantity);
    }
  }
}