using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task20
{
  internal class Program
  {
    static int[,] GetDoubleArray()
    {
      Random random = new Random();
      int[,] array = new int[10, 10];
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = random.Next(1, 101);
        }
      }

      return array;
    }
    static void GetDifference(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        int minValue = array[i, 0];
        int maxValue = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i, j] < minValue) { minValue = array[i, j]; }
          if (array[i, j] > maxValue) { maxValue = array[i, j]; }
          Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine($"Разница чисел: {maxValue - minValue}");
      }
    }
    static void Main(string[] args)
    {
      GetDifference(GetDoubleArray());
      Console.ReadKey();
    }
  }
}
