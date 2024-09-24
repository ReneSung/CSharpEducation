using System;

namespace Practice7
{
  /// <summary>
  /// Матрица.
  /// </summary>
  internal class Matrix
  {
    #region Поля и свойства

    /// <summary>
    /// Матрица.
    /// </summary>
    public int[,] Data;

    /// <summary>
    /// Получить значение матрицы по строке и столбцу.
    /// </summary>
    /// <param name="row">Строка.</param>
    /// <param name="column">Столбец.</param>
    /// <returns>Значнеие по адресу.</returns>
    /// <exception cref="IndexOutOfRangeException">Индекс вне границ массива.</exception>
    public int this[int row, int column]
    {
      get
      {
        if (row >= 0 && row < Data.GetLength(0))
          return Data[row, column];
        else
          throw new IndexOutOfRangeException();
      }
      set
      {
        if (row >= 0 && row < Data.GetLength(0))
          Data[row, column] = value;
      }
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public Matrix()
    {
      Data = new int[5, 5];
    }

    #endregion
  }
}
