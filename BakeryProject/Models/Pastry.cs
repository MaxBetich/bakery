using System.Collections.Generic;

namespace BakeryProject.Models
{
  public class Pastry
  {
    public int Count {get; set;}

    public int GetPrice()
    {
      int count = this.Count;
      int price = 0;
      List<int> countList = new List<int> {};
      for (int i = 1; i <= count; i++)
      {
        countList.Add(i);
      }
      foreach(int element in countList)
      {
        if (element % 4 == 0)
        {
        }
        else
        {
          price += 2;
        }
      }
      return price;
    }
  }
}