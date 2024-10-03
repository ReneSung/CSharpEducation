using System;
using LogLib;

namespace Practice6.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ConsoleLogger consoleLogger = new ConsoleLogger();
      FileLogger fileLogger = new FileLogger();

      int inputAttempt = 0;

      try
      {
        while (true)
        {
          int? age = null;

          Console.WriteLine("Введите возраст");

          try
          {
            int inputAge = int.Parse(Console.ReadLine());
            age = inputAge;
          }
          catch (FormatException ex)
          {
            Console.WriteLine("Введено некорректное значение");
            consoleLogger.Warning(ex.Message);
            fileLogger.Warning(ex.Message);
          }

          if (age != null)
          {
            if (age >= 18)
            {
              Console.WriteLine($"Тебе {age} лет");

              consoleLogger.Info($"value: {age}");
              fileLogger.Info($"value {age}");

              break;
            }
          }

          if (age < 0)
            throw new ArgumentException("Не бывает людей с отрицательным ввозрастом.");
          if (age < 18)
            throw new ArgumentException("Несовершеннолетний.");
          else if (inputAttempt == 4)
            throw new TooManyAttemptsException("Превышен лимит попыток ввода.");

          inputAttempt++;
          Console.WriteLine();
        }
      }
      catch (TooManyAttemptsException ex)
      {
        Console.WriteLine(ex.Message);
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      Console.WriteLine("\nПАКА");
      Console.WriteLine("Нажмите любую клавишу, чтобы продолжить.");
      Console.ReadKey();
    }
  }
}
