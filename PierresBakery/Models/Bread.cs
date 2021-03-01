using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static List<Bread> totalBread {get;}
    public static int TotalAmount {get; set;}

    public Bread()
    {
      totalBread.Add(this);
    }

    public static int getTotal()
    {
      int fullAmount = 0;
      foreach (Bread item in totalBread)
      {
        fullAmount += item.OrderedQuantity;
      }
      return fullAmount;
    }


    public int BreadUnitCost { get; set; } = 5;
    public int OrderedQuantity { get; set; }
    // public static int FinalQuantity { get; set; }
    // public static int OrderCost { get; set; }

    public Bread(int qty ) {
      OrderedQuantity = qty;
    }

    public int FindTotalQuantity() {
      FinalQuantity = OrderedQuantity + ((OrderedQuantity - (OrderedQuantity%2))/2);
      return FinalQuantity;
    }

    public virtual int FindTotalCost() {
      OrderCost = (OrderedQuantity*BreadUnitCost);
      return OrderCost;
    }
  }
}
