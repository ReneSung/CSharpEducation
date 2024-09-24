using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1B
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
      var employee = new Employee("Уолтер", 50000);
      var manager = new Manager("Джесси", 100000, 10);
      var manager2 = new Manager("Сол Гудман", 100000, 2);

      Console.WriteLine("Сотрудник");
      PrintPerson(employee);
      Console.WriteLine();
      Console.WriteLine("Менеджер");
      PrintPerson(manager);
      Console.WriteLine();
      Console.WriteLine("Менеджер 2");
      PrintPerson(manager2);
      Console.ReadKey();
    }
  }
}
