using System;

namespace Practice7
{
  /// <summary>
  /// Книга.
  /// </summary>
  internal class Book : IComparable<Book>
  {
    #region Поля и свойства

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Автор.
    /// </summary>
    public string Author { get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Сравнить объекты.
    /// </summary>
    /// <param name="book">Книга.</param>
    /// <returns>Результат сравнения.</returns>
    public int CompareTo(Book book)
    {
      return Title.CompareTo(book.Title);
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="title">Название.</param>
    /// <param name="Author">Автор.</param>
    public Book(string title, string Author)
    {
      this.Title = title;
      this.Author = Author;
    }

    #endregion
  }
}
