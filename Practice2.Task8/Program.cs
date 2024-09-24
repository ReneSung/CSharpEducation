using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите первое число");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите третье число");
			int c = int.Parse(Console.ReadLine());


			if (a == b || a == c || b == c)
			{
				a += 5;
				b += 5;
				c += 5;
			}

			Console.WriteLine($"{a}, {b}, {c}");
			Console.ReadKey();
		}
	}
}
