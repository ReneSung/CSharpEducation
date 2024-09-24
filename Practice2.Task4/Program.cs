using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task4
{
  internal class Program
  {
    static void TaskA()
    {
      Console.WriteLine("Задача a");
      Console.WriteLine("Задайте высоту треугольника");
      int number = int.Parse(Console.ReadLine());
      for (int i = 0; i < number; i++)
      {
        int counter = i;
        while (counter >= 0)
        {
          Console.Write("*");
          counter--;
        }
        Console.WriteLine();
      }
    }
    static void TaskB()
    {
      Console.WriteLine("Задача b");
      Console.WriteLine("Задайте высоту треугольника");
      int number = int.Parse(Console.ReadLine());
      for (int i = 0; i < number; i++)
      {
        int counter = i;
        


        for (int j = i; j < number - 1; j++)
        {
          Console.Write(' ');
        }
        while (counter >= 0)
        {
          Console.Write('*');
          counter--;
        }
        Console.WriteLine();
      }
    }
    static void TaskC()
    {
      Console.WriteLine("Задача c");
      Console.WriteLine("Задайте высоту треугольника");
      int number = int.Parse(Console.ReadLine());
      Console.WriteLine("Задайте символ");
      char symbol = char.Parse(Console.ReadLine());


      
      for (int i = 0; i < number; i++)
      {
        int counter = i;
        while (counter >= 0)
        {
          Console.Write(symbol);
          counter--;
        }
        Console.WriteLine();
      }



      for (int i = 0; i < number; i++)
      {
        int counter = i;



        for (int j = i; j < number - 1; j++)
        {
          Console.Write(' ');
        }
        while (counter >= 0)
        {
          Console.Write(symbol);
          counter--;
        }
        Console.WriteLine();
      }
    }
    static void Main(string[] args)
    {
      TaskA();
      TaskB();
      TaskC();
      Console.ReadKey();
    }
  }
}
