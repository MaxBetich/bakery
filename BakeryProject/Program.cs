using System;
using BakeryProject.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Welcome to your friendly neighborhood bakery!");
      Console.WriteLine("Our specialties for today are freshly-baked loaves of bread, and a wide variety of pastries");
      Console.WriteLine("Prices:");
      Console.WriteLine("Bread: $5/loaf");
      Console.WriteLine("Pastries: $2/item");
      Console.WriteLine("We currently have two specials running:");
      Console.WriteLine("For every two loaves of bread purchased, we will include a third loaf for free!");
      Console.WriteLine("For every three pastries purchased, we will include a fourth pastry of your choice for free!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Please enter the number of loaves of bread you are interested in purchasing:");
      int bread = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the number of pastries you are interested in purchasing:");
      int pastries = int.Parse(Console.ReadLine());
      Bread newBread = new Bread();
      newBread.Count = bread;
      Pastry newPastry = new Pastry();
      newPastry.Count = pastries;
      int breadPrice = newBread.GetPrice();
      int pastryPrice = newPastry.GetPrice();
      int totalPrice = breadPrice + pastryPrice;
      Console.WriteLine("Your total for {0} loaves and {1} pastries is {2} dollars", bread, pastries, totalPrice);
    }
  }
}