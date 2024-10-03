using System;

namespace Practice6.Task2
{
  /// <summary>
  /// Исключение, недостаточно средств.
  /// </summary>
  internal class InsufficientBalanceException : Exception
  {
    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    public InsufficientBalanceException(string message)
      : base(message) { }

    #endregion
  }
}
