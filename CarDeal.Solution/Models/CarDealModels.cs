using System;
using System.Collections.Generic;

namespace Dealership.Models 
{
  public class Cars
  {
    public string Car {get; set;}
    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get;set;}
    public string Message {get;set;}
    public static List<Cars> CarList = new List<Cars>{};
    
    
    public static  List<Cars> ShowCars()
    {
       return CarList;  
    }

    
    public Cars(string makeModel, int price, int miles, string message)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        Message = message;
        CarList.Add(this);
    }
    
   public static void ClearAll()
   {
     CarList.Clear();
   }
    
    public static string MakeSound (string sound) {
      return "This car makes the sound" + sound + "!";
    }

    public static int PricePerMile (int price, int miles) 
    {
      return (miles/price);
    }
    
    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price < maxPrice && Miles < maxMileage);
    }
  }
}