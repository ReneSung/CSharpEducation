using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task11
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Выбебере книгу\n" +
                        "1 - Первая научная история войны 1812 года\n" +
                        "2 - На Западном фронте без перемен\n" +
                        "3 - Капитанская дочка");
      string userInput = Console.ReadLine();
      string bookTitle = string.Empty;
      switch (userInput)
      {
        case "1":
          bookTitle = "Первая научная история войны 1812 года";
          break;
        case "2":
          bookTitle = "На Западном фронте без перемен";
          break;
        case "3":
          bookTitle = "Капитанская дочка";
          break;
      }
      var book = new Book(bookTitle);
      book.Title = bookTitle;
      book.PrintInfo(book);
      Console.ReadKey();
    }
  }
}
