using System;
using System.Collections.Generic;
namespace Practice8.Task4
{
  internal class Program
  {
    /// <summary>
    /// Преобразовать строку.
    /// </summary>
    /// <param name="word">строка</param>
    /// <returns>Строка в верхнем регистре.</returns>
    private static string ToUpperCase(string word) => word.ToUpper();

    /// <summary>
    /// Изменить коллекцию.
    /// </summary>
    /// <param name="list">Коллекция.</param>
    /// <param name="changeWord">Метод для изменения.</param>
    /// <returns>Измененная коллекция.</returns>
    private static List<string> ModifyList(List<string> list, Func<string, string> changeWord)
    {
      List<string> changeList = new List<string>();

      foreach(string s in list)
        changeList.Add(changeWord(s));

      return changeList;
    }

    static void Main(string[] args)
    {
      
      List<string> companiesList = new List<string>() { "Microsoft", "Apple", "Google", "Dell", "IBM" };

      Console.WriteLine("Список");
      foreach (string s in companiesList)
        Console.WriteLine(s);

      Func<string, string> changeWord = ToUpperCase;

      List<string> modifyedList = ModifyList(companiesList, changeWord);

      Console.WriteLine("\nИзмененный список");
      foreach(string s in modifyedList)
        Console.WriteLine(s);

      Console.ReadKey();
    }
  }
}
