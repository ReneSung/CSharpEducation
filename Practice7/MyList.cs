using System.Collections;
using System.Collections.Generic;

namespace Practice7
{
  /// <summary>
  /// Список чисел.
  /// </summary>
  internal class MyList : IEnumerable
  {
    #region Поля и свойства

    /// <summary>
    /// Коллекция.
    /// </summary>
    public List<int> Items;

    #endregion

    #region Интерфейс IEnumerable

    public IEnumerator GetEnumerator()
    {
      return Items.GetEnumerator();
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public MyList()
    {
      Items = new List<int>();
      for (int i = 0; i < 10; i++)
      {
        Items.Add(i + 1);
      }
    }

    #endregion
  }
}
