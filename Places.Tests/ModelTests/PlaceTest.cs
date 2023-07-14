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

    [TestMethod]
    public void GetLengthOfStay_ReturnLengthOfStay_Int()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      Place newPlace = new Place(nameOfCity, lengthOfStay);

      int getResult = newPlace.LengthOfStay;

      Assert.AreEqual(lengthOfStay, getResult);
    }

    [TestMethod]
    public void SetLengthOfStay_SetsLengthOfStayToNewValue_Int()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      Place newPlace = new Place(nameOfCity, lengthOfStay);

      int updatedLengthOfStay = 20;
      newPlace.LengthOfStay = updatedLengthOfStay;

      Assert.AreEqual(updatedLengthOfStay, newPlace.LengthOfStay);
    }

    [TestMethod]
    public void GetJournalEntry_ReturnJournalEntry_String()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      string journalEntry = "Dear journal. Today was the most wonderful day.";
      Place newPlace = new Place(nameOfCity, lengthOfStay, journalEntry);

      string getResult = newPlace.JournalEntry;
      Assert.AreEqual(journalEntry, getResult);
    }

    [TestMethod]
    public void SetJournalEntry_SetsJournalEntry_String()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      string journalEntry = "Dear journal. Today was the most wonderful day.";
      Place newPlace = new Place(nameOfCity, lengthOfStay, journalEntry);

      string updatedJournalEntry = "Oh journal! Today was the most magnificient, bunch of hours.";
      newPlace.JournalEntry = updatedJournalEntry;

      Assert.AreEqual(updatedJournalEntry, newPlace.JournalEntry);
    }
  }
}