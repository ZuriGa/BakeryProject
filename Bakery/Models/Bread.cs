namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; } 
    public int CalculateCost { get; }
    public Bread(int quantity, int totalCost)
    {
      Quantity = quantity;
      CalculateCost = totalCost;
    }
  }
}
