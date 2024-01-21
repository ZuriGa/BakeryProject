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

    [TestMethod]
    public void GetTotalCost_ReturnsTotalCost_Int()
    {
      Pastry newPastry = new Pastry(8);
      newPastry.CalculateTotalCost();
      int totalCost = 12;
      int result = newPastry.TotalCost;
      Assert.AreEqual(totalCost, result);
    }

    [TestMethod]
    public void SetTotalCost_SetsValueOfTotalCost_Void()
    {
      Pastry newPastry = new Pastry(6);
      newPastry.CalculateTotalCost();
      int newTotalCost = newPastry.Quantity * newPastry.TotalCost;
      newPastry.TotalCost = newTotalCost;
      Assert.AreEqual(newTotalCost, newPastry.TotalCost);
    }
  }
}