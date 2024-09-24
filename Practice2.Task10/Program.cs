using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task10
{
	internal class Program
	{
		static int[] GetNumberArray()
		{
			Console.WriteLine("Укажите размер массива");
			int arraySize = int.Parse(Console.ReadLine());
			int[] array = new int[arraySize];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i + 1;
			}
			return array;
		}
		static void PrintArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}
		}
		static void Main(string[] args)
		{
			PrintArray(GetNumberArray());
			Console.ReadKey();
		}
	}
}
