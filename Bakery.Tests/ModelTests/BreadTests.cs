using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1, 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int orderQuantity = 1;
      Bread newBread = new Bread(orderQuantity, 5);
      int result = newBread.Quantity;
      Assert.AreEqual(orderQuantity, result);
      
    }

    [TestMethod]
    public void SetQuantity_SetsValueOfQuantity_Void()
    {
      Bread newBread = new Bread(2, 10);
      int newOrderQuantity = 4;
      newBread.Quantity = newOrderQuantity;
      Assert.AreEqual(newOrderQuantity, newBread.Quantity);
    }

    [TestMethod]
    public void GetCalculateCost_ReturnsCalculateCost_Int()
    {
      int totalCost = 5;
      Bread newBread = new Bread(1, totalCost);
      int result = newBread.CalculateCost;
      Assert.AreEqual(totalCost, result);
    }
  }
}