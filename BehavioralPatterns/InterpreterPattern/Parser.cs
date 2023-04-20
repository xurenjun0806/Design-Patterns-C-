namespace Design_Patterns_C_.BehavioralPatterns.InterpreterPattern;

public class Parser
{
    private List<Expression> ParseTree = new List<Expression>();

    public Parser(string context)
    {
        foreach (var s in context.Split(' '))
        {
            if (s.Equals("+"))
            {
                ParseTree.Add(new TerminalExpressionPlus());
            }
            else if (s.Equals("-"))
            {
                ParseTree.Add(new TerminalExpressionMinus());
            }
            else
            {
                ParseTree.Add(new TerminalExpressionNumber(int.Parse(s)));
            }
        }
    }

    public int Evaluate()
    {
        Stack<int> stack = new Stack<int>();
        foreach (var expression in ParseTree)
        {
            expression.Interpret(stack);
        }

        return stack.Pop();
    }
}