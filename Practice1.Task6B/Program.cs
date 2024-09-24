using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task6B
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double c = 9;   //Гипотенуза
      double a = 6;   //Катет
      double b = Math.Sqrt(c * c - a * a);    //Неизвестный катет
      Console.WriteLine(Math.Round(b, 2));
      Console.ReadKey();
    }
  }
}
