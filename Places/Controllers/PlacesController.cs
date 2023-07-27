using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/journal")]
    public ActionResult Index()
    {
      List<Place> allEntries = Place.GetAll();
      return View(allEntries);
    }

    [HttpGet("/journal/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/journal")]
    public ActionResult Create(string cityName, int lengthOfStay, string journalEntry, List<string> companionList, List<string> pictureList)
    {
      Place aNewPlace = new Place(cityName, lengthOfStay, journalEntry, companionList, pictureList);
      return RedirectToAction("Index");
    }

    [HttpPost("/journal/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
  }
}