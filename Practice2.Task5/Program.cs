using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите первое число");
      int firstNumber = int.Parse(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      int secondNumber = int.Parse(Console.ReadLine());


      if (firstNumber > secondNumber)
      {
        Console.WriteLine($"число {firstNumber} больше числа {secondNumber}");
      }
      else if (firstNumber < secondNumber)
      {
        Console.WriteLine($"число {secondNumber} больше числа {firstNumber}");
      }
      else { Console.WriteLine("Числа равны"); }
      Console.ReadKey();

		}
  }
}
