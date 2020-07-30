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
      Order newOrder = new Order("Buns", "Cupcakes", "Spartacus", "Roman", "January");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

      [TestMethod]
      public void GetFoodOrder_ReturnsFoodOrder_String()
      {
        //Arrange
        string bread = "Buns";
        string pastry = "Cupcakes";
        string title = "Spartacus";
        string description = "Roman";
        string date = "January";

        //Act
        Order newOrder = new Order(bread, pastry, title, description, date);
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
        string title = "Pauper";
        string description = "Lowerclass";
        string date = "January";
        Order newOrder = new Order(bread, pastry, title, description, date);

        //Act
        string updatedBread = "Whole-wheat Loaf";
        string updatedPastry = "Éclair";
        string updatedTitle = "Majesty";
        string updatedDescription = "Royalty";
        string updatedDate = "February";
        newOrder.Bread = updatedBread;
        newOrder.Pastry = updatedPastry;
        newOrder.Title = updatedTitle; 
        newOrder.Description = updatedDescription;
        newOrder.Date = updatedDate;
        string result1 = newOrder.Bread;
        string result2 = newOrder.Pastry;
        string result3 = newOrder.Title;
        string result4 = newOrder.Description;
        string result5 = newOrder.Date;

        //Assert
        Assert.AreEqual(updatedBread, result1);
        Assert.AreEqual(updatedPastry, result2);
        Assert.AreEqual(updatedTitle, result3);
        Assert.AreEqual(updatedDescription, result4);
        Assert.AreEqual(updatedDate, result5);

      }

      [TestMethod]
      public void GetAll_ReturnsEmptyList_OrderList() 
      {
        List<Order> newList = new List<Order> { };

        //Act
        List<Order> result = Order.GetAll();

       

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
        string title = "Director";
        string description = "The Boss";
        string date = "Birthday";
        Order newOrder1 = new Order(bread1, pastry1, title, description, date);
        Order newOrder2 = new Order(bread2, pastry2, title, description, date);
        List<Order> newList = new List<Order> { newOrder1, newOrder2 };

        //Act
        List<Order> result = Order.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
      }

    //   [TestMethod]
    // public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string bread = "Whole-wheat";
    //   string pastry = "Croissant";
    //   Order newOrder = new Order(bread, pastry);

    //   //Act
    //   int result = newOrder.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectOrder_Order()
    // {  
    //   //Arrange

    //   string bread1 = "Buns";
    //   string bread2 = "Wheat";
    //   string pastry1 = "Croissants";
    //   string pastry2 = "Madeleines";
    //   Order newOrder1 = new Order(bread1, pastry1);
    //   Order newOrder2 = new Order(bread2, pastry2);
    
    //   //Act
    //   Order result = Order.Find(2);
  
    //   //Assert  
    //   Assert.AreEqual(newOrder2, result); 
    // }
  }   
}