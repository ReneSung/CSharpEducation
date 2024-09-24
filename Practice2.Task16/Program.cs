using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task16
{
  internal class Program
  {
    static void NegativeNumber(ref int number)
    {
      if (number > 0) { number = number * -1; }
      
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Введите число");
      int number = int.Parse(Console.ReadLine());
      Console.WriteLine($"Ваше число: {number}");
      NegativeNumber(ref number);
      Console.WriteLine($"Отрицательное число число: {number}");
      Console.ReadKey();
    }
  }
}
