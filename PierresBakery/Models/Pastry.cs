using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace PierresBakery.Models
{
  public class Pastry : Bread
  {
    public int PastryUnitCost { get; set; } = 2;
    public int PastryCostForThree { get; set; } = 5;

    public Pastry(int qty) : base(qty) {
      OrderedQuantity = qty;
    }

    public override int FindTotalCost() {
      int multipleOfThree = (int) OrderedQuantity/3;
      OrderCost = (multipleOfThree*PastryCostForThree) + ((OrderedQuantity%3)*PastryUnitCost);
      return OrderCost;
    }
  }

}

