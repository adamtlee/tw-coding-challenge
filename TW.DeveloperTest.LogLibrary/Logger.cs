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
            var logMessage = $"[INFO] \n Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} \n Message:{message} \n";
            Console.WriteLine(logMessage);
        }

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
