using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1C
{
  public class Contractor : Employee
  {
    public int HourlyRate { get; set; }
    public Contractor(string name, int salary, int hourlyRate)
      : base(name, salary)
    {
      this.HourlyRate = hourlyRate;
    }
    
    public new double CalculateBonus()
    {
      if (this.HourlyRate > 100)
        return Salary * 0.3;
      else
        return Salary * 0.1;
    }
  }
}
