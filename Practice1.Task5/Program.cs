using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double pi = 3.14;
      double r = 25;
      double s = pi * (r * r);
      Console.WriteLine($"S круга = {s}");
      Console.ReadKey();
    }
  }
}
