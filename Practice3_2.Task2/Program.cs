using System;
using MathHelper;

namespace Practice3_2.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите первое число");
      double firstNumber = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      double secondNumber = double.Parse(Console.ReadLine());

      MathHelperClass move = new MathHelperClass(firstNumber, secondNumber);
      Console.WriteLine($"{firstNumber} * {secondNumber} = {move.Multiplication()}"); 
      Console.WriteLine($"{firstNumber} / {secondNumber} = {move.Division()}");
      Console.WriteLine($"{firstNumber} + {secondNumber} = {move.Summary()}");
      Console.WriteLine($"{firstNumber} - {secondNumber} = {move.Substraction()}");
      Console.ReadKey();
    }
  }
}
