using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadUnitCost { get; set; } = 5;
    public int OrderedQuantity { get; set; }
    public int FinalQuantity { get; set; }
    public int OrderCost { get; set; }

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
