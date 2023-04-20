namespace Design_Patterns_C_.BehavioralPatterns.InterpreterPattern;

public class TerminalExpressionNumber : Expression
{
    private int number;

    public TerminalExpressionNumber(int number)
    {
        this.number = number;
    }

    public void Interpret(Stack<int> stack)
    {
        stack.Push(number);
    }
}