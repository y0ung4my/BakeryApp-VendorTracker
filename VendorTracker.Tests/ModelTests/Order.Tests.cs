using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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

    
  }
}