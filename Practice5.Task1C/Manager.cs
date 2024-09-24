using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1C
{
  public class Manager : Employee
  {
    public int TeamSize { get; set; }
    public Manager(string name, int salary, int teamSize)
      : base(name, salary)
    {
      TeamSize = teamSize;
    }


    public override double CalculateBonus()
    {
      if (this.TeamSize > 5)
        return Salary * 0.25;
      else
        return Salary * 0.2;
    }
  }
}
