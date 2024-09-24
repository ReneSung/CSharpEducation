using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task15
{
  internal class Program
  {
    static int[] InvertArray(int[] array)
    {
      int[] invertArray = new int[array.Length];
      int index = 0;
      for (int i = invertArray.Length - 1; i >= 0; i--)
      {
        invertArray[index] = array[i];
        index++;
      }
      return invertArray;
    }
    static void PrintArray(int[] array)
    {
      foreach (int i in array)
      {
        Console.Write(i);
      }
      Console.WriteLine();
    }
    static void Main(string[] args)
    {
      int[] array = { 1, 2, 3, 4, 5, };
      Console.WriteLine("Начальный массив");
      PrintArray(array);
      Console.WriteLine("Инвретированный массив");
      PrintArray(InvertArray(array));
      Console.ReadKey();
    }
  }
}
