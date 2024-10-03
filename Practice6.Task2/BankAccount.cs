namespace Practice6.Task2
{
  /// <summary>
  /// Абстрактный банковский счет.
  /// </summary>
  internal abstract class BankAccount
  {
    #region Поля и свойства

    /// <summary>
    /// Счет.
    /// </summary>
    public int Check { get; protected set; }

    #endregion

    #region Методы

    /// <summary>
    /// Депозит.
    /// </summary>
    /// <param name="sum">Сумма.</param>
    public abstract void Deposit(int sum);

    /// <summary>
    /// Снятие.
    /// </summary>
    /// <param name="sum">Сумма.</param>
    public abstract void WithdrawMoney(int sum);

    #endregion
  }
}
