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
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Bread newBread = new Bread(); 
      Assert.AreEqual(typeof(Bread), newBread.GetType());  
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
