using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task11
{
	internal class Program
	{
		static int[] GetArray(int size, int number)
		{
			int[] array = new int[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = number;
			}
			return array;
		}
		static void PrintArray(int[] array)
		{
			foreach (int i in array)
			{
				Console.WriteLine(i);
			}
		}
		static string[] SplitString(string str)
		{
			string[] split = str.Split();
			return split;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Укажите размер массива и число через пробел");
			string inputValue = Console.ReadLine();
			

			int firstValue = int.Parse(SplitString(inputValue)[0]);
			int secondValue = int.Parse(SplitString(inputValue)[1]);
			PrintArray(GetArray(firstValue, secondValue));
			Console.ReadKey();
		}
	}
}
