// インフォメーションログクラス
namespace Design_Patterns_C_.BehavioralPatterns.ChainOfResponsibilityPattern;

public class InfoLogger : AbstractLogger
{
    protected override void WriteLog(string message)
    {
        System.Console.WriteLine($"Info：{message}");;
    }

    protected override int Level => LOG_LEVEL_INFO;
}