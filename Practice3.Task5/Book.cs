using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
  internal class Book
  {
    private string title;
    private string author;
    private DateTime dateOfPublication;
    public string Title
    {
      get
      {
        return title;
      }
      set
      {
        title = value;
      }
    }
    public string Author
    {
      get
      {
        return author;
      }
      set
      {
        author = value;
      }
    }
    public DateTime DateOfPublication
    {
      get
      {
        return dateOfPublication;
      }
      set
      {
        dateOfPublication = value;
      }
    }
    public void PrintBook()
    {
      Console.WriteLine($"Название: {this.title}\n" +
                        $"Автор: {this.author}\n" +
                        $"Дата публикации: {this.dateOfPublication}\n");
    }
    public Book(string title) : this(title, "Неизвестно", DateTime.Now) { }
    public Book(string title, string author) : this(title, author, DateTime.Now) { }
    public Book(string title, string author, DateTime dateOfPublication)
    {
      this.Title = title;
      this.Author = author;
      this.DateOfPublication = dateOfPublication;
    }
  }
}
