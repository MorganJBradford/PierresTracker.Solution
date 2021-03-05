namespace PierresTracker
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; }

    public Order (string title, string description, int price)
    {
      Title = title;
      Description = description;
    }
  }
}