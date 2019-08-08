namespace Penguin.Messaging.Logging.Messages
{
    /// <summary>
    /// A new message representing the logging of Informational text
    /// </summary>
    /// <typeparam name="T">The source of the message</typeparam>
    public class Info<T> : LogMessage<T>
    {
        #region Properties

        /// <summary>
        /// Will always be Info
        /// </summary>
        public override LogLevel Level => LogLevel.Info;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a new instance using the specified message string
        /// </summary>
        /// <param name="message"></param>
        public Info(string message) : base(message)
        {
        }

        #endregion Constructors
    }

    /// <summary>
    /// A new message representing the logging of Informational text
    /// </summary>
    public class Info : LogMessage
    {
        #region Properties

        /// <summary>
        /// Will always be Info
        /// </summary>
        public override LogLevel Level => LogLevel.Info;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a new instance using the specified message string
        /// </summary>
        public Info(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}