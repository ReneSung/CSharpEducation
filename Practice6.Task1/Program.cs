using System;
using System.IO;
using LogLib;

namespace Practice6.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string path = "numbers.txt";
      double[] num = new double[2];

      ConsoleLogger consoleLogger = new ConsoleLogger();
      FileLogger fileLogger = new FileLogger();

      try
      {
        using (StreamReader sr = new StreamReader(path))
        {
          string line = sr.ReadLine();

          if (line == null)
            throw new IOException("Передан пустой файл.");

          string[] split = line.Split(' ');

          num[0] = double.Parse(split[0]);
          num[1] = double.Parse(split[1]);
        }

        if (num[1] == 0)
          throw new ArgumentException("Деление на ноль.");

        double result = num[0] / num[1];

        consoleLogger.Info(result.ToString());
        fileLogger.Info(result.ToString());
      }
      catch (FileNotFoundException ex)
      {
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      catch (ArgumentException ex)
      {
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      catch (IOException ex)
      {
        consoleLogger.Error(ex.Message);
        fileLogger.Error(ex.Message);
      }
      catch (Exception)
      {
        consoleLogger.Error("В файле должны быть указаны 2 числа через пробел.");
        fileLogger.Error("В файле должны быть указаны 2 числа через пробел.");
      }
      Console.ReadKey();
    }
  }
}
