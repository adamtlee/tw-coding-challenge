using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.WorkLibrary
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
    }
}
