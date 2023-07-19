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

    [TestMethod]
    public void GetCompanionsList_ReturnCompanionsList_StringList()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      string journalEntry = "Dear journal. Today was the most wonderful day.";
      List<string> companions = new List<string>()
      {
        "De",
        "Li",
        "Al",
      };

      Place newPlace = new Place(nameOfCity, lengthOfStay, journalEntry, companions);

      CollectionAssert.AreEqual(companions, newPlace.CompanionList);
    }

    [TestMethod]
    public void SetCompanionsList_SetsNewValuesForCompanionsList_ItemList()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      string journalEntry = "Dear journal. Today was the most wonderful day.";
      List<string> companions = new List<string>()
      {
        "De",
        "Li",
        "Al",
      };

      Place newPlace = new Place(nameOfCity, lengthOfStay, journalEntry, companions);

      List<string> companionsUpdated = new List<string>()
      {
        "Gu",
        "Jo",
      };

      newPlace.CompanionList = companionsUpdated;

      CollectionAssert.AreEqual(companionsUpdated, newPlace.CompanionList);
    }

    [TestMethod]
    public void GetPicturesList_ReturnPicturesList_StringList()
    {
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      string journalEntry = "Dear journal. Today was the most wonderful day.";
      List<string> companions = new List<string>()
      {
        "De",
        "Li",
        "Al",
      };
      List<string> pictures = new List<string>()
      {
        "https://upload.wikimedia.org/wikipedia/commons/1/17/SanLeandroCityHall_%28cropped%29.JPG",
        "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Casa_Peralta_%28San_Leandro%2C_CA%29.JPG/1280px-Casa_Peralta_%28San_Leandro%2C_CA%29.JPG",
      };

      Place newPlace = new Place(nameOfCity, lengthOfStay, journalEntry, companions, pictures);

      CollectionAssert.AreEqual(pictures, newPlace.PictureList);
    }

    [TestMethod]
    public void SetPicturesList_SetsNewStringsForPictureList_StringList()
    { 
      string nameOfCity = "San Leandro";
      int lengthOfStay = 10;
      string journalEntry = "Dear journal. Today was the most wonderful day.";
      List<string> companions = new List<string>()
      {
        "De",
        "Li",
        "Al",
      };
      List<string> pictures = new List<string>()
      {
        "https://upload.wikimedia.org/wikipedia/commons/1/17/SanLeandroCityHall_%28cropped%29.JPG",
        "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Casa_Peralta_%28San_Leandro%2C_CA%29.JPG/1280px-Casa_Peralta_%28San_Leandro%2C_CA%29.JPG",
      };

      Place newPlace = new Place(nameOfCity, lengthOfStay, journalEntry, companions, pictures);

      List<string> updatedPictures = new List<string>()
      {
        "https://img.marinas.com/v2/a8cf922155ac9670f85fc33a453db44a055175e7e276e2b9ec3d873b99d5b367.jpg",
        "https://www.timejones.com/San%20Leandro.jpg",
      };

      newPlace.PictureList = updatedPictures;

      CollectionAssert.AreEqual(updatedPictures, newPlace.PictureList);

    }
  }
}
