using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice7
{
  /// <summary>
  /// Словарь.
  /// </summary>
  internal class MyDictionary : IEnumerator
  {
    #region Поля и свойства

    /// <summary>
    /// Словарь.
    /// </summary>
    public Dictionary<string, int> Items;

    /// <summary>
    /// Начальная позиция для сравнения.
    /// </summary>
    int position = -1;

    #endregion

    #region Интерфейс IEnumerator

    public object Current
    {
      get
      {
        if (position == -1 || position >= Items.Count)
          throw new IndexOutOfRangeException();
        return new List<KeyValuePair<string, int>>(Items)[position];
      }
    }

    public bool MoveNext()
    {
      if (position < Items.Count - 1)
      {
        position++;
        return true;
      }
      else
        return false;
    }

    public void Reset()
    {
      position = -1;
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public MyDictionary()
    {
      this.Items = new Dictionary<string, int>();

      Items.Add("Sam", 50);
      Items.Add("Walter", 55);
      Items.Add("Bob", 10);
    }

    #endregion
  }
}
