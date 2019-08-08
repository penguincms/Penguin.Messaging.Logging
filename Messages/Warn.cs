namespace Penguin.Messaging.Logging.Messages
{
    /// <summary>
    /// Something has gone wrong but we can recover from it
    /// </summary>
    /// <typeparam name="T">The type of the system involved</typeparam>
    public class Warn<T> : LogMessage<T>
    {
        #region Properties

        /// <summary>
        /// Will always be Warning
        /// </summary>
        public override LogLevel Level => LogLevel.Warning;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Create a new warning with the specified message string
        /// </summary>
        /// <param name="message">The message string</param>
        public Warn(string message) : base(message)
        {
        }

        #endregion Constructors
    }

    /// <summary>
    /// Something has gone wrong but we can recover from it
    /// </summary>
    public class Warn : LogMessage
    {
        #region Properties

        /// <summary>
        /// Will always be Warning
        /// </summary>
        public override LogLevel Level => LogLevel.Warning;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Create a new warning with the specified message string
        /// </summary>
        /// <param name="message">The message string</param>
        public Warn(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}