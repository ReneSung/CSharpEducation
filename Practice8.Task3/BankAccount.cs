using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task3
{
	/// <summary>
	/// Делегат.
	/// </summary>
	/// <param name="sum">Сумма.</param>
	public delegate void AccountTransactionDelegate(int sum);

	/// <summary>
	/// Банковский счет.
	/// </summary>
	internal class BankAccount
	{
		#region Поля и свойства

		/// <summary>
		/// Счнт.
		/// </summary>
		public int Check { get; private set; }

		#endregion

		#region Методы

		/// <summary>
		/// Депозит.
		/// </summary>
		/// <param name="sum">Сумма.</param>
		public void Deposit(int sum)
		{
			this.Check += sum;
		}

		/// <summary>
		/// Снять средства.
		/// </summary>
		/// <param name="sum">Сумма.</param>
		public void Withdraw(int sum)
		{
			this.Check -= sum;
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Конструктор.
		/// </summary>
		public BankAccount()
		{
			this.Check = 10000;
		}

		#endregion
	}
}
