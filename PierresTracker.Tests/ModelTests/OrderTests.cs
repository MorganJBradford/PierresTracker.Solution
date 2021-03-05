using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Cannoli", "45 Cannolis");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Cannoli";

      //Act
      Order newOrder = new Order(title, "45 Cannolis");
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Cannoli";
      Order newOrder = new Order(title, "45 cannolis");

      //Act
      string updatedTitle = "Donuts";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

        [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "45 donuts";

      //Act
      Order newOrder = new Order("Donuts", description);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

  }
}