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
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int qty = 2;
      Bread newBread = new Bread(qty); 
      Assert.AreEqual(qty, newBread.Quantity);  
    }

    // [TestMethod]
    // public void SplitStringIntoChar_CreatesCharArray_char(){
    //   Game newGame = new Game();
    //   string tempString = "olga";
    //   char[] charArray = tempString.ToCharArray();
    //   Console.WriteLine("-----------------------------------");
    //   Console.WriteLine(charArray.ToString());
    //   Console.WriteLine("-----------------------------------");
    //   char[] charReturn = newGame.SplitStringIntoChar("olga");
    //    Console.WriteLine(charReturn.ToString());
    //   Assert.AreEqual(charArray, charReturn);
    // }

    // [TestMethod]
    // public void GetScrabbleValuePerChar_ReturnCharValue_int() {
    //   Game newGame = new Game();
    //   int letter = newGame.ReturnCharValue('A');
    //   Console.WriteLine(letter);
    //   Assert.AreEqual(letter, 3);
    // }
  }


}
