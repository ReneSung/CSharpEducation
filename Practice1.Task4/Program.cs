using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите фразу 1");
      string phrase1 = Console.ReadLine();
      Console.WriteLine("Введите фразу 2");
      string phrase2 = Console.ReadLine();


      Console.WriteLine($"{phrase1} {phrase2}");
      Console.ReadKey();
    }
  }
}
