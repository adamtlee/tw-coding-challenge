using System;
using System.IO;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.LogLibrary
{
    public class Logger : ILogger
    {
        public Logger()
        {
           
        }

        private readonly string _logFilePath = $"C:/Repository/Toolwatch/csharp-interview-logging-master/Output/{DateTime.Now:yyyy-MM-dd}-log.txt";

        /// <summary>
        /// Logs an informational message to the console with a timestamp.
        /// </summary>
        /// <param name="message"> The message to be logged </param>
        public void LogInfo(string message)
        {
            var logMessage = $"[INFO] \n Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} \n Message:{message} \n";
            LogToFile(logMessage);
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
            LogToFile(errorMessage);
            if (ex != null)
            {
                errorMessage += $"\n Exception: {ex.Message}";
                LogToFile(errorMessage);
            }
            Console.WriteLine(errorMessage);
        }

        private void LogToFile(string message)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(_logFilePath, true))
                {
                    writer.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] \n {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} \n {ex.ToString()}");
            }
        }
    }
}
