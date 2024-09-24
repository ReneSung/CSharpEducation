using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task3
{
  internal class Calculator
  {
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }


    public double Sum()
    {
      double sum = this.FirstNumber + this.SecondNumber;
      return sum;
    }
    public double Subtraction()
    {
      double subtraction = this.FirstNumber - this.SecondNumber;
      return subtraction;
    }
    public double Multiplication()
    {
      double multiplication = this.FirstNumber * this.SecondNumber;
      return multiplication;
    }
    public double Division()
    {
      double division = this.FirstNumber / this.SecondNumber;
      return division;
    }
  }
}
