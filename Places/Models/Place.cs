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
    public int Id { get; }

    private static List<Place> _instances = new List<Place> { };

    public Place(string cityName)
    {
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Place(string cityName, int lengthOfStay)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      _instances.Add(this);
      Id = _instances.Count;            
    }

    public Place(string cityName, int lengthOfStay, string journalEntry)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Place(string cityName, int lengthOfStay, string journalEntry, List<string> companionList)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      JournalEntry = journalEntry;
      CompanionList = companionList;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Place(string cityName, int lengthOfStay, string journalEntry, List<string> companionList, List<string> pictureList)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
      JournalEntry = journalEntry;
      CompanionList = companionList;
      PictureList = pictureList;
      _instances.Add(this); 
      Id = _instances.Count;
    }  

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
  }
}