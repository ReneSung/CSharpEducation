using System.Collections.Generic;

namespace Practice7
{
  /// <summary>
  /// Коллекция элементов.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  internal class ListStorage<T> : IStorage<T>
  {
    #region Поля и свойства

    /// <summary>
    /// Коллекция.
    /// </summary>
    public List<T> Storage { get; set; }

    #endregion

    #region Интерфейс IStorage

    public int Count
    {
      get
      {
        return Storage.Count;
      }
    }

    public void Add(T item)
    {
      Storage.Add(item);
    }

    public T Get(int index)
    {
      return (T)Storage[index];
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public ListStorage()
    {
      Storage = new List<T>();
    }

    #endregion
  }
}
