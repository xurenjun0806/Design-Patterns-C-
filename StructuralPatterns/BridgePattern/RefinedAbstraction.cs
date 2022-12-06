// 利用する処理の抽象を利用したクラス

namespace Design_Patterns_C_.StructuralPatterns.BridgePattern;

public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(Implementor impl)
    : base(impl)
    {
    }

    public override void Operation()
    {
        System.Console.WriteLine($"RefinedAbstraction {impl.GetType().FullName}");
        impl.OperationImpl();
    }
}