using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BankAccount account = new BankAccount();
			AccountTransactionDelegate accountTransactionDelegate;

			Console.WriteLine($"На счете ${account.Check}");

			Console.WriteLine("1 - депозит\n" +
												"2 - снять наличные");

			string input = Console.ReadLine();
			string sum = string.Empty;

			if (input == "1")
			{
				accountTransactionDelegate = account.Deposit;
				Console.WriteLine("Введите сумму депозита.");
				sum = Console.ReadLine();
				accountTransactionDelegate(int.Parse(sum));
			}
			else if (input == "2")
			{
				accountTransactionDelegate = account.Withdraw;
				Console.WriteLine("Введите сумму для снятия.");
				sum = Console.ReadLine();
				accountTransactionDelegate(int.Parse(sum));
			}

			Console.WriteLine($"На счете ${account.Check}");

			Console.ReadKey();
		}
	}
}
