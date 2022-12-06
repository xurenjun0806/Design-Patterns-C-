// 利用する処理を抽象を定義した抽象クラス

namespace Design_Patterns_C_.StructuralPatterns.BridgePattern;

public abstract class Abstraction
{
    protected Implementor impl;

    public Abstraction(Implementor impl)
    {
        this.impl = impl;
    }

    public virtual void Operation()
    {
        impl.OperationImpl();
    }
}