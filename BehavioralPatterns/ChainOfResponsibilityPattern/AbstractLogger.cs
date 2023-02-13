// 抽象ログクラス
namespace Design_Patterns_C_.BehavioralPatterns.ChainOfResponsibilityPattern;

public abstract class AbstractLogger
{
    public const int LOG_LEVEL_DEBUG = 1;
    public const int LOG_LEVEL_INFO = 2;
    public const int LOG_LEVEL_ERROR = 3;

    public void SetNextLogger(AbstractLogger nextLogger)
    {
        this.NextLogger = nextLogger;
    }

    public void LogMessage(int level, String message)
    {
        if (this.Level >= level)
        {
            WriteLog(message);
        }

        if (this.NextLogger == null) return;

        this.NextLogger.LogMessage(level, message);
    }

    protected abstract void WriteLog(string message);

    protected abstract int Level { get; }
    protected AbstractLogger? NextLogger {get; set;}
}