using System; 
using System.Collections.Generic; 

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Message { get; set; }

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
    }
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "A Good Ol' Betty");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "It will go whereever yugo.");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "You won't get bored when you drive this Ford.");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "We don't know what this is, but we suspect it's not a movie.");

      // List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
      

    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }
    // public string GetMessage()
    // {
    //   return _message;
    // }
    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public bool LowMileage(int maxMileage)
    {
      return (Miles < maxMileage);
    }
  }
}