using System.Collections.Generic;

namespace Logging
{
	class Logger : ILogger
	{
		public int CompareTo(ILogger other)
		{
			throw new System.NotImplementedException();
		}

		public bool Equals(ILogger other)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<ILog> Logs { get; private set; }
		public TLog CreateLog<TLog>(ILogOptions<TLog> options) where TLog : class, ILog, new()
		{
			throw new System.NotImplementedException();
		}

		public void DestroyLog(ILog log)
		{
			throw new System.NotImplementedException();
		}
	}
}
