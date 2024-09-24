using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task8
{
  internal class Rectangle
  {
    public double Width {  get; set; }
    public double Height { get; set; }
    public void GetSquare()
    {
      double s = this.Width * this.Height;
      Console.WriteLine($"Площадь треугольника равна {s}");
    }
    public Rectangle(double width, double height)
    {
      this.Width = width;
      this.Height = height;
    }
  }
}
