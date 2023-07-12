using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public Place(string cityName)
    {
      CityName = cityName;
    }
  }
}