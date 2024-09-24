using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string fullName = "Иванов Иван";
      string phoneNumber = "000222111";
      Phonebook phonebook = Phonebook.getInstance();
      var abonent = new Abonent(fullName, phoneNumber);
      //phonebook.AddAbonent(abonent);
      foreach (var s in phonebook.AbonentList)
      {
        Console.WriteLine(s);
      }
      Console.ReadKey();
    }
  }
}
