
namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int TotalCost { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
      CalculateTotalCost();
    }

    public void CalculateTotalCost()
    {
      int breadPrice = 5;
      int offerLoaves = Quantity / 3;
      int discountedAmount = offerLoaves * 5;

      if (Quantity % 3 == 0)
      {
        TotalCost = breadPrice * Quantity - discountedAmount;
      }
      else if (Quantity > 3)
      {
        TotalCost = breadPrice * Quantity - discountedAmount + (Quantity % 3) * 5;
      }
      else
      {
        TotalCost = breadPrice * Quantity;
      }
    }

  }
}


