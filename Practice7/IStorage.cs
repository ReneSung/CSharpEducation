namespace Practice7
{
  /// <summary>
  /// Хранилище.
  /// </summary>
  /// <typeparam name="T">Тип объекта.</typeparam>
  internal interface IStorage<T>
  {
    #region Поля и свойства

    /// <summary>
    /// Количество элементов.
    /// </summary>
    int Count { get; }

    #endregion

    #region Методы

    /// <summary>
    /// Добавить элемент в хранилище.
    /// </summary>
    /// <param name="item">Элемент.</param>
    void Add(T item);

    /// <summary>
    /// Получить элемент по индексу.
    /// </summary>
    /// <param name="index"></param>
    /// <returns>Полученный элемент.</returns>
    T Get(int index);

    #endregion
  }
}
