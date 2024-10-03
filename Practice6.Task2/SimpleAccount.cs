namespace Practice6.Task2
{
  /// <summary>
  /// Банковский счет.
  /// </summary>
  internal class SimpleAccount : BankAccount
  {
    #region Методы

    /// <summary>
    /// Депозит.
    /// </summary>
    /// <param name="sum">Сумма.</param>
    public override void Deposit(int sum)
    {
      this.Check += sum;
    }

    /// <summary>
    /// Снятие.
    /// </summary>
    /// <param name="sum">Сумма.</param>
    /// <exception cref="NegativeBalanceException">Отрицательный баланс.</exception>
    /// <exception cref="InsufficientBalanceException">Недостаточно средств.</exception>
    public override void WithdrawMoney(int sum)
    {
      if (this.Check < 0)
        throw new NegativeBalanceException("На счете отрицательный баланс.");
      if (sum > this.Check)
        throw new InsufficientBalanceException("На счете недостаточно средств.");
      this.Check -= sum;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public SimpleAccount()
    {
      this.Check = 0;
    }

    #endregion
  }
}
