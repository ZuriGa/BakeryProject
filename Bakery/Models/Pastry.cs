
namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int TotalCost => CalculateTotalCost();
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int CalculateTotalCost()
    {
      int pastryPrice = 2;
      int offerPastries = Quantity / 4;
      int discountedAmount = offerPastries * pastryPrice;

      return pastryPrice * Quantity - discountedAmount;
    }
  }
}