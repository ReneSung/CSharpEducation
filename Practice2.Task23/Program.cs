using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ввведите год");
			int year = int.Parse(Console.ReadLine());
			if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)) { Console.WriteLine($"{year} год - високосный"); }
			else { Console.WriteLine($"{year} год - не является високосным."); }
			Console.ReadKey();
		}
	}
}
