using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task6
{
  /// <summary>
  /// Событие.
  /// </summary>
  internal class PurchaseEventArgs : EventArgs
  {
    #region Поля и свойства

    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Стоимость.
    /// </summary>
    public int Coast {  get; set; }

    /// <summary>
    /// Сообщение.
    /// </summary>
    public string Message { get; set; }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    /// <param name="name">Название.</param>
    /// <param name="coast">Стоимость.</param>
    public PurchaseEventArgs(string message, string name, int coast)
    {
      this.Message = message;
      this.Name = name;
      this.Coast = coast;
    }

    #endregion
  }
}
