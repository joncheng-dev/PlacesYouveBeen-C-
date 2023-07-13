using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Places.Models;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Auckland");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnCityName_String()
    {
      string nameOfCity = "San Leandro";
      Place newPlace = new Place(nameOfCity);
      string result = newPlace.CityName;
      Assert.AreEqual(nameOfCity, result);
    }

    [TestMethod]
    public void SetCityName_SetCityNameToNewString_String()
    {
      string nameOfCity = "San Leandro";
      Place newPlace = new Place(nameOfCity);
      string newCity = "San Diego";
      newPlace.CityName = newCity;
      Assert.AreEqual(newCity, newPlace.CityName);      
    }
  }
}