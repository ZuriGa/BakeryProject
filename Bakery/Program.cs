using System;
using Bakery.Models;
using Bakery.UserInterfaceModels;


namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.WriteLine("           ~~ Welcome to Pierre's Bakery! ~~");
      Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
      BakeryMenu();
      Console.WriteLine("\n                 ~~ Goodbye ~~");
      Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
    }

    static void BakeryMenu()
    {
      int breadQuantity;
      int pastriesQuantity;
      Bread newBread = null;
      Pastry newPastry = null;


      Console.WriteLine("   Pierre offers the following items:");
      Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....--....-  ");
      Console.WriteLine("|    Bread:  | Buy 2, get 1 free - Single loaf $5.00    |");
      Console.WriteLine("|    Pastry: | Buy 3, get 1 free - Single Pastry $2.00  |");
      Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....--....-  ");

      Console.Write("   Enter the quantity of Bread loaves: ");
      breadQuantity = int.Parse(Console.ReadLine());
      Console.Write("   Enter the quantity of Pastries: ");
      pastriesQuantity = int.Parse(Console.ReadLine());

      newBread = new Bread(breadQuantity);
      newPastry = new Pastry(pastriesQuantity);

      OrderDisplay(newBread, newPastry);
    }

    static void OrderDisplay(Bread newBread, Pastry newPastry)
    {
      try
      {
        newBread.CalculateTotalCost();
        int breadCost = newBread.TotalCost;

        newPastry.CalculateTotalCost();
        int pastryCost = newPastry.TotalCost;
        Console.WriteLine("\n              Here's your order:");
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        Console.WriteLine($"           Bread Order x {newBread.Quantity}: {newBread.TotalCost:C}");
        Console.WriteLine($"          Pastry Order x {newPastry.Quantity}: {newPastry.TotalCost:C}");
        Console.WriteLine($"          Total Order Cost: {breadCost + pastryCost:C}");
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        ConfirmOrder(newBread, newPastry);
      }
      catch (FormatException)
      {
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        Console.WriteLine("     !     Unable to complete order!     !");
        Console.WriteLine("     !  Please enter only numbers  !");
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        OrderDisplay(newBread, newPastry);
      }
    }

    static void ConfirmOrder(Bread newBread, Pastry newPastry)
    {
      Console.WriteLine("    Would you like to complete your purchase or edit your order?  ");
      Console.WriteLine("       To edit your order type 'e', ");
      Console.WriteLine("        To Complete order type 'c',");
      Console.WriteLine("         To exit enter any other key.");
      
      string userInput = Console.ReadLine();

      if (userInput == "e" || userInput == "E")
      {
        BakeryMenu();
      }
      else if (userInput == "c" || userInput == "C")
      {
        Console.WriteLine($"Your final order: Bread x {newBread.Quantity}, Pastry x {newPastry.Quantity}");
        Console.WriteLine($"Total Order Cost: {newBread.TotalCost + newPastry.TotalCost:C}");
      }
    }

  }
}