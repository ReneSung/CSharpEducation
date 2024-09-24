using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Выберете модель автомобиля:\n" +
                        "1 - Mercedes Maybach\n" +
                        "2 - Porsche Panamera\n" +
                        "3 - Ford Focus");
      string userInput = Console.ReadLine();
      string carModel = string.Empty;
      switch (userInput)
      {
        case "1":
          carModel = "Mercedes Maybach";
          break;
        case "2":
          carModel = "Porsche Panamera";
          break;
        case "3":
          carModel = "Ford Focus";
          break;
      }
      var car = new Car(carModel);
      car.PrintInfo(car);
      Console.ReadKey();
    }
  }
}
