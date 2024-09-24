using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1A
{
  public class Employee
  {
    public string Name { get; set; }
    public int Salary { get; set; }
    public virtual double CalculateBonus()
    {
      return Salary * 0.1;
    }
  }
}
