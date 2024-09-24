using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите свое имя");
      string inputName = Console.ReadLine();
      Console.WriteLine($"Hello, {inputName}!!");
      Console.ReadKey();
    }
  }
}
