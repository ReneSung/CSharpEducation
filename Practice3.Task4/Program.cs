using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book()
      {
        Title = "kek wait"
      };
      Book book2 = new Book()
      {
        Title = "Метро 2033",
        Author = "Глуховский"
      };


      book1.PrintInfo();
      Console.WriteLine();
      book2.PrintInfo();
      Console.ReadKey();
    }
  }
}
