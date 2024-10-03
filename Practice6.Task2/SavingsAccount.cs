namespace Practice6.Task2
{
  /// <summary>
  /// Накопительный счет.
  /// </summary>
  internal class SavingsAccount : BankAccount
  {
    #region Поля и свойства

    /// <summary>
    /// Доступ для снятия средств.
    /// </summary>
    private bool withdrawAccess = true;

    #endregion

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
    /// <exception cref="WithdrawalLimitExceededException">Лимит на снятие.</exception>
    /// <exception cref="NegativeBalanceException">Отрицательный баланс на счете.</exception>
    /// <exception cref="InsufficientBalanceException">Недостаточно средств для снятия.</exception>
    public override void WithdrawMoney(int sum)
    {
      if (!withdrawAccess)
        throw new WithdrawalLimitExceededException("Превышен лимит на снятие средств.");
      if (this.Check < 0)
        throw new NegativeBalanceException("На счете отрицательный баланс.");
      if (sum > this.Check)
        throw new InsufficientBalanceException("На счете недостаточно средств.");
      this.Check -= sum;
      this.withdrawAccess = false;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public SavingsAccount()
    {
      this.Check = 0;
    }

    #endregion
  }
}
