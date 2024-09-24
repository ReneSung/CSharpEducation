using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
	public class FileLogger
	{
		private const string path = "log.txt";
		private void WriteToFile(string message)
		{
			using (StreamWriter writer = new StreamWriter(path, true))
			{
				writer.WriteLine(message);
			}
		}

		public void Log(string message, LogLevel logLevel)
		{
			string logMessage = $"{DateTime.Now} | {this.GetType().Name} | {logLevel} | {message}";
			WriteToFile(logMessage);
		}

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
	}
}
