using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Calculator calculator = new Calculator();
      Console.WriteLine("Введите первое число");
      calculator.FirstNumber = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      calculator.SecondNumber = double.Parse(Console.ReadLine());
      double a = calculator.FirstNumber;
      double b = calculator.SecondNumber;
      double sum = calculator.Sum();
      double subtraction = calculator.Subtraction();
      double multiplication = calculator.Multiplication();
      double division = calculator.Division();
      Console.WriteLine($"Сумма: {sum}");
      Console.WriteLine($"Разность: {subtraction}");
      Console.WriteLine($"Умножение: {multiplication}");
      Console.WriteLine($"Деление: {Math.Round(division, 2)}");
      Console.ReadKey();
    }
  }
}
