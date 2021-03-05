namespace PierresTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; }

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
    }
  }
}