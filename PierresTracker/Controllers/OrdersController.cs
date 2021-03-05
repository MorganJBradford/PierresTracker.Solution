using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;
using System.Collections.Generic;

namespace PierresTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
  }
}