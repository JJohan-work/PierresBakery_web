using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
   [TestClass]
   public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Bread newPastry = new Pastry(2); 
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());  
    }

    // [TestMethod]
    // public void GetOrderedQuantity_ReturnsQuantity_Int()
    // {
    //   int orderedQty = 2;
    //   Bread newBread = new Bread(orderedQty);
    //   Assert.AreEqual(orderedQty, newBread.OrderedQuantity);
    // }

    // [TestMethod]
    // public void GetFinalQuantity_CalculatedTotalQty_Int(){
    //   int orderedQty = 10;
    //   Bread newBread = new Bread(orderedQty);
    //   int totalQty = newBread.FindTotalQuantity();
    //   Assert.AreEqual(15, totalQty);
    // }

    // [TestMethod]
    // public void GetOrderCost_CalculatedOrderCost_Int(){
    //   int orderedQty = 10;
    //   Bread newBread = new Bread(orderedQty);
    //   int orderCost = newBread.FindTotalCost();
    //   Assert.AreEqual(20, orderCost);
    // }
  }


}
