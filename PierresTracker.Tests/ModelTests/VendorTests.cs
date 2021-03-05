using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;

namespace PierresTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "description");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Pedro's Poultry";
      Vendor newVendor = new Vendor(name, "description");

      //Act
      string updatedName = "Esther's Essentials";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "description";

      //Act
      Vendor newVendor = new Vendor("Esther's Essentials", description);
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
  }
}