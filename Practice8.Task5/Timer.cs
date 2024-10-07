using System;
using System.Threading;

namespace Practice8.Task5
{
  /// <summary>
  /// Таймер.
  /// </summary>
  internal class Timer
  {
    /// <summary>
    /// Событие.
    /// </summary>
    public event Action<string> Tick;

    /// <summary>
    /// Ожидать.
    /// </summary>
    public void TimeDelay()
    {
      Thread.Sleep(3000);
      Tick.Invoke("прошло 3 секунды");
    }
  }
}
