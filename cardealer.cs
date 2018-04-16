using System;
using System.Collections.Generic;


class Car
{
  private string _model;
  private string _brand;
  private int _miles;
  private int _price;

  public void SetModel(string newModel)
  {
    _model = newModel;
  }

  public string GetModel()
  {
    return _model;
  }

  public void SetBrand(string newBrand)
  {
    _brand = newBrand;
  }

  public string GetBrand()
  {
    return _brand;
  }

  public void SetMiles(int newMiles = 5000)
  {
    _miles = newMiles;
  }

  public int GetMiles()
  {
    return _miles;
  }


  public void SetPrice(int newPrice = 15000)
  {
    _price = newPrice;
  }

  public int GetPrice()
  {
    return _price;
  }
}

public class Program
{
  static void Main()
  {
    Car toyota = new Car();
    toyota.SetModel("Camry");
    toyota.SetBrand("Toyota");
    toyota.SetMiles();
    toyota.SetPrice();

    Car honda = new Car();
    honda.SetModel("Civic");
    honda.SetBrand("Honda");
    honda.SetMiles(2000);
    honda.SetPrice();

    Car tesla = new Car();
    tesla.SetModel("Roadster");
    tesla.SetBrand("Tesla");
    tesla.SetMiles(6000);
    tesla.SetPrice();

    Car bmw = new Car();
    bmw.SetModel("I3");
    bmw.SetBrand("BMW");
    bmw.SetMiles(7000);
    bmw.SetPrice();

    Console.WriteLine("Cars Created");
    Console.WriteLine("What price is the Toyota?");
    int toyotaPrice = int.Parse(Console.ReadLine());
    toyota.SetPrice(toyotaPrice);
    Console.WriteLine("What price is the Honda?");
    int hondaPrice = int.Parse(Console.ReadLine());
    honda.SetPrice(hondaPrice);
    Console.WriteLine("What price is the Tesla?");
    int teslaPrice = int.Parse(Console.ReadLine());
    tesla.SetPrice(teslaPrice);
    Console.WriteLine("What price is the BMW?");
    int bmwPrice = int.Parse(Console.ReadLine());
    bmw.SetPrice(bmwPrice);

    List<Car> CarDealership = new List<Car> {toyota, honda, tesla, bmw};

    foreach (Car thisCar in CarDealership)
    {
      if (thisCar.GetPrice() >= 15000 || thisCar.GetMiles() >= 5000) {
        Console.WriteLine("The " + thisCar.GetBrand() + " " + thisCar.GetModel() + " has " + thisCar.GetMiles() + " miles and costs $" + thisCar.GetPrice());
      }
    }
  }
}
