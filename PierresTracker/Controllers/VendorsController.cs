using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;
using System;

namespace PierresTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, float orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      DateTime localDate = DateTime.Now;
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, localDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult DeleteOrder(int vendorId, int orderId)
    {
      Order foundOrder = Order.Find(orderId);
      Vendor foundVendor = Vendor.Find(vendorId);
      foundVendor.RemoveOrder(foundOrder);
      return View();
    }
    
    [HttpPost("/vendors/{vendorId}")]
    public ActionResult DeleteVendor(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      DateTime localDate = DateTime.Now;
      Vendor foundVendor = Vendor.Find(vendorId);
      foundVendor.RemoveVendor((foundVendor));
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View(model);
    }

  }
}