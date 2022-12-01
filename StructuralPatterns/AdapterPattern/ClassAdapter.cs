// クラスアダプター(継承を利用)

namespace Design_Patterns_C_.StructuralPatterns.AdapterPattern;

public class ClassAdapter : Adaptee, ITarget
{
    public string RequiredMethod()
    {
        return this.OldMethod();
    }
}