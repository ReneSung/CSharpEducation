using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task6
{
	internal class Program
	{
		//Задача a
		static void TaskA()
		{
			Console.WriteLine("Задача a");
			string str = "helloWorld";
			char symbol = 'o';
			double counter = 0;
			foreach (char c in str)
			{
				if (symbol == c) { counter++; }
			}
			double percent = (counter / str.Length) * 100;
			Console.WriteLine($"процент вхождения символа '{symbol}' в строке '{str}' = {Math.Round(percent), 2}%");
		}
		//Задача b
		static void TaskB()
		{
			Console.WriteLine("Задача b");
			Console.WriteLine("Введите строку");
			string str = Console.ReadLine();
			Console.WriteLine("Введите символ");
			char symbol = char.Parse(Console.ReadLine());
			double counter = 0;
			foreach (char c in str)
			{
				if (symbol == c) { counter++; }
			}
			double percent = (counter / str.Length) * 100;
			Console.WriteLine($"процент вхождения символа '{symbol}' в строке '{str}' = {Math.Round(percent),2}%");

		}
		//Задача c
		static void TaskC()
		{
			Console.WriteLine("Задача c");
			Console.WriteLine("Введите строку и символ через пробел");
			string str = Console.ReadLine();
			char symbol = str[str.Length - 1];
			double counter = 0;
			for (int i = 0; i < str.Length - 2; i++)
			{
				if (symbol == str[i]) { counter++; }
			}
			double percent = (counter / str.Length) * 100;
			Console.WriteLine($"процент вхождения символа '{symbol}' в строке '{str}' = {Math.Round(percent),2}%");
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
