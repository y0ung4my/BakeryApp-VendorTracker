using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnsProperties_String()
    {
      //Arrange
      string name = "Suzie's Cafe";
      string description = "Suzie's Cafe is owned by Suzie McSuzieFace. Top client!";
      Vendor newVendor = new Vendor(name, description);
      //Act
      string nameResult = newVendor.Name;
      string descriptionResult = newVendor.Description;
      //Assert
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }

    [TestMethod]
    public void SetProperties_ReturnsProperties_String()
    {
      //Arrange
      string name = "Suzie's Cafe";
      string description = "Suzie's Cafe is owned by Suzie McSuzieFace. Top client!";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string updatedName = "Suzie's Cafe on 6th";
      string updatedDescription = "Suzie moved to a different location. Worst client!";
      newVendor.Name = updatedName;
      newVendor.Description = updatedDescription;
      string resultName = newVendor.Name;
      string resultDescription = newVendor.Description;
      
      //Assert
      Assert.AreEqual(updatedName, resultName);    
      Assert.AreEqual(updatedDescription, resultDescription);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string name1 = "Suzie's Cafe";
      string description1 = "Suzie's Cafe is owned by Suzie McSuzieFace. Top client!";
      string name2 = "Marty's Grocery";
      string description2 = "Grocery store owned by Marty McSmarty.";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      foreach (Vendor thisVendor in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisVendor.Description);
      }

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }    

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title1 = "Recurring croissant order for Suzie's Cafe";
      string description1 = "50 croissants, daily";
      string price1 = "$75/day";
      string date1 = "2/26/2022";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      List<Order> newList = new List<Order> { newOrder1 };
      string title = "Suzie's Cafe";
      string description = "Suzie's Cafe is owned by Suzie McSuzieFace. Top client!";
      Vendor newVendor = new Vendor(title, description);
      newVendor.AddOrder(newOrder1);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "Suzie's Cafe";
      string description1 = "Suzie's Cafe is owned by Suzie McSuzieFace. Top client!";
      string name2 = "Marty's Grocery";
      string description2 = "Grocery store owned by Marty McSmarty.";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);

      //Act
      Vendor result = Vendor.Find((2 -1));

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
  }
}