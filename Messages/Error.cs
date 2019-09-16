using System;

namespace Penguin.Messaging.Logging.Messages
{
    /// <summary>
    /// A log message representing an error
    /// </summary>
    /// <typeparam name="T">The source of the error</typeparam>
    public class ErrorMessage<T> : LogMessage<T>
    {
        /// <summary>
        /// Will always be Error
        /// </summary>
        public override LogLevel Level => LogLevel.Error;

        /// <summary>
        /// Create a new error message using the specified string as a base
        /// </summary>
        /// <param name="message">The message to use</param>
        public ErrorMessage(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates an instance of the error message using the error as a source
        /// </summary>
        /// <param name="ex">The exception to log</param>
        public ErrorMessage(Exception ex) : base(ex) { }
    }

    /// <summary>
    /// A log message representing an error
    /// </summary>
    public class ErrorMessage : LogMessage
    {
        /// <summary>
        /// Will always be Error
        /// </summary>
        public override LogLevel Level => LogLevel.Error;

        /// <summary>
        /// Create a new error message using the specified string as a base
        /// </summary>
        /// <param name="message">The message to use</param>
        public ErrorMessage(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates an instance of the error message using the error as a source
        /// </summary>
        /// <param name="ex">The exception to log</param>
        public ErrorMessage(Exception ex) : base(ex) { }
    }
}