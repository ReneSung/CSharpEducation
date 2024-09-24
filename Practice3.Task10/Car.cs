using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task10
{
  internal class Car
  {
    public string Model {  get; set; }
    
    public void PrintInfo(Car model)
    {
      Console.WriteLine(model.Model);
      if (model.Model == "Mercedes Maybach")
      {
        Console.WriteLine(GetInfo(530, 250, "седан", "черный"));
      }
      else if (model.Model == "Porsche Panamera")
      {
        Console.WriteLine(GetInfo(440, 300, "лифтбэк", "серый"));
      }
      else if (model.Model == "Ford Focus")
      {
        Console.WriteLine(GetInfo(300, 200, "хэтчбэк", "черный"));
      }
    }
    static string GetInfo(int engine, int maxSpeed, string body, string color)
    {
      string info = $"Двигатель: {engine} л.с.\n" +
                    $"Максимальная скорость: {maxSpeed} км/ч\n" +
                    $"Кузов: {body}\n" +
                    $"Цвет: {color}";
      return info;
    }
    public Car(string model)
    {
      Model = model;
    }
  }
}
