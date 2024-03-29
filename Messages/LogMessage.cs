﻿using Penguin.Messaging.Abstractions.Messages;
using System;

namespace Penguin.Messaging.Logging.Messages
{
    /// <summary>
    /// Any generic log message and associated object
    /// </summary>
    /// <typeparam name="T">The type of the system involved</typeparam>
    public class LogMessage<T> : Message
    {
        /// <summary>
        /// The log level. defaults to Debug
        /// </summary>
        public virtual LogLevel Level { get; set; }

        /// <summary>
        /// The message associated with this event
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Creates a new LogMessage with the associated message
        /// </summary>
        /// <param name="message">the message</param>
        public LogMessage(string message) : base()
        {
            Message = message;
        }

        /// <summary>
        /// Creates a new LogMessage with the exception as a base
        /// </summary>
        /// <param name="ex">The exception to log</param>
        public LogMessage(Exception ex) : base()
        {
            if (ex is null)
            {
                throw new ArgumentNullException(nameof(ex));
            }

            Level = LogLevel.Error;
            Message = $"{ex.Message}\r\n{ex.StackTrace}";
        }
    }

    /// <summary>
    /// A generic log message
    /// </summary>
    public class LogMessage : Message
    {
        /// <summary>
        /// Defaults to Debug
        /// </summary>
        public virtual LogLevel Level { get; set; }

        /// <summary>
        /// the associated message for this log
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Creates a new instance of the log message using the specified message
        /// </summary>
        /// <param name="message">The message to include with the log</param>
        public LogMessage(string message) : base()
        {
            Message = message;
        }

        /// <summary>
        /// Creates an instance of the log message using the error as a source
        /// </summary>
        /// <param name="ex">The exception to log</param>
        public LogMessage(Exception ex) : base()
        {
            if (ex is null)
            {
                throw new ArgumentNullException(nameof(ex));
            }

            Level = LogLevel.Error;
            Message = $"{ex.GetType()}: {ex.Message}\r\n{ex.StackTrace}";
        }
    }
}