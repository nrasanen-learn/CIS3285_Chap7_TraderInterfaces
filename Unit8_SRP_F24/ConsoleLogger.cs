using System;
using Unit8_SRP_F24.Contracts;

namespace Unit8_SRP_F24;

public class ConsoleLogger : ILogger
{
    public void LogMessage(string message, params object[] args)
    {
        WriteLog("INFO", message, args);
    }

    // Available when the logger is referenced as ConsoleLogger.
    public void LogMessage(string type, string message, params object[] args)
    {
        WriteLog(type, message, args);
    }

    private static void WriteLog(string type, string message, object[] args)
    {
        Console.WriteLine($"{type}: {message}", args);
    }
}
    


