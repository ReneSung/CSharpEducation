using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task14
{
  internal class Program
  {
    static int[] GetArray(int size)
    {
      int[] array = new int[size];
      return array;
    }
    static void PrintArray(int[] array)
    {
      foreach (int i in array)
      {
        Console.Write($"{i} ");
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Укажите размер массива");
      int size = int.Parse(Console.ReadLine());
      int[] array = GetArray(size);
      Random random = new Random();
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = random.Next(1, 10);
      }
      PrintArray(array);
      Console.ReadKey();
    }
  }
}
