using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int LengthOfStay { get; set; }
    public string JournalEntry { get; set; }

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
  }
}