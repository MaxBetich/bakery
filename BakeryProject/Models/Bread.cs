using System.Collections.Generic;

namespace BakeryProject.Models
{
  public class Bread
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
        if (element % 3 == 0)
        {
        }
        else
        {
          price += 5;
        }
      }
      return price;
    }
  }
}