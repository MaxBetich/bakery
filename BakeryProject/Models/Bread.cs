namespace BakeryProject.Models
{
  public class Bread
  {
    public int Count {get; set;}

    public int GetPrice()
    {
      int count = this.Count;
      int price = 5 * count;
      return price;
    }
  }
}