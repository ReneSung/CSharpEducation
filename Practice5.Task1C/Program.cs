using LogLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1C
{
  internal class Program
  {
    static void PrintPerson(Employee worker)
    {
      if (worker is Contractor)
      {
        var convertWorker = worker as Contractor;
        Console.WriteLine($"Имя: {worker.Name}\n" +
                        $"Зарплата: {worker.Salary}\n" +
                        $"Бонус к зарплате: {convertWorker.CalculateBonus()}");
      }
        
      else
        Console.WriteLine($"Имя: {worker.Name}\n" +
                        $"Зарплата: {worker.Salary}\n" +
                        $"Бонус к зарплате: {worker.CalculateBonus()}");
    }
    static void Main(string[] args)
    {
			ConsoleLogger consoleLogger = new ConsoleLogger();
			FileLogger fileLogger = new FileLogger();

			var employee = new Employee("Борис", 50000);
      PrintPerson(employee);
      consoleLogger.Info($"Создан новый объект {employee.GetType().Name}");
      fileLogger.Info($"Создан новый объект {employee.GetType().Name}");
			Console.WriteLine();

			var manager = new Manager("Иван", 100000, 6);
      PrintPerson(manager);
      
			consoleLogger.Info($"Создан новый объект {manager.GetType().Name}");
			fileLogger.Info($"Создан новый объект {manager.GetType().Name}");
			Console.WriteLine();

			var contractor = new Contractor("Василий", 50000, 120);
      PrintPerson(contractor);
			consoleLogger.Info($"Создан новый объект {contractor.GetType().Name}");
			fileLogger.Info($"Создан новый объект {contractor.GetType().Name}");

			Console.ReadKey();
    }
  }
}
