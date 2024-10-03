using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task2
{
  /// <summary>
  /// Исклоючение, превышен лимит на снятие средств.
  /// </summary>
  internal class WithdrawalLimitExceededException : Exception
  {
    #region Конструкторы.

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    public WithdrawalLimitExceededException(string message)
      : base(message) { }

    #endregion
  }
}
