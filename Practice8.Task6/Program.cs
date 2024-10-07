using System;

namespace Practice8.Task6
{
  internal class Program
  {
    /// <summary>
    /// Отобразить сообщение.
    /// </summary>
    /// <param name="sender">Объект Product.</param>
    /// <param name="e">Событие PurchaseEventArgs.</param>
    public static void DisplayMessage(Product sender, PurchaseEventArgs e)
    {
      Console.WriteLine("Покупка:");
      Console.WriteLine(e.Message);
    }

    static void Main(string[] args)
    {
      Product graphicCards = new Product("gts 250", 200);
      graphicCards.Notify += DisplayMessage;
      graphicCards.Purchase();

      Console.WriteLine();

      Product pants = new Product("штаны", 40);
      pants.Notify += DisplayMessage;
      pants.Purchase();

      Console.ReadKey();
    }
  }
}
