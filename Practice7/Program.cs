using System;
using System.Collections.Generic;

namespace Practice7
{
  internal class Program
  {
    /// <summary>
    /// Интерфесы.
    /// </summary>
    private static void Interfaces()
    {
      ListStorage<string> animalList = new ListStorage<string>();

      animalList.Add("Cat");
      animalList.Add("Dog");
      animalList.Add("Parrot");
      animalList.Add("Dinosawr");

      Console.WriteLine(animalList.Get(0));
      Console.WriteLine(animalList.Get(3));
    }

    /// <summary>
    /// IClonable.
    /// </summary>
    private static void CloneObject()
    {
      Person person1 = new Person();
      person1.Name = "Mikhail";
      person1.Age = 99;


      Person person2 = (Person)person1.Clone();
      person2.Name = "Biba";
      Console.WriteLine("Person:");
      Console.WriteLine(person1.Name);
      Console.WriteLine(person2.Name);


      Rectangle rectangle1 = new Rectangle();
      rectangle1.Width = 100;
      rectangle1.Height = 50;

      Rectangle rectangle2 = (Rectangle)rectangle1.Clone();
      rectangle2.Width = 10;

      Console.WriteLine("\nRectangle:");
      Console.WriteLine(rectangle1.Width);
      Console.WriteLine(rectangle2.Width);
    }

    /// <summary>
    /// IComparable и IComparer.
    /// </summary>
    static void ComparisonObjects()
    {
      Console.WriteLine("IComparable:");
      Book harryPotter = new Book("Гарри Поттер", "Роулинг");
      Book someBook = new Book("Гарри Поттер", "nope");
      Console.WriteLine(harryPotter.CompareTo(someBook));

      Console.WriteLine("IComparer:");
      Car lada = new Car("lada", "kalina");
      Car tesla = new Car("Tesla", "Model S");

      Console.WriteLine(lada.Compare(lada, tesla));
    }

    /// <summary>
    /// IEnumerable и IEnumerator.
    /// </summary>
    static void CollectionEnumiration()
    {
      MyList list = new MyList();

      Console.WriteLine("IEnumerable:");
      foreach (var i in list)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine("\n");

      MyDictionary dictionary = new MyDictionary();
      while (dictionary.MoveNext())
      {
        var current = (KeyValuePair<string, int>)dictionary.Current;
        Console.WriteLine($"{current.Key}: {current.Value}");
      }

      Console.WriteLine("\nЧетные числа:");
      IEnumerable<int> GetEvenNumbers(int begin, int end)
      {
        for (int i = begin; i <= end; i++)
        {
          if (i % 2 == 0)
          {
            yield return i;
          }
        }
      }

      foreach (var number in GetEvenNumbers(1, 20))
        Console.Write(number + " ");
      Console.WriteLine();
    }

    /// <summary>
    /// Индексаторы.
    /// </summary>
    static void Indexing()
    {
      Matrix matrix = new Matrix();

      Console.WriteLine("Матрица");
      for (int i = 0; i < matrix.Data.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.Data.GetLength(1); j++)
        {
          Console.Write(matrix.Data[i, j] + " ");
        }
        Console.WriteLine();
      }

      matrix[1, 3] = 5;

      Console.WriteLine("\nМеняем значение матрицы во 2 строке, в 4 столбце на 5");
      Console.WriteLine("Измененная матрица");
      for (int i = 0; i < matrix.Data.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.Data.GetLength(1); j++)
        {
          Console.Write(matrix.Data[i, j] + " ");
        }
        Console.WriteLine();
      }
    }

    /// <summary>
    /// Методы расширения.
    /// </summary>
    static void MethodExtension()
    {
      Console.WriteLine("Палиндромы:");
      string str1 = "qwerty";
      Console.WriteLine($"{str1} является палиндромом: {str1.IsPalindrome()}");

      string str2 = "qWertyytrewq";
      Console.WriteLine($"{str2} является палиндромом: {str2.IsPalindrome()}");


      Console.WriteLine("\nПреобразование строки:");
      string phrase = "hello world!";
      Console.WriteLine(phrase.ToTitleCase());
    }

    static void Main(string[] args)
    {
      //Интерфейсы
      Console.WriteLine("Задача 1");
      Interfaces();

      //IClonable
      Console.WriteLine("\nЗадача 2");
      CloneObject();

      //IComparable и IComparer
      Console.WriteLine("\nЗадача 3");
      ComparisonObjects();

      //IEnumerable и IEnumerator
      Console.WriteLine("\nЗадача 4");
      CollectionEnumiration();

      //Индексаторы
      Console.WriteLine("\nЗадача 5");
      Indexing();

      //Методы расширения
      Console.WriteLine("\nЗадача 6");
      MethodExtension();

      Console.ReadKey();
    }
  }

  /// <summary>
  /// Статический класс для реализации методов расширения.
  /// </summary>
  static class MethodExtensions
  {
    /// <summary>
    /// Проверить слова на полиндром.
    /// </summary>
    /// <param name="str">Строка.</param>
    /// <returns>True, если строка является палиндромом. Иначе - false.</returns>
    public static bool IsPalindrome(this string str)
    {
      if (str == string.Empty)
        return false;

      int index = 0;

      for (int i = str.Length - 1; i > index; i--)
      {
        if (char.ToLower(str[i]) != char.ToLower(str[index]))
          return false;
        index++;
      }
      return true;
    }

    /// <summary>
    /// Преобразовать первую букву каждого слова в верхний регистр.
    /// </summary>
    /// <param name="str">Строка.</param>
    /// <returns>Измененная строка.</returns>
    public static string ToTitleCase(this string str)
    {
      if (str == string.Empty)
        return str;

      string newStr = string.Empty;
      string[] split = str.Split(' ');

      for (int i = 0; i < split.Length; i++)
      {
        for (int j = 0; j < split[i].Length; j++)
        {
          if (j == 0)
            newStr += split[i][j].ToString().ToUpper();
          else
            newStr += split[i][j];
        }
        newStr += " ";
      }
      return newStr;
    }
  }
}
