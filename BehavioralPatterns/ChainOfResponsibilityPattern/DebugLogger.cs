// デバッグログクラス
namespace Design_Patterns_C_.BehavioralPatterns.ChainOfResponsibilityPattern;

public class DebugLogger : AbstractLogger
{
    protected override void WriteLog(string message)
    {
        System.Console.WriteLine($"Debug：{message}");;
    }

    protected override int Level => LOG_LEVEL_DEBUG;
}