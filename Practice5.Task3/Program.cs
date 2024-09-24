using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
	internal class Program
	{
		static void PrintInfo(Animal animal)
		{
			Console.WriteLine($"Кличка: {animal.Name}");
			Console.WriteLine($"Возраст: {animal.Age}");
			if (animal is Cat)
			{
				var cat = (Cat)animal;
				cat.MakeSound();
			}
			else if (animal is Dog)
			{
				var dog = (Dog)animal;
				dog.MakeSound();
			}
			else if (animal is Parrot)
			{
				var parrot = (Parrot)animal;
				Console.WriteLine($"Цвет: {parrot.Color}");
				parrot.MakeSound();
				Console.Write("Parrot talking: ");
				parrot.MakeSound("Some text...");
			}
		}
		static void Main(string[] args)
		{
			Cat cat = new Cat("Мурка", 1);
      PrintInfo(cat);
			Console.WriteLine();


      Dog dog = new Dog("Шарик", 2);
      PrintInfo(dog);
			Console.WriteLine();


      Parrot parrot = new Parrot("Валерий", 22, "Red");
      PrintInfo(parrot);
			Console.WriteLine();
      Console.WriteLine();


      IFlyable[] birds = new IFlyable[2];
			birds[0] = parrot;
			birds[1] = new Eagle();


			Console.WriteLine("Flying birds:");
			for (int i = 0; i < birds.Length; i++)
			{
				Console.Write($"Bird {i + 1}: ");
				birds[i].Fly();
			}
      Console.ReadKey();
		}
	}
}
