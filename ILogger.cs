using System;
using System.Collections.Generic;

namespace Logging
{
	public interface ILogger : IComparable<ILogger>, IEquatable<ILogger>
	{
		/// <summary>
		/// Gets the logs.
		/// </summary>
		/// <value>The logs.</value>
		IEnumerable<ILog> Logs { get; }

		/// <summary>
		/// Creates the log.
		/// </summary>
		/// <typeparam name="TLog">The type of the t log.</typeparam>
		/// <param name="options">The options.</param>
		/// <returns>TLog.</returns>
		TLog CreateLog<TLog>(ILogOptions<TLog> options) where TLog : class, ILog, new();

		/// <summary>
		/// Destroys the log.
		/// </summary>
		/// <param name="log">The log.</param>
		void DestroyLog(ILog log);
	}
}
