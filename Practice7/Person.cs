namespace Practice7
{
  /// <summary>
  /// Личность.
  /// </summary>
  internal class Person
  {
    #region Поля и свойства

    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Возраст.
    /// </summary>
    public int Age { get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Клонировать объект.
    /// </summary>
    /// <returns>Объект Person.</returns>
    public object Clone()
    {
      return new Person { Name = Name, Age = Age };
    }

    #endregion
  }
}
