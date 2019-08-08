namespace Penguin.Messaging.Logging
{
    /// <summary>
    /// The log level to publish
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Intended for debug time messages only
        /// </summary>
        Debug,

        /// <summary>
        /// Intended for any messages that are purely informational for later diagnostic
        /// </summary>
        Info,

        /// <summary>
        /// Something has gone wrong but we can recover from it
        /// </summary>
        Warning,

        /// <summary>
        /// Everything has gone terribly wrong and we cant recover
        /// </summary>
        Error
    }
}