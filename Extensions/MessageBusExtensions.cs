using Penguin.Messaging.Core;
using Penguin.Messaging.Logging.Messages;
using System;
using System.Diagnostics.Contracts;

namespace Penguin.Messaging.Logging.Extensions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public static class MessageBusExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        /// <summary>
        /// Logs an error message to the message bus
        /// </summary>
        /// <param name="messageBus">The message bus</param>
        /// <param name="ex">The exception to log</param>
        public static void Log(this MessageBus messageBus, Exception ex)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            while (ex != null)
            {
                messageBus.Send(new ErrorMessage(ex));
                ex = ex.InnerException;
            }
        }

        /// <summary>
        /// Logs a string to the message bus at the specified level.
        /// </summary>
        /// <param name="messageBus">The message bus to use</param>
        /// <param name="Message">The message to send</param>
        /// <param name="level">The log level</param>
        public static void Log(this MessageBus messageBus, string Message, LogLevel level = LogLevel.Info)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            messageBus.Send(new LogMessage(Message) { Level = level });
        }

        /// <summary>
        /// Logs an error message to the message bus
        /// </summary>
        /// <typeparam name="T">The message source</typeparam>
        /// <param name="messageBus">The message bus</param>
        /// <param name="ex">The exception to log</param>
        public static void Log<T>(this MessageBus messageBus, Exception ex)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            while (ex != null)
            {
                messageBus.Send(new ErrorMessage<T>(ex));
                ex = ex.InnerException;
            }
        }

        /// <summary>
        /// Logs a string to the message bus at the specified level.
        /// </summary>
        /// <typeparam name="T">The message source</typeparam>
        /// <param name="messageBus">The message bus to use</param>
        /// <param name="Message">The message to send</param>
        /// <param name="level">The log level</param>
        public static void Log<T>(this MessageBus messageBus, string Message, LogLevel level = LogLevel.Info)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            messageBus.Send(new LogMessage<T>(Message) { Level = level });
        }

        /// <summary>
        /// Logs a string as a warning
        /// </summary>
        /// <param name="messageBus">The message bus to use</param>
        /// <param name="Message">The message text</param>
        public static void Warn(this MessageBus messageBus, string Message)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            messageBus.Send(new LogMessage(Message) { Level = LogLevel.Warning });
        }

        /// <summary>
        /// Logs a string as a warning
        /// </summary>
        /// <typeparam name="T">The message source</typeparam>
        /// <param name="messageBus">The message bus to use</param>
        /// <param name="Message">The message text</param>
        public static void Warn<T>(this MessageBus messageBus, string Message)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            messageBus.Send(new LogMessage<T>(Message) { Level = LogLevel.Warning });
        }

        /// <summary>
        /// Logs a string as an Error
        /// </summary>
        /// <param name="messageBus">The message bus to use</param>
        /// <param name="Message">The message text</param>
        public static void Error(this MessageBus messageBus, string Message)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            messageBus.Send(new LogMessage(Message) { Level = LogLevel.Error });
        }

        /// <summary>
        /// Logs a string as an Error
        /// </summary>
        /// <typeparam name="T">The message source</typeparam>
        /// <param name="messageBus">The message bus to use</param>
        /// <param name="Message">The message text</param>
        public static void Error<T>(this MessageBus messageBus, string Message)
        {
            if (messageBus is null)
            {
                throw new ArgumentNullException(nameof(messageBus));
            }

            messageBus.Send(new LogMessage<T>(Message) { Level = LogLevel.Error });
        }
    }
}