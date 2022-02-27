using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfItem()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnsProperties_String()
    {
      //Arrange
      string title = "Recurring croissant order for Suzie's Cafe";
      string description = "50 croissants, daily";
      string price = "$75/day";
      string date = "2/26/2022";

      Order newOrder = new Order(title, description, price, date);
      //Act
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      string priceResult = newOrder.Price;
      string dateResult = newOrder.Date;
      
      //Assert
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);
    }

    [TestMethod]
    public void SetProperties_ReturnsProperties_String()
    {
      //Arrange
      string title = "Recurring croissant order for Suzie's Cafe";
      string description = "50 croissants, daily";
      string price = "$75/day";
      string date = "2/26/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "Updated recurring croissant order for Suzie's Cafe";
      string updatedDescription = "50 croissants weekly on Sunday";
      string updatedPrice = "$100/week";
      string updatedDate = "2/27/2022";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      newOrder.Price = updatedPrice;
      newOrder.Date = updatedDate;
      
      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;
      string resultPrice = newOrder.Price;
      string resultDate = newOrder.Date;
      
      //Assert
      Assert.AreEqual(updatedTitle, resultTitle);    
      Assert.AreEqual(updatedDescription, resultDescription); 
      Assert.AreEqual(updatedPrice, resultPrice); 
      Assert.AreEqual(updatedDate, updatedDate); 
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title1 = "Recurring croissant order for Suzie's Cafe";
      string description1 = "50 croissants, daily";
      string price1 = "$75/day";
      string date1 = "2/26/2022";
      string title2 = "Recurring bread order for Marty's Grocery";
      string description2 = "50 loaves of bread delivered every Sunday and Thursday";
      string price2 = "$300/week";
      string date2 = "2/26/2022";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      foreach (Order thisOrder in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisOrder.Title); 
      }

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }    

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title1 = "Recurring croissant order for Suzie's Cafe";
      string description1 = "50 croissants, daily";
      string price1 = "$75/day";
      string date1 = "2/26/2022";
      string title2 = "Recurring bread order for Marty's Grocery";
      string description2 = "50 loaves of bread delivered every Sunday and Thursday";
      string price2 = "$300/week";
      string date2 = "2/26/2022";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}