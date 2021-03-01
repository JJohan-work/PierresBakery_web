using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Globalization;

namespace PierresBakery.Controllers {
  public class HomeController : Controller {

    [Route("/")]
    public ActionResult Home () {
      return View();
    }

    [Route("/receipt")]
    public ActionResult Receipt (int breadCount, int pastryCount) {
      Quantity quantity = new Quantity();
      quantity.InvoiceNumber = new DateTime();
      quantity.BreadCount = breadCount;
      quantity.PastryCount = pastryCount;
      return View(quantity);
    }   
  }
}
