using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task6
{
  /// <summary>
  /// Продукт.
  /// </summary>
  internal class Product
  {
    #region Делегаты и события

    /// <summary>
    /// Делегат.
    /// </summary>
    /// <param name="sendler">Объект Product.</param>
    /// <param name="args">Обработчик событий PurchaseEventArgs</param>
    public delegate void PurchaseCompleted(Product sendler, PurchaseEventArgs args);

    /// <summary>
    /// Событие.
    /// </summary>
    public event PurchaseCompleted Notify;

    #endregion

    #region Поля и свойства

    /// <summary>
    /// Название.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Стоимость.
    /// </summary>
    public int Coast { get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Купить
    /// </summary>
    public void Purchase()
    {
      Notify?.Invoke(this, new PurchaseEventArgs($"{this.Name} - ${this.Coast}", this.Name, this.Coast));
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="name">Название.</param>
    /// <param name="coast">Стоимость</param>
    public Product(string name, int coast)
    {
      this.Name = name;
      this.Coast = coast;
    }

    #endregion
  }
}
