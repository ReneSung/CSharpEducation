using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task17
{
  internal class Program
  {
    static void ReverseNumbers(int firstNumber, int secondNumber)
    {
      Console.Write($"a = {firstNumber}, b = {secondNumber} => ");
      int additionalVariable = firstNumber;
      firstNumber = secondNumber;
      secondNumber = additionalVariable;
      Console.WriteLine($"a = {firstNumber}, b = {secondNumber}");
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Введите число a");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Введите число b");
      int b = int.Parse(Console.ReadLine());
      ReverseNumbers(a, b);
      Console.ReadKey();
    }
  }
}
