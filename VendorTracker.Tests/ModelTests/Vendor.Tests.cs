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
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}