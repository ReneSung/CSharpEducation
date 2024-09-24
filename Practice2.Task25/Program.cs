using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task25
{
	internal class Program
	{
		enum DayOfWeek
		{
			Monday = 1,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Укажите номер дня недели");
			int number = int.Parse(Console.ReadLine());
			Console.Write((DayOfWeek)number);
			Console.ReadKey();
		}
	}
}
