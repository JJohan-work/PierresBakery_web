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

    [TestMethod]
    public void GetOrderedQuantity_OrderedPastryQuantity_Int()
    {
      int orderedQty = 10;
      Pastry newPastry = new Pastry(orderedQty);
      Assert.AreEqual(orderedQty, newPastry.OrderedQuantity);
    }

    [TestMethod]
    public void GetOrderCost_CalculatedOrderCost_Int(){
      int orderedQty = 12;
      Pastry newPastry = new Pastry(orderedQty);
      int orderCost = newPastry.FindTotalCost();
      Assert.AreEqual(20, orderCost);
    }
  }
}
