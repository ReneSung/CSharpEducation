using System;
using System.IO;
using System.Threading;
using LogLib;

namespace Practice6.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ConsoleLogger consoleLogger = new ConsoleLogger();
      FileLogger fileLogger = new FileLogger();

      bool isRead = false;
      string filePath = null;

      while (!isRead)
      {
        try
        {
          if (string.IsNullOrEmpty(filePath))
          {
            Console.WriteLine("Укажите путь к файлу.");
            filePath = Console.ReadLine();
          }

          using (StreamReader sr = new StreamReader(filePath))
          {
            while (!sr.EndOfStream)
            {
              string line = sr.ReadLine();
              int.Parse(line);
              Console.WriteLine(line);
            }
            Console.WriteLine("Файл успешно прочтен.\n");

            consoleLogger.Info("file read");
            fileLogger.Info("file read");
            isRead = true;
          }
        }
        catch (ArgumentException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
          consoleLogger.Error(ex.Message);
          fileLogger.Error(ex.Message);
          Console.WriteLine("\nУкажите корректный путь к файлу");

          filePath = Console.ReadLine();
        }
        catch (UnauthorizedAccessException ex)
        {
          consoleLogger.Error(ex.Message);
          fileLogger.Error(ex.Message);

          Console.WriteLine("\nНет доступа к файлу. Укажите другой путь.");
          filePath = Console.ReadLine();
        }
        catch (FormatException ex)
        {
          consoleLogger.Error(ex.Message);
          fileLogger.Error(ex.Message);
          Console.WriteLine("Файл содержит некорректные данные.");
          Console.WriteLine("Исправьте данные файла и повторите попытку позже.");
          isRead = true;
        }
        catch (IOException ex)
        {
          consoleLogger.Error(ex.Message);
          fileLogger.Error(ex.Message);
          Console.WriteLine("Файл блокируется другой программой.");

          Console.WriteLine("1 - повторить попытку\n" +
                            "2 - выбрать другой файл");

          string userChoice = Console.ReadLine();
          if (userChoice == "1")
          {
            Console.WriteLine("Ожидание 5 секунд");
            Thread.Sleep(5000);
          }
          else if (userChoice == "2")
          {
            Console.WriteLine("Укажите повторно путь к файлу");
            filePath = Console.ReadLine();
          }
        }
      }
      Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
      Console.ReadKey();
    }
  }
}
