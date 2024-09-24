using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task13
{
	internal class Program
	{
		static int[,] GetMatrix(int size)
		{
			Random random = new Random();
			int[,] matrix = new int[size, size];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = random.Next(1, 10);
				}
			}
			return matrix;
		}
		static void PrintMatrix(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Задайте длину матрицы");
			int size = int.Parse(Console.ReadLine());
			PrintMatrix(GetMatrix(size));
			Console.ReadKey();
		}
	}
}
