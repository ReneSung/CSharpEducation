using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task6A
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int a = 3;  //Катет 1
      int b = 4;  //Катет 2
      double c = Math.Sqrt(a * a + b * b); //Формула гипотенузы
      Console.WriteLine(c);
      Console.ReadKey();
    }
  }
}
