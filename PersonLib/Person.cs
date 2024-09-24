using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get;}

    public string Info(Person person)
    {
      string name = person.Name;
      name.ToLower();
      string info;
      if (name == "володя")
      {
        info = $"имя: {name}\n" +
                $"возраст: {this.Age}\n" +
                $"должность: системный администратор\n" +
                $"зарплата: 5000$";
      }
      else if (name == "стив джобс")
      {
        info = $"имя: {name}\n" +
                $"возраст: {this.Age}\n" +
                $"должность: программист\n" +
                $"зарплата: 10000$";
      }
      else if (name == "андрей")
      {
        info = $"имя: {name}\n" +
                $"возраст: {this.Age}\n" +
                $"должность: дворник\n" +
                $"зарплата: 15000$";
      }
      else
      {
        info = "нет информации об этом человеке";
      }
      return info;
    }
    public Person(string name)
    {
      this.Name = name;
      if (name == "володя") { Age = 22; }
      else if (name == "стив джобс") { Age = 35; }
      else if (name == "андрей") { Age = 12; }
    }
  }
}
