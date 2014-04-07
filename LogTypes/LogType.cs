namespace Logging.LogTypes
{
	abstract class LogType : ILogType
	{
		/// <summary>
		/// Gets a value indicating whether [local resource].
		/// </summary>
		/// <value><c>true</c> if [local resource]; otherwise, <c>false</c>.</value>
		public virtual bool LocalResource { get { return true; } }
	}
}
