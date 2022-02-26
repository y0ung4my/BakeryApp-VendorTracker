using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor  
  {
    public string Name { get; set; }
    public string Description { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
    }
    
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}