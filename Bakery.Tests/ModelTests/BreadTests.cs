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
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int orderQuantity = 1;
      Bread newBread = new Bread(orderQuantity);
      int result = newBread.Quantity;
      Assert.AreEqual(orderQuantity, result);

    }

    [TestMethod]
    public void SetQuantity_SetsValueOfQuantity_Void()
    {
      Bread newBread = new Bread(2);
      int newOrderQuantity = 4;
      newBread.Quantity = newOrderQuantity;
      Assert.AreEqual(newOrderQuantity, newBread.Quantity);
    }

    [TestMethod]
    public void GetTotalCost_ReturnsTotalCost_Int()
    {
      Bread newBread = new Bread(6);
      newBread.CalculateTotalCost();
      int totalCost = 20;
      int result = newBread.TotalCost;
      Assert.AreEqual(totalCost, result);
    }

    [TestMethod]
    public void SetTotalCost_SetsValueOfTotalCost_Void()
    {
      Bread newBread = new Bread(4);
      newBread.CalculateTotalCost();
      int newTotalCost = newBread.Quantity * newBread.TotalCost;
      newBread.TotalCost = newTotalCost;
      Assert.AreEqual(newTotalCost, newBread.TotalCost);
    }
  }
}