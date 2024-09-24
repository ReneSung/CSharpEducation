using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task18
{
  internal class Program
  {
    static int[] ClearArray(int[] array, out int counter)
    {
      counter = 0;
      for(int i = 0; i < array.Length; i++)
      {
        if (array[i] < 0) { counter++; }
      }


      int[] newArray = new int[array.Length - counter];
      int index = 0;
      for(int i = 0; i < array.Length; i++)
      {
        if (array[i] >= 0)
        {
          newArray[index] = array[i];
          index++;
        }
      }
      return newArray;
    }
    static void PrintArray(int[] array)
    {
      foreach(int i in array)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();
    }
    static void Main(string[] args)
    {
      int counter = 0;
      int[] array = new int[10];
      Random random = new Random();
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = random.Next(-10, 10);
      }


      Console.WriteLine("Исходный массив");
			PrintArray(array);
      Console.WriteLine("Новый массив");
      PrintArray(ClearArray(array, out counter));
      Console.WriteLine($"Количество удаленных символов: {counter}");
      Console.ReadKey();
    }
  }
}
