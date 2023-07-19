using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int LengthOfStay { get; set; }
    public string JournalEntry { get; set; }
    public List<string> CompanionList { get; set; }
    public List<string> PictureList { get; set; }

    public Place(string cityName)
    {
      CityName = cityName;
    }

    public Place(string cityName, int lengthOfStay)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
    }

    public Place(string cityName, int lengthOfStay, string journalEntry)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      JournalEntry = journalEntry;
    }

    public Place(string cityName, int lengthOfStay, string journalEntry, List<string> companionList)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      JournalEntry = journalEntry;
      CompanionList = companionList;
    }

    public Place(string cityName, int lengthOfStay, string journalEntry, List<string> companionList, List<string> pictureList)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      JournalEntry = journalEntry;
      CompanionList = companionList;
      PictureList = pictureList;
    }  
  }
}