using System;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.LogLibrary
{
    public class Logger : ILogger
    {
        public Logger()
        {

        }

        public void LogInfo(string message)
        {
            var logMessage = $"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {message}";
            Console.WriteLine(logMessage);
        }

        public void LogError(string message, Exception ex = null)
        {
            var errorMessage = $"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {message}";
            if (ex != null)
            {
                errorMessage += $" - Exception: {ex.Message}";
            }
            Console.WriteLine(errorMessage);
        }
    }
}
