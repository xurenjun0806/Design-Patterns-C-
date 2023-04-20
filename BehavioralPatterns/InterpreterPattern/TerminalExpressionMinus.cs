namespace Design_Patterns_C_.BehavioralPatterns.InterpreterPattern;

public class TerminalExpressionMinus : Expression
{
    public void Interpret(Stack<int> stack)
    {
        int number1 = stack.Pop();
        int number2 = stack.Pop();
        int result = - number1 + number2;
        stack.Push(result);
    }
}