namespace BakeryProject.Models
{
  public class Bread
  {
    public int Count {get; set;}

    public int GetPrice(int count)
    {
      int price = 5 * count;
      return price;
    }
  }
}