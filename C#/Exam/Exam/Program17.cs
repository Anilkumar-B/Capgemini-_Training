using System;

namespace Exam
{
    // The ILogger interface
    public interface ILogger
    {
        void Log(string message);
    }

    // Concrete Logger (FileLogger) that implements ILogger
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    // Abstract Decorator Class (Extends ILogger)
    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void Log(string message);
    }

    // Timestamp Decorator (adds timestamp to log)
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _logger.Log($"[{timestamp}] {message}");
        }
    }

    // Error Categorization Decorator (adds error categorization to log)
    public class ErrorCategorizationLogger : LoggerDecorator
    {
        public ErrorCategorizationLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            _logger.Log($"[ERROR] {message}");
        }
    }

    // Combining decorators (Timestamp and Error Categorization)
    public class TimestampErrorLogger : LoggerDecorator
    {
        public TimestampErrorLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _logger.Log($"[{timestamp}] [ERROR] {message}");
        }
    }
}
