using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task7
{
	internal class Program
	{
		//Задача a
		static void TaskA()
		{
			Console.WriteLine("Задача a");
			string str = "hello world";
			Console.WriteLine(str.ToUpper());
		}
		//Задача b
		static void TaskB()
		{
			Console.WriteLine("Задача b");
			string str = "HeLLO wORLd";
			Console.WriteLine(str.ToLower());
		}
		//Задача c
		static void TaskC()
		{
			Console.WriteLine("Задача c");
			string str = "привет";
			string newStr = string.Empty;
			newStr += char.ToUpper(str[0]);
			for (int i = 1; i < str.Length; i++)
			{
				newStr += str[i];
			}
			Console.WriteLine($"Изначальное слово: {str}");
			Console.WriteLine($"Измененное слово: {newStr}");
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
