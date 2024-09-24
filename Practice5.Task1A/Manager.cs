using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1A
{
  public class Manager : Employee
  {
    public override double CalculateBonus()
    {
      return Salary * 0.2;
    }
  }
}
