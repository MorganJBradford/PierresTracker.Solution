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
      Order newOrder = new Order("Cannoli", "45 Cannolis", 60, "4/1/2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Cannoli";

      //Act
      Order newOrder = new Order(title, "45 Cannolis", 60, "4/1/2021");
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Cannoli";
      Order newOrder = new Order(title, "45 cannolis", 60, "4/1/2021");

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
      Order newOrder = new Order("Donuts", description, 60, "4/1/2021");
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Cannoli";
      Order newOrder = new Order(description, "45 cannolis", 60, "4/1/2021");

      //Act
      string updatedDescription = "Donuts";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      int price = 60;

      //Act
      Order newOrder = new Order("Donuts", "45 donuts", price, "4/1/2021");
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      //Arrange
      int price = 60;
      Order newOrder = new Order("donuts", "45 glazed donuts", price, "4/1/2021");

      //Act
      int updatedPrice = 50;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string date = "4/1/2021";

      //Act
      Order newOrder = new Order("Donuts", "45 donuts", 60, date);
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      //Arrange
      string date = "4/1/2021";
      Order newOrder = new Order("donuts", "45 glazed donuts", 60, date);

      //Act
      string updatedDate = "3/20/2021";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedDate, result);
    }
  }
}