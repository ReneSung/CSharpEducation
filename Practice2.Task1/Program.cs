using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task1
{
  internal class Program
  {
    //Задача a
    static void TaskA()
    {
      Console.WriteLine("Задача a");
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }
    }
    //Задача b
    static void TaskB()
    {
      Console.WriteLine("Задача b");
      int counter = 0;
      while (counter < 10)
      {
        Console.WriteLine(counter);
        counter++;
      }
    }
    //Задача c
    static void TaskC()
    {
      Console.WriteLine("Задача c");
      int counter = 0;
      do
      {
        counter++;
        Console.WriteLine(counter);
      }
      while (counter < 10);
      {
        Console.WriteLine("end");
      };
    }
    //Задача d
    static void TaskD()
    {
      Console.WriteLine("Задача d");
      Console.WriteLine("Введите фразу");
      string word = Console.ReadLine();


      for (int i = 0; i < word.Length; i++)
      {
        Console.Write(word[i]);
      }
      Console.WriteLine();
    }
    //Задача e
    static void TaskE()
    {
      Console.WriteLine("Задача c");
      Console.WriteLine("Введите фразу");
      string word = Console.ReadLine();
      int i = 0;
      while (i < word.Length)
      {
        Console.Write(word[i]);
        i++;
      }
      Console.WriteLine();
    }
    //Задача f
    static void TaskF()
    {
      Console.WriteLine("Задача f");
      Console.WriteLine("Введите фразу");
      string word = Console.ReadLine();
      int i = 0;
      do
      {
        Console.Write(word[i]);
        i++;
      }
      while (i < word.Length - 1);
      {
        Console.WriteLine(word[i]);
      }
    }
    static void Main(string[] args)
    {
      TaskA();
      Console.WriteLine();
      TaskB();
      Console.WriteLine();
      TaskC();
      Console.WriteLine();
      TaskD();
      Console.WriteLine();
      TaskE();
      Console.WriteLine();
      TaskF();



      Console.ReadKey();
    }
  }
}
