using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task5
{
  internal class Program
  {
    /// <summary>
    /// Обработать событие.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    private static void TimerNotify(string message)
    {
      Console.WriteLine(message);
    }

    static void Main(string[] args)
    {
      Timer timer = new Timer();

      timer.Tick += TimerNotify;

      Console.WriteLine("Ожидание 3 секунды");
      timer.TimeDelay();
      Console.ReadKey();
    }
  }
}
