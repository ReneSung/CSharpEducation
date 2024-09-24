using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;

namespace Practice3_2.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Выберете персонажа, о котором хотите узнать подробности:\n" +
                        "володя, стив джобс или андрей");
      //string inputName = Console.ReadLine();
      string inputName = "стив джобс";
      var person = new Person(inputName);
      Console.WriteLine(person.Info(person));
      Console.ReadKey();
    }
  }
}
