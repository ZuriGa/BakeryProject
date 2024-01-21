namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; } 
    public int TotalCost { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
      TotalCost = CalculateTotalCost();
    }
    
    private int CalculateTotalCost()
    {
      int breadPrice = 5;
      int offerLoaves = Quantity / 3;
      int discountedAmount = offerLoaves * 5;

      if (Quantity % 3 == 0)
      {
        return breadPrice * Quantity - discountedAmount;
      }
      else if (Quantity > 3)
      {
        return breadPrice * Quantity - discountedAmount + (Quantity % 3) * 5;
      }
      else
      {
        return breadPrice * Quantity;
      }
    }

  }
}
