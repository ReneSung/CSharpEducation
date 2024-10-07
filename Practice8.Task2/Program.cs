using System;
using System.Collections.Generic;

namespace Practice8.Task2
{
  internal class Program
  {
    private static bool FilterNameLength(string person)
    {
      return person.Length == 3;
    }

    static void Main(string[] args)
    {
      List<string> persons = new List<string>() { "bob", "tom", "sam", "steve", "walter"};

      Predicate<string> predicate;
      predicate = FilterNameLength;
      
      persons = persons.FindAll(predicate);

      foreach (string p in persons)
        Console.WriteLine(p);

      Console.ReadKey();
    }
  }
}
