using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
  public class MathHelperClass
  {
    public double FirstNumber { get; set; }
    public double SecondNumber {  get; set; }

    public double Multiplication()
    {
      double result = this.FirstNumber * this.SecondNumber;
      return result;
    }
    public double Division()
    {
      double result = this.FirstNumber / this.SecondNumber;
      return Math.Round(result, 2);
    }
    public double Summary()
    {
      double result = this.FirstNumber + this.SecondNumber;
      return result;
    }
    public double Substraction()
    {
      double result = this.FirstNumber - this.SecondNumber;
      return result ;
    }
    public MathHelperClass(double firstNumber, double secondNumber)
    {
      this.FirstNumber = firstNumber;
      this.SecondNumber = secondNumber;
    }
  }
}
