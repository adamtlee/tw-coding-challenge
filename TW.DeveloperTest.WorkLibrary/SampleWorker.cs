using System;
using System.Text;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.WorkLibrary
{
    public class SampleWorker : IWorker
    {
        readonly Random _random;
        private readonly ILogger _logger;

        public SampleWorker(ILogger logger)
        {
            _random = new Random();
            _logger = logger;
        }

        public string GetResult()
        {
            int result = _random.Next(0, 100);

            if (result <= 95)
            {
                //TODO Log to logging library successes
                _logger.LogInfo(result.ToString());
                return RandomString(result);
            }

            throw new Exception($"Out of range exception - {result} > 95");
        }

        private string RandomString(int length)
        {
            const string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[_random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
