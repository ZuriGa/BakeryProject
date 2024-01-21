
namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
  }
}