using System;

namespace Practice6.Task3
{
  /// <summary>
  /// Исключение, превышение лимита попыток ввода.
  /// </summary>
  internal class TooManyAttemptsException : Exception
  {
    #region Конструктор

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    public TooManyAttemptsException(string message)
      : base(message) { }

    #endregion
  }
}
