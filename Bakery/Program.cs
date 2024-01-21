using System;
using Bakery.Models;
using System.Collections.Generic;


namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
      OrderDisplay();
      Console.WriteLine("                 ~ Goodbye ~");
      Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
    }

    static void OrderDisplay()
    {
      int breadQuantity;
      int pastriesQuantity;
      Bread newBread;
      Pastry newPastry;

      Console.WriteLine("Pierre offers the following items:");
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


      try
      {
        int breadOrder = int.Parse(Console.ReadLine());
        newBread.Quantity = breadOrder;
        newBread.CalculateTotalCost();
        int breadCost = newBread.TotalCost;

        int pastryOrder = int.Parse(Console.ReadLine());
        newPastry.Quantity = pastryOrder;
        newPastry.CalculateTotalCost();
        int pastryCost = newPastry.TotalCost;

        Console.WriteLine("              Here's your order:");
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        Console.WriteLine("           Bread Order x {1}: {0:C}", newBread.TotalCost, newBread.Quantity);
        Console.WriteLine("          Pastry Order x {1}: {0:C}", newPastry.TotalCost, newPastry.Quantity);
        Console.WriteLine("          Total Order Cost: {0:C}", breadCost + pastryCost);
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");

      }
      catch
      {
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        Console.WriteLine("     !     Unable to complete order!     !");
        Console.WriteLine("     !  Please enter only whole numbers  !");
        Console.WriteLine("-....- -....- -....- -....- -....- -....- -....--....- ");
        OrderDisplay();
      }
    }

    static void ConfirmOrder()
    {
      Console.WriteLine("    Would you like to purchase more items?  ");
      Console.WriteLine("       To add more, type 'yes'.");
      Console.WriteLine("        To exit, enter any other key.");
      string userInput = Console.ReadLine();

      if (userInput == "yes" || userInput == "Yes")
      {
        OrderDisplay();
      }
    }
  }
}