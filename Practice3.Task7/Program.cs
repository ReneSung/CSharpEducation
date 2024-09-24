using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task7
{
  internal class Program
  {
    enum Month
    {
      January = 31,
      February = 29,
      March = 31,
      April = 30,
      May = 31,
      June = 30,
      July = 31,
      August = 31,
      September = 30,
      October = 31,
      November = 30,
      December = 31
    }
    static int GetMonthDays(string month)
    {
      int days = 0;
      //month.ToLower();
      switch (month)
      {
        case "январь":
          days = (int)Month.January;
          break;
        case "февраль":
          days = (int)Month.February;
          break;
        case "march":
          days = (int)Month.March;
          break;
        case "апрель":
          days = (int)Month.April;
          break;
        case "май":
          days = (int)Month.May;
          break;
        case "июнь":
          days = (int)Month.June;
          break;
        case "июль":
          days = (int)Month.July;
          break;
        case "август":
          days = (int)Month.August;
          break;
        case "сентябрь":
          days = (int)Month.September;
          break;
        case "октябрь":
          days = (int)Month.October;
          break;
        case "ноябрь":
          days = (int)Month.November;
          break;
        case "декабрь":
          days = (int)Month.December;
          break;
      }
      return days;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Введите время года");
      string inputMonth = Console.ReadLine();
      if (GetMonthDays(inputMonth) == 0) { Console.WriteLine("Не существует такого месяца"); }
      else
      {
        Console.WriteLine($"{inputMonth} - {GetMonthDays(inputMonth)} дней");
      }
      Console.WriteLine(inputMonth);
      
      Console.ReadKey();
    }
  }
}
