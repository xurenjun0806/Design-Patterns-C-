// オブジェクトアダプター(利用古いクラスのインスタンスを生成)

namespace Design_Patterns_C_.StructuralPatterns.AdapterPattern;

public class ObjectAdapter : ITarget
{
    private Adaptee adaptee = new Adaptee();
    public string RequiredMethod()
    {
        return adaptee.OldMethod();
    }
}