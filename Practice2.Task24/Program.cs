using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task24
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
			for (int i = 0; i < Enum.GetNames(typeof(DayOfWeek)).Length; i++)
			{
				Console.WriteLine((DayOfWeek)i+1);
			}
			Console.ReadKey();
		}
	}
}
