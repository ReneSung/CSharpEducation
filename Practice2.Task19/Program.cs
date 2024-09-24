using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task19
{
  internal class Program
  {
    static int[] GetArray()
    {
      Random random = new Random();
      int[] array = new int[10];
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = random.Next(1, 101);
      }
      return array;
    }
    static void GetDifference(int[] array)
    {
      int minValue = array[0];
      int maxValue = array[0];
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] < minValue) { minValue = array[i]; }
        if (array[i] > maxValue) { maxValue = array[i]; }
      }


      Console.WriteLine($"Разница между числами: {maxValue - minValue}");
    }
    static void Main(string[] args)
    {
      int[] array = GetArray();
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
      GetDifference(array);
      Console.ReadKey();
    }
  }
}
