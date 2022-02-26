using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
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
  }
}