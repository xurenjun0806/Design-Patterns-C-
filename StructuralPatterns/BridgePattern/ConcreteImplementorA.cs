// 利用する処理を実現A

namespace Design_Patterns_C_.StructuralPatterns.BridgePattern;

public class ConcreateImplementorA : Implementor
{
    public void OperationImpl()
    {
        System.Console.WriteLine($"{this.GetType().FullName}の処理です!");
    }
}