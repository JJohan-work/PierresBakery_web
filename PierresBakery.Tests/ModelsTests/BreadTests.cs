using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
   [TestClass]
   public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2); 
      Assert.AreEqual(typeof(Bread), newBread.GetType());  
    }

    [TestMethod]
    public void GetOrderedQuantity_OrderedBreadQuantity_Int()
    {
      int orderedQty = 2;
      Bread newBread = new Bread(orderedQty);
      Assert.AreEqual(orderedQty, newBread.OrderedQuantity);
    }

    [TestMethod]
    public void GetFinalQuantity_CalculatedBreadQuantity_Int(){
      int orderedQty = 14;
      Bread newBread = new Bread(orderedQty);
      int totalQty = newBread.FindTotalQuantity();
      Assert.AreEqual(21, totalQty);
    }

    [TestMethod]
    public void GetOrderCost_CalculatedBreadOrderCost_Int(){
      int orderedQty = 10;
      Bread newBread = new Bread(orderedQty);
      int orderCost = newBread.FindTotalCost();
      Assert.AreEqual(50, orderCost);
    }
    
  }


}
