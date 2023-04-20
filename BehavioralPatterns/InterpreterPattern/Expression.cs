namespace Design_Patterns_C_.BehavioralPatterns.InterpreterPattern;

public interface Expression
{
    public void Interpret(Stack<int> stack);
}