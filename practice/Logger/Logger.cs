namespace practice.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Logger
    {
        private static readonly Lazy<Logger> LazyLog = new Lazy<Logger>(() => new Logger());

        public static Logger GetInstance()
        {
            return LazyLog.Value;
        }

        public void Log(LogType type, string message, Exception ex = null)
        {
            if (ex != null)
            {
                message = $"{message}{ex.Message}";
            }

            string log = $"{DateTime.UtcNow.ToString("hh:mm:ss")}: {type} :{message}";
            Console.WriteLine(log);
        }
    }
}
