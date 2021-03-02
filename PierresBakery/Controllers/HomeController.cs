using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace PierresBakery.Controllers {
  public class HomeController : Controller {

    [Route("/")]
    public ActionResult Home () {
      return View();
    }
    [Route("/addBread")]
    public ActionResult Home ()
    {
      return View();
    }

    [Route("/orderPastry")]
    public ActionResult Pastry()
    {
      return View();
    }

    [Route("/orderBread")]
    public ActionResult Bread()
    {
      return View();
    }

    [Route("/receipt")]
    public ActionResult Receipt () {
      // Quantity quantity = new Quantity();
      // quantity.InvoiceNumber = new DateTime();
      // quantity.BreadCount = breadCount;
      // quantity.PastryCount = pastryCount;
      return View();
    }   
    [Route("/Checkout")]
    public string Checkout ()
    {
      return "Checkout is confirmed";
    }
  }
}
