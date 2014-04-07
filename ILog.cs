namespace Logging
{
	public interface ILog
	{
		/// <summary>
		/// Gets the owner.
		/// </summary>
		/// <value>The owner.</value>
		ILogger Owner { get; }

		/// <summary>
		/// Gets the type of the log.
		/// </summary>
		/// <value>The type of the log.</value>
		ILogType LogType { get; }

		/// <summary>
		/// Gets the logger.
		/// </summary>
		/// <value>The logger.</value>
		ILogger Logger { get; }

		/// <summary>
		/// Logs the specified text.
		/// </summary>
		/// <param name="text">The text.</param>
		void Log(string text);

		/// <summary>
		/// Logs the specified loggable.
		/// </summary>
		/// <param name="loggable">The loggable.</param>
		void Log(ILoggable loggable);
	}
}
