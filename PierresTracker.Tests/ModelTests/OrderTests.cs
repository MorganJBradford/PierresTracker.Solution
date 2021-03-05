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
      Order newOrder = new Order("Cannoli");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Cannoli";

      //Act
      Order newOrder = new Order(title);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);

    }
  }
}