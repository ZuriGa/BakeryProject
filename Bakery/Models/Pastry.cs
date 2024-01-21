
namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int TotalCost { get; set; }
    public Pastry(int quantity)
    {
      Quantity = quantity;
      CalculateTotalCost();
    }

    public void CalculateTotalCost()
    {
      int pastryPrice = 2;
      int offerPastries = Quantity / 4;
      int discountedAmount = offerPastries * 2;

      if (Quantity % 4 == 0)
      {
        TotalCost = pastryPrice * Quantity - discountedAmount;
      }
      else if (Quantity > 4)
      {
        TotalCost = pastryPrice * Quantity - discountedAmount + (Quantity % 4) * 5;
      }
      else 
      {
        TotalCost = pastryPrice * Quantity;
      }
      
    }
  }
}