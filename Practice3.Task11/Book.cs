using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task11
{
  internal class Book
  {
    public string Title { get; set; }
    public string Author { get; }
    static string GetInfo(Book book)
    {
      string info = string.Empty;
      switch (book.Title)
      {
        case "Первая научная история войны 1812 года":
          info = "Первая научная история войны 1812 года — " +
            "монография российского писателя и публициста\n" +
            "Евгения Николаевича Понасенкова об Отечественной войне 1812 года.";
          break;
        case "На Западном фронте без перемен":
          info = "На Западном фронте без перемен - " +
            "роман Эриха Марии Ремарка,\n" +
            "опубликованный в газетном варианте в 1928 году,\n" +
            "а отдельной книгой в 1929 году.";
          break;
        case "Капитанская дочка":
          info = "Капитанская дочка» — исторический роман Александра Пушкина,\n" +
                  "действие которого происходит во время восстания Емельяна Пугачёва.";
          break;
      }
      return info;
    }
    public void PrintInfo(Book book)
    {
      Console.WriteLine($"Книга: {book.Title}\n" +
                        $"Автор: {book.Author}\n" +
                        $"Описание:\n" +
                        $"{GetInfo(book)}");
    }
    public Book(string title)
    {
      this.Title = title;
      if (Title == "Первая научная история войны 1812 года") { Author = "Евгений Понасенков"; }
      else if (Title == "На Западном фронте без перемен") { Author = "Эрих Мария Ремарк"; }
      else if (Title == "Капитанская дочка") { Author = "Александр пушкин"; }
    }
  }
}
