static class LogLine
{
    public static string Message(string logLine)
    {
        var messageStart = logLine.IndexOf(':') + 1;
        return logLine.Substring(messageStart).Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        var levelEnd = logLine.IndexOf(':');
        return logLine.Substring(1, levelEnd - 2).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        var message = Message(logLine);
        var level = LogLevel(logLine);
        return $"{message} ({level})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
