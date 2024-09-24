using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1A
{
  internal class Program
  {
    static void PrintPerson(Employee employee)
    {
      Console.WriteLine($"Имя: {employee.Name}\n" +
                        $"Зарплата: {employee.Salary}\n" +
                        $"Бонус к зарплате: {employee.CalculateBonus()}");
    }
    static void Main(string[] args)
    {
      var employee = new Employee();
      employee.Name = "Ivan";
      employee.Salary = 5000;
      PrintPerson(employee);
      Console.WriteLine();


      var manager = new Manager();
      manager.Name = "Bob";
      manager.Salary = 8000;
      PrintPerson(manager);
      Console.ReadKey();
    }
  }
}
