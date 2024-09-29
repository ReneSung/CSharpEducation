namespace Practice7
{
  /// <summary>
  /// Прямоугольник.
  /// </summary>
  internal class Rectangle
  {
    /// <summary>
    /// Ширина.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Высота.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Клонировать объект.
    /// </summary>
    /// <returns>Объект Rectangle.</returns>
    public object Clone()
    {
      return MemberwiseClone();
    }
  }
}
