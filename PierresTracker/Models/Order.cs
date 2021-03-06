using System.Collections.Generic;
using System;

namespace PierresTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public DateTime Now { get; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order (string title, string description, int price, DateTime now)
    {
      Title = title;
      Description = description;
      Price = price;
      Now = now;
      _instances.Add(this);
      Id = Id + 1;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}