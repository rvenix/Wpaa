using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatedCode
{
    public class Logger
    {
        public void LogError(string message, DateTime timestamp)
        {
            Log(message, timestamp, LogTypeEnum.Error);
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            Log(message, timestamp, LogTypeEnum.Warining);
        }

        public void Log(string message, DateTime timestamp, string type)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            string formattedMessage = $"{type}: [{formattedTimestamp}] {message}";
            Console.WriteLine(formattedMessage);
        }
    }
}
