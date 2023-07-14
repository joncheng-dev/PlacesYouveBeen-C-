using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int LengthOfStay { get; set; }

    public Place(string cityName)
    {
      CityName = cityName;
    }

    public Place(string cityName, int lengthOfStay)
    {
      CityName = cityName;
      LengthOfStay = lengthOfStay;
    }
  }
}