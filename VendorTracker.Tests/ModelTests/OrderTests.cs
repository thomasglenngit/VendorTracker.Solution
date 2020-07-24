using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

  public void Dispose() 
  {
     Order.ClearAll(); 
  }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Buns", "Cupcakes");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

      [TestMethod]
      public void GetFoodOrder_ReturnsFoodOrder_String()
      {
        //Arrange
        string bread = "Buns";
        string pastry = "Cupcakes";

        //Act
        Order newOrder = new Order(bread, pastry);
        string result1 = newOrder.Bread;
        string result2 = newOrder.Pastry;

        //Assert
        Assert.AreEqual(bread, result1);
        Assert.AreEqual(pastry, result2);
      }  

    [TestMethod]
      public void SetFoodOrder_SetFoodOrder_String()
      {
        //Arrange
        string bread = "Buns";
        string pastry = "Cupcakes";
        Order newOrder = new Order(bread, pastry);

        //Act
        string updatedBread = "Whole-wheat Loaf";
        string updatedPastry = "Éclair";
        newOrder.Bread = updatedBread;
        newOrder.Pastry = updatedPastry;
        string result1 = newOrder.Bread;
        string result2 = newOrder.Pastry;

        //Assert
        Assert.AreEqual(updatedBread, result1);
        Assert.AreEqual(updatedPastry, result2);
      }

      [TestMethod]
      public void GetAll_ReturnsEmptyList_OrderList() 
      {
        List<Order> newList = new List<Order> { };

        //Act
        List<Order> result = Order.GetAll();

        // foreach (Order thisOrder in result)
        // {
        //   Console.WriteLine("Output from second GetAll test: " + thisOrder.Description);
        // }

        //Assert
        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void GetAll_ReturnsOrders_OrderList()
      {
        //Arrange
        string bread1 = "Buns";
        string bread2 = "Wheat";
        string pastry1 = "Croissants";
        string pastry2 = "Madeleines";
        Order newOrder1 = new Order(bread1, pastry1);
        Order newOrder2 = new Order(bread2, pastry2);
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
      string bread = "Whole-wheat";
      string pastry = "Croissant";
      Order newOrder = new Order(bread, pastry);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void Find_ReturnsCorrectOrder_Order()
    // {  
    //   //Arrange
    //   string description01 = "Walk the dog.";
    //   string description02 = "Wash the dishes.";
    //   Order newOrder1 = new Order(description01);
    //   Order newOrder2 = new Order(description02);

    //   //Act
    //   Order result = Order.Find(2);
  
    //   //Assert  
    //   Assert.AreEqual(newOrder2, result); 
    // }
  }   
}