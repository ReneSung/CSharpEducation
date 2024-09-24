using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Point point = new Point();
      Console.WriteLine("Введите точку X");
      int pointX = int.Parse(Console.ReadLine());
      Console.WriteLine("Введите точку Y");
      int pointY = int.Parse(Console.ReadLine());
      point.X = pointX;
      point.Y = pointY;
      Console.WriteLine($"Расстояние между точками: { point.Distance()}");
      Console.ReadKey();
    }
  }
}
