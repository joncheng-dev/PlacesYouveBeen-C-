using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    // [HttpGet("/journal")]
    // public ActionResult Index()
    // {

    //   List<Item> allPackages = Item.GetAll();
    //   return View(allPackages);
    // }

    [HttpGet("/journal/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // [HttpPost("/journal")]
    // public ActionResult Create(double weight, double length, double width, double height)
    // {
    //   Item anItem = new Item(weight, length, width, height);
    //   anItem.CalculateVolume();
    //   anItem.CalculateCost();
    //   return RedirectToAction("Index");
    // }
  }
}