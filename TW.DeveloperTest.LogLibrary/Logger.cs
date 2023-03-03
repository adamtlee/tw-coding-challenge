using System;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.LogLibrary
{
    public class Logger : ILogger
    {
        public Logger()
        {
           
        }

        /// <summary>
        /// Logs an informational message to the console with a timestamp.
        /// </summary>
        /// <param name="message"> The message to be logged </param>
        public void LogInfo(string message)
        {
            var logMessage = $"[INFO] \n Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} \n Message:{message} \n";
            Console.WriteLine(logMessage);
        }

        /// <summary>
        /// Logs an error message, optionally including the details of an exception.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="ex">The exception that caused the error (optional).</param>
        public void LogError(string message, Exception ex = null)
        {
            var errorMessage = $"[ERROR] \n Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} \n Message:{message} \n";
            if (ex != null)
            {
                errorMessage += $" - Exception: {ex.Message}";
            }
            Console.WriteLine(errorMessage);
        }
    }
}
