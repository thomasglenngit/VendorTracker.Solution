using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Louis", "King");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "The best test vendor";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "The best test vendor";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      string description = "Fun stuff";
      Vendor newVendor1 = new Vendor(name01, description);
      Vendor newVendor2 = new Vendor(name02, description);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      string description = "Fun stuff";
      Vendor newVendor1 = new Vendor(name01, description);
      Vendor newVendor2 = new Vendor(name02, description);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

     [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string bread = "Buns";
      string pastry = "Cupcakes";
      string title = "CEO";
      string description = "Chief Operations Officer";
      string date = "Arbor Day";
      Order newOrder = new Order(bread, pastry, title, description, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Purchase";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}