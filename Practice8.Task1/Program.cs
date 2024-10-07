using System;
using System.Collections.Generic;

namespace Practice8.Task1
{
  internal class Program
  {
    private static int SortAscending(int x, int y)
    {
      return x.CompareTo(y);
    }

    private static int SortDescending(int x, int y)
    {
      return y.CompareTo(x);
    }

    static void Main(string[] args)
    {
      List<int> list = new List<int> { 5, 1, 9, 2, 3, 7, 6, 4, 8};

      Comparison<int> comparison;

      Console.WriteLine("1 - сортировка по возрастанию\n" +
                        "2 - сортировка по убыванию");

      string input = Console.ReadLine();

      if (input == "1")
      {
        comparison = SortAscending;
        list.Sort(comparison);
      }
      else if (input == "2")
      {
        comparison = SortDescending;
        list.Sort(comparison);
      }
      else
        Console.WriteLine("некорректный ввод");
        
      Console.WriteLine("\nСписок чисел:");

      foreach (int n in list)
        Console.Write(n + " ");

      Console.ReadKey();
    }
  }
}
