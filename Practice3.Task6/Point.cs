using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task6
{
  public struct Point
  {
    public int X {  get; set; }
    public int Y { get; set; }
    public int Distance()
    {
      int distance = 0;
      if (this.X > this.Y) { distance = this.X - this.Y; }
      else if (this.X < this.Y) { distance = this.Y - this.X; }
      return distance;
    }
  }
}
