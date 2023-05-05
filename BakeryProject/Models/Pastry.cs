namespace BakeryProject.Models
{
  public class Pastry
  {
    public int Count {get; set;}

    public int GetPrice()
    {
      int count = this.Count;
      int price = count * 2;
      return price;
    }
  }
}