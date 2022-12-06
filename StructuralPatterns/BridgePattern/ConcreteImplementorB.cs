// 利用する処理を実現B

namespace Design_Patterns_C_.StructuralPatterns.BridgePattern;

public class ConcreateImplementorB : Implementor
{
    public void OperationImpl()
    {
        System.Console.WriteLine($"{this.GetType().FullName}の処理です!");
    }
}