using System;

namespace TW.DeveloperTest.Contracts
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message, Exception ex = null);
    }
}