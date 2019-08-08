using System;

namespace Penguin.Messaging.Logging.Messages
{
    /// <summary>
    /// A log message representing an error
    /// </summary>
    /// <typeparam name="T">The source of the error</typeparam>
    public class Error<T> : LogMessage<T>
    {
        #region Properties

        /// <summary>
        /// Will always be Error
        /// </summary>
        public override LogLevel Level => LogLevel.Error;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Create a new error message using the specified string as a base
        /// </summary>
        /// <param name="message">The message to use</param>
        public Error(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates an instance of the error message using the error as a source
        /// </summary>
        /// <param name="ex">The exception to log</param>
        public Error(Exception ex) : base(ex) { }

        #endregion Constructors
    }

    /// <summary>
    /// A log message representing an error
    /// </summary>
    public class Error : LogMessage
    {
        #region Properties

        /// <summary>
        /// Will always be Error
        /// </summary>
        public override LogLevel Level => LogLevel.Error;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Create a new error message using the specified string as a base
        /// </summary>
        /// <param name="message">The message to use</param>
        public Error(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates an instance of the error message using the error as a source
        /// </summary>
        /// <param name="ex">The exception to log</param>
        public Error(Exception ex) : base(ex) { }

        #endregion Constructors
    }
}