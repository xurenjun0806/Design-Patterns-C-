// エラーログクラス
namespace Design_Patterns_C_.BehavioralPatterns.ChainOfResponsibilityPattern;

public class ErrorLogger : AbstractLogger
{
    protected override void WriteLog(string message)
    {
        System.Console.WriteLine($"Error:{message}");;
    }

    protected override int Level => LOG_LEVEL_ERROR;
}