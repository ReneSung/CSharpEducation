using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task4
{
  internal class Book
  {
    public string Title {  get; set; }
    public string Author {  get; set; }
    public Book(string title, string author)
    {
      this.Title = title;
      this.Author = author;
    }
    public Book()
    {
      this.Title = "Ноунейм";
      this.Author = "Неизвестно";
    }
    public void PrintInfo()
    {
      Console.WriteLine($"Книга: {this.Title}\n" +
                    $"Автор: {this.Author}");
    }
  }
}
