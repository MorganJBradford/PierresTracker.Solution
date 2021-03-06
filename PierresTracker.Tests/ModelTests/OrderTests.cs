using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      DateTime localDate = DateTime.Now;
      Order newOrder = new Order("Cannoli", "45 Cannolis", 60, localDate);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Cannoli";
      DateTime localDate = DateTime.Now;

      //Act
      Order newOrder = new Order(title, "45 Cannolis", 60, localDate);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Cannoli";
      DateTime localDate = DateTime.Now;
      Order newOrder = new Order(title, "45 cannolis", 60, localDate);

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
      DateTime localDate = DateTime.Now;

      //Act
      Order newOrder = new Order("Donuts", description, 60, localDate);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Cannoli";
      DateTime localDate = DateTime.Now;
      Order newOrder = new Order(description, "45 cannolis", 60, localDate);

      //Act
      string updatedDescription = "Donuts";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Float()
    {
      //Arrange
      float price = 60;
      DateTime localDate = DateTime.Now;

      //Act
      Order newOrder = new Order("Donuts", "45 donuts", price, localDate);
      float result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Float()
    {
      //Arrange
      float price = 60;
      DateTime localDate = DateTime.Now;
      Order newOrder = new Order("donuts", "45 glazed donuts", price, localDate);

      //Act
      float updatedPrice = 50;
      newOrder.Price = updatedPrice;
      float result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      DateTime localDate = DateTime.Now;

      //Act
      Order newOrder = new Order("Donuts", "45 donuts", 60, localDate);
      DateTime result = newOrder.Now;

      //Assert
      Assert.AreEqual(localDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title01 = "Cannoli";
      string description01 = "45 cannolis";
      float price01 = 80;
      DateTime localDate01 = DateTime.Now;
      string title02 = "Donuts";
      string description02 = "45 glazed donuts";
      float price02 = 70;
      DateTime localDate02 = DateTime.Now;
      Order newOrder1 = new Order(title01, description01, price01, localDate01);
      Order newOrder2 = new Order(title02 ,description02, price02, localDate02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Cannoli";
      string description = "45 cannolis";
      float price = 80;
      DateTime localDate = DateTime.Now;
      Order newOrder = new Order(title, description, price, localDate);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "Cannoli";
      string description01 = "45 cannolis";
      float price01 = 80;
      DateTime localDate01 = DateTime.Now;
      string title02 = "Donuts";
      string description02 = "45 glazed donuts";
      float price02 = 70;
      DateTime localDate02 = DateTime.Now;
      Order newOrder1 = new Order(title01, description01, price01, localDate01);
      Order newOrder2 = new Order(title02 ,description02, price02, localDate02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}