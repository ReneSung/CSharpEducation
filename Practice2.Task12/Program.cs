using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task12
{
	internal class Program
	{
		static string[] GetArray(int size)
		{
			string[] array = new string[size];
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("Введите строку");
				array[i] = Console.ReadLine();
			}
			return array;
		}
		static void PrintArray(string[] array)
		{
			foreach (string s in array)
			{
				Console.WriteLine(s);
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Укажите размер массива");
			int size = int.Parse(Console.ReadLine());
			PrintArray(GetArray(size));
			Console.ReadKey();
		}
	}
}
