using System;
using System.Collections.Generic;
using PierresBakery.Models;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      int breadCount;
      int pastryCount;
      Console.WriteLine("############## Welcome to Pierre's Bakery ################");
      Console.WriteLine("#                          Menu                          #");
      Console.WriteLine("# 1. Bread   : Buy 2, get 1 free. A single loaf costs $5 #");
      Console.WriteLine("# 2. Pastry  : Buy 1 for $2 or 3 for $5                  #");
      Console.WriteLine("##########################################################");

      Console.WriteLine("Enter Bread Qty: ");
      bool parseSuccessBread = int.TryParse(Console.ReadLine(), out breadCount);
      Console.WriteLine("Enter Pastry Qty: ");
      bool parseSuccessPastry = int.TryParse(Console.ReadLine(), out pastryCount);

      // Console.WriteLine($"Bread Qty entered is {breadCount} and parseSuccessBread is {parseSuccessBread}");
      // Console.WriteLine($"Pastry Qty entered is {pastryCount} and parseSuccessPastry is {parseSuccessPastry}");

      while((!parseSuccessBread) || (breadCount < 0) || (!parseSuccessPastry) || (pastryCount < 0) ) //entered value is int and is 0 or greater
      {
        Console.WriteLine("INVALID. Enter a valid Quantity else enter Q to Exit or hit ENTER to restart");
        if (Console.ReadLine() == "Q") {
          System.Environment.Exit(1);
        }
        else {
          Main();
        }
      }

      Bread bread = new Bread(breadCount);
      Pastry pastry = new Pastry(pastryCount);
      Console.WriteLine("##################### Pierre's Bakery #####################");
      Console.WriteLine($"Invoice # {Bread.UnixTimeNow()}");
      Console.WriteLine($"Date: {DateTime.Now.ToString("M/d/yyyy")}");
      Console.WriteLine($"Date: {DateTime.Now.ToString("h:mm:ss tt")}");
      Console.WriteLine("==============================================================");
      Console.WriteLine($"ITEM{"\t"}QTY{"\t"}DESC{"\t"}{"\t"}{"\t"}{"\t"}RATE{"\t"}AMOUNT");
      Console.Write($"Bread{"\t"}");
      Console.Write($"{breadCount}{"\t"}");
      Console.Write($"Total Qty is {bread.FindTotalQuantity()}{"\t"}{"\t"}{"\t"}");
      Console.Write($"${bread.BreadUnitCost}{"\t"}");
      Console.WriteLine($"${bread.FindTotalCost()}");
      
      Console.Write($"Pastry{"\t"}");
      Console.Write($"{pastryCount}{"\t"}");
      Console.Write($"Buy 1 for $2 or 3 for $5{"\t"}");
      Console.Write($"${pastry.BreadUnitCost}{"\t"}");
      Console.WriteLine($"${pastry.FindTotalCost()}");

      System.Environment.Exit(1);
    }
  }
}