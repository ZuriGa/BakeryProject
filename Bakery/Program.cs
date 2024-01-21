using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Bread testBread = new Bread(quantity: 4);
      Console.WriteLine(testBread.GetType());
    }
  }
}
