using System;

namespace Practice6.Task2
{
  /// <summary>
  /// Исключение, отрицательный баланс.
  /// </summary>
  internal class NegativeBalanceException : Exception
  {
    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    public NegativeBalanceException(string message)
      : base(message) { }

    #endregion
  }
}
