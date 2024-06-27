using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Utilities
{
    using System;
    using System.IO;

    public  class Logger
    {
        private static readonly string logFilePath = "application.log";

        public void LogInfo(string message) 
        {
            Log("INFO", message);
        }
        public void LogWarn(string message) 
        {
            Log("WARNING", message);
        }
        public void LogError(string message) 
        {
            Log("ERROR", message);
        }
        private void Log(string loglevel, string message)
        {
            var logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{loglevel}] {message}";
            Console.WriteLine(logMessage) ;

            try
            {
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log to file: {ex.Message}") ;
            }
        }
    }
}
