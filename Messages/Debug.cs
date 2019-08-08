namespace Penguin.Messaging.Logging.Messages
{
    /// <summary>
    /// Creates a new message for debugging
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Debug<T> : LogMessage<T>
    {
        #region Properties

        /// <summary>
        /// Will always be debug
        /// </summary>
        public override LogLevel Level => LogLevel.Debug;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a new instance of the Debug message with the specified string
        /// </summary>
        /// <param name="message">The message to include</param>
        public Debug(string message) : base(message)
        {
        }

        #endregion Constructors
    }

    /// <summary>
    /// Creates a new message for debugging
    /// </summary>
    public class Debug : LogMessage
    {
        #region Properties

        /// <summary>
        /// Will always be debug
        /// </summary>
        public override LogLevel Level => LogLevel.Debug;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a new instance of the Debug message with the specified string
        /// </summary>
        /// <param name="message">The message to include</param>
        public Debug(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}