using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
	public class ConsoleLogger : ILogger
	{
		public void Debug(string message)
		{
			Log(message, LogLevel.Debug);
		}

		public void Error(string message)
		{
			Log(message, LogLevel.Error);
		}

		public void Fatal(string message)
		{
			Log(message, LogLevel.Fatal);
		}

		public void Info(string message)
		{
			Log(message, LogLevel.Info);
		}

		public void Trace(string message)
		{
			Log(message, LogLevel.Trace);
		}

		public void Warning(string message)
		{
			Log(message, LogLevel.Warning);
		}

		public void Log(string message, LogLevel logLevel)
		{
			Console.WriteLine($"{DateTime.Now} | {GetType().Name} | {logLevel} | {message}");
		}
	}
}
