using System;

namespace Practice3.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book("Властелин колец", "Толкин");
      Book book2 = new Book("Обломов", "Гончаров", new DateTime(1800, 05, 25));
      Book book3 = new Book("jija");
      book1.PrintBook();
      book2.PrintBook();
      book3.PrintBook();
      Console.ReadKey();
    }
  }
}
