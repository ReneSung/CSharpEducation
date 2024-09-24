using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
	public class Dog : Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("Woof!");
		}

		public Dog(string name, int age) :
			base(name, age)
		{
			Console.WriteLine("Объект 'Dog' создан");
		}
	}
}
