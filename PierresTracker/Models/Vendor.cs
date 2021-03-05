using System.Collections.Generic;

namespace PierresTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}