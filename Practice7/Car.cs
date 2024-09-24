using System.Collections.Generic;

namespace Practice7
{
  /// <summary>
  /// Автомобиль.
  /// </summary>
  internal class Car : IComparer<Car>
  {
    #region

    /// <summary>
    /// Производитель.
    /// </summary>
    public string Make { get; set; }

    /// <summary>
    /// Модель.
    /// </summary>
    public string Model { get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Сравнить автомобили по производителю.
    /// </summary>
    /// <param name="x">Объект Car.</param>
    /// <param name="y">Объект Car.</param>
    /// <returns>Результат сравнения.</returns>
    public int Compare(Car x, Car y)
    {
      return x.Make.CompareTo(y.Make);
    }

    #endregion

    public Car(string make, string model)
    {
      this.Make = make;
      this.Model = model;
    }
  }
}
