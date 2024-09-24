using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task21
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int randomNumber = random.Next(1, 101);
      bool winner = false;

      while (!winner)
      {
        Console.WriteLine("Введите число");
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber == randomNumber)
        {
          Console.WriteLine($"Загаданное число {randomNumber},вы выиграли!");
          winner = true;
        }
        else { Console.WriteLine("Не угадали :("); }
      }
      Console.ReadKey();
    }
  }
}
