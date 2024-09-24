using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task22
{
  internal class Program
  {
    static void TaskA()
    {
      int attemptsNumer = 10;
      Random random = new Random();
      int randomNumber = random.Next(1, 101);
      while (attemptsNumer > 0)
      {
        Console.WriteLine($"Осталось попыток: {attemptsNumer}");
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber == randomNumber) { break; }
				attemptsNumer--;
        Console.WriteLine("Не угадали, попробуйте еще раз.");
      }
      if (attemptsNumer > 0)
      {
        Console.WriteLine($"Вы выиграли, загаданное число: {randomNumber}");
      }
      else { Console.WriteLine("Вы проиграли :("); }
    }
    static void TaskB()
    {
			int attemptsNumber = 10;
			Random random = new Random();
			int randomNumber = random.Next(1, 101);
      Console.WriteLine(randomNumber);
			while (attemptsNumber > 0)
			{
				Console.WriteLine($"Осталось попыток: {attemptsNumber}");
				int inputNumber = int.Parse(Console.ReadLine());
				if (inputNumber == randomNumber) { break; }
				attemptsNumber--;
        if (inputNumber > randomNumber) { Console.WriteLine($"Не угадали, ваше число больше загаданного."); }
        else if (inputNumber < randomNumber) { Console.WriteLine($"Не угадали, ваше число меньше загаданного."); }
				Console.WriteLine("Попробуйте еще раз.");
			}
			if (attemptsNumber > 0)
			{
				Console.WriteLine($"Вы выиграли, загаданное число: {randomNumber}.\n" +
          $"Вам понадобилось {11 - attemptsNumber} попыток");
			}
			else { Console.WriteLine("Вы проиграли :("); }
		}
    static void Main(string[] args)
    {
      Console.WriteLine("Задача а");
      TaskA();
			Console.WriteLine("Задача b");
			TaskB();
      Console.ReadKey();
    }
  }
}
